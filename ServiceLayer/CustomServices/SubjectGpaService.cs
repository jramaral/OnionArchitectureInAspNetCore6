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
    public class SubjectGpaService : ICustomService<SubjectGpas>
    {
        private readonly IRepository<SubjectGpas> _repository;

        public SubjectGpaService(IRepository<SubjectGpas> repository)
        {
            _repository = repository;
        }

        public void Delete(SubjectGpas entity)
        {
            _repository.Delete(entity);
            _repository.SaveChanges();
        }

        public SubjectGpas Get(int Id)
        {
            var gpa = _repository.Get(Id);
            if (gpa != null)
            {
                return gpa;
            }

            return new SubjectGpas();
        }

        public IEnumerable<SubjectGpas> GetAll()
        {
            var gpas = _repository.GetAll();
            if (gpas != null)
            {
                return gpas;
            }

            return Enumerable.Empty<SubjectGpas>();
        }

        public void Insert(SubjectGpas entity)
        {
            if (entity != null)
            {
                _repository.Insert(entity);
                _repository.SaveChanges();
            }
        }

        public void Remove(SubjectGpas entity)
        {
            if (entity != null)
            {
                _repository.Remove(entity);
                _repository.SaveChanges();
            }
        }

        public void Update(SubjectGpas entity)
        {
            if (entity != null)
            {
                _repository.Update(entity);
                _repository.SaveChanges();
            }
        }
    }
}
