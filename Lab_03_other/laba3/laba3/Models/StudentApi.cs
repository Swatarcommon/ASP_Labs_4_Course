using laba3.Models;


namespace laba3.Controllers
{
    public class StudentApi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Link Link { get; set; }

        public StudentApi(Student stud, Link link)
        {
            Id = stud.id;
            Name = stud.name;
            Phone = stud.phone;
            this.Link = link;
        }

        public StudentApi()
        {

        }
    }
}