using laba3.Controllers;
using laba3.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace laba3.Services
{
    public class StudentService
    {
        private static readonly Context Context = new Context();

        private readonly DbSet<Student> students = Context.Students;

        public List<Student> GetAll() => students.ToList();

        public object GetStudents(string type, string sort, int limit, int offset, int minid, int maxid,string like, string globallike, string columns)
        {
            if (type == null)
                type = "json";
            if (sort == null)
                sort = "id";
            if (limit == 0)
                limit = 2;
            if (maxid == 0)
                maxid = 100;
            if (columns == null)
                columns = "id, name, phone";

            List<Student> students = Context.Students.ToList();
            if (sort == "name")
                students = students.OrderBy(prop => prop.name).ToList();
            else if (sort == "id")
                students = students.OrderBy(prop => prop.id).ToList();
            else
                return JsonConvert.SerializeObject(new Link("Pls use for parameter sort values name and id", "/Home/Error"));

            students = students.Skip(offset).Take(limit).Where(prop => prop.id >= minid && prop.id <= maxid).ToList();

            if (like != null)
            {
                students = students.Where(prop => prop.name.ToLower().Contains(like.ToLower())).ToList();
            }

            if (globallike != null)
            {
                students = students.Where(prop => (prop.name + prop.id.ToString() + prop.phone).ToLower().Contains(globallike.ToLower())).ToList();
            }

            List<StudentApi> studentsApi = new List<StudentApi>();
            string[] columsArr = columns.Split(',');
            foreach (Student student in students)
            {
                StudentApi studentApi = new StudentApi();
                for (int i = 0; i < columsArr.Length; i++)
                    if (columsArr[i].Contains("id"))
                        studentApi.Id = student.id;
                for (int i = 0; i < columsArr.Length; i++)
                    if (columsArr[i].Contains("name"))
                        studentApi.Name = student.name;
                for (int i = 0; i < columsArr.Length; i++)
                    if (columsArr[i].Contains("phone"))
                        studentApi.Phone = student.phone;
                studentApi.Link = new Link("self", "/api/Values/" + student.id);
                studentsApi.Add(studentApi);
            }

            if (type.ToLower() == "xml")
            {
                using (StringWriter stringwriter = new System.IO.StringWriter())
                {
                    var serializer = new XmlSerializer(studentsApi.GetType());
                    serializer.Serialize(stringwriter, studentsApi);
                    return stringwriter.ToString();
                }
            }
            else if (type.ToLower() == "json")
            return JsonConvert.SerializeObject(studentsApi, 
                    Newtonsoft.Json.Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
            else
                return JsonConvert.SerializeObject(new Link("Pls use for parameter type values json and xml", "/Home/Error"));
        }

        public object GetStudent(int id, string type)
        {
            StudentService studentService = new StudentService();
            Student student = studentService.GetById(id);

            if (student != null)
            {
                if (type.ToLower() == "xml")
                {
                    using (StringWriter stringwriter = new System.IO.StringWriter())
                    {
                        StudentApi studentApi = new StudentApi(student, new Link("self", "/api/Values/" + student.id));
                        var serializer = new XmlSerializer(studentApi.GetType());
                        serializer.Serialize(stringwriter, studentApi);
                        return stringwriter.ToString();
                    }
                }
                else if (type.ToLower() == "json")
                    return JsonConvert.SerializeObject(new StudentApi(student, new Link("self", "/api/Values/" + student.id)));
                else
                    return JsonConvert.SerializeObject(new Link("Pls use for parameter type values json and xml", "/Home/Error"));
            }
            else
                return JsonConvert.SerializeObject(new Link("Student with id " + id + " not exist", "/Home/Error"));
        }

        public void Add(Student student)
        {
            students.Add(student);
            Context.SaveChanges();
        }

        public void Update(Student student)
        {
            var p = GetById(student.id);
            p.name = student.name;
            p.phone = student.phone;
            Context.SaveChanges();
        }

        public void RemoveById(int id)
        {
            var p = GetById(id);
            students.Remove(p);
            Context.SaveChanges();
        }

        public Student GetById(int id) => GetAll().Find(p => p.id == id);

    }
}