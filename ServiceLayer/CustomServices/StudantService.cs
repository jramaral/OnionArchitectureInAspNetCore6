using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.ICustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CustomServices
{
    public class StudantService : ICustomService<Student>
    {
        private readonly IRepository<Student> _repository;

        public StudantService(IRepository<Student> repository)
        {
            _repository = repository;
        }

        public void Delete(Student entity)
        {
            _repository.Delete(entity);
            _repository.SaveChanges();
        }

        public Student Get(int Id)
        {
            var student = _repository.Get(Id);
            if (student != null)
            {
                return student;
            }

            return new Student();
        }

        public IEnumerable<Student> GetAll()
        {
            var students = _repository.GetAll();
            if (students != null)
            {
                return students;
            }

            return Enumerable.Empty<Student>();
        }

        public void Insert(Student entity)
        {
            if (entity != null)
            {
                _repository.Insert(entity);
                _repository.SaveChanges();
            }
        }

        public void Remove(Student entity)
        {
            if (entity != null)
            {
                _repository.Remove(entity);
                _repository.SaveChanges();
            }
        }

        public void Update(Student entity)
        {
            if (entity != null)
            {
                _repository.Update(entity);
                _repository.SaveChanges();
            }
        }
    }
}
