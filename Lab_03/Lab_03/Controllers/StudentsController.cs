using Lab_03.DAL;
using Lab_03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_03.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase {
        private readonly ILogger<StudentsController> _logger;
        private UnitOfWork unitOfWork;

        public StudentsController(ILogger<StudentsController> logger, UnitOfWork unitOfWork) {
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Student> Get(string type = "json", string limit = "2", string offset = "0", string minid = "0", string maxid = "100",
            string like = null, string globallike = null, string columns = "id, name, phone", string sort = "id") {
            var students = unitOfWork.StudentsRepository.Get(type, Convert.ToInt32(limit), Convert.ToInt32(offset), Convert.ToInt32(minid),
                Convert.ToInt32(maxid), like, globallike, columns, sort).ToList();
            return students;
        }

        [HttpPost]
        public Student Post(Student student) {
            unitOfWork.StudentsRepository.Insert(student);
            unitOfWork.Save();
            return student;
        }
        [HttpPut]
        public Student Put(Student student) {
            unitOfWork.StudentsRepository.Update(student);
            unitOfWork.Save();
            return student;
        }
        [HttpDelete]
        public Student Delete(int id) {
            var itemToDelete = unitOfWork.StudentsRepository.Delete(id);
            unitOfWork.Save();
            return itemToDelete;
        }
    }
}
