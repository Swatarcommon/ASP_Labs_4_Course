using Lab_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_03.DAL {
    public class UnitOfWork {
        private MyDbContext context;
        private GenericRepository<Student> studentsRepository;

        public UnitOfWork(MyDbContext context) {
            this.context = context;
        }

        public GenericRepository<Student> StudentsRepository {
            get {

                if (this.studentsRepository == null) {
                    this.studentsRepository = new GenericRepository<Student>(context);
                }
                return studentsRepository;
            }
        }

        public void Save() {
            context.SaveChanges();
        }

        //private bool disposed = false;

        //protected virtual void Dispose(bool disposing) {
        //    if (!this.disposed) {
        //        if (disposing) {
        //            context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose() {
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
