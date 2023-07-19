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
    public class DepartamentsService : ICustomService<Departaments>
    {
        private readonly IRepository<Departaments> _repository;

        public DepartamentsService(IRepository<Departaments> repository)
        {
            _repository = repository;
        }

    
        public void Delete(Departaments entity)
        {
            _repository.Delete(entity);
            _repository.SaveChanges();
        }

        public Departaments Get(int Id)
        {
            var departament = _repository.Get(Id);
            if (departament != null)
            {
                return departament;
            }

            return new Departaments();
        }

        public IEnumerable<Departaments> GetAll()
        {
            var listDepartaments = _repository.GetAll();
            if (listDepartaments != null)
            {
                return listDepartaments;
            }

            return Enumerable.Empty<Departaments>();
        }

        public void Insert(Departaments entity)
        {
            if (entity != null)
            {
                _repository.Insert(entity);
                _repository.SaveChanges();
            }
        }

        public void Remove(Departaments entity)
        {
            if (entity != null)
            {
                _repository.Remove(entity);
                _repository.SaveChanges();
            }
        }

        public void Update(Departaments entity)
        {
            if (entity != null)
            {
                _repository.Update(entity);
                _repository.SaveChanges();
            }
        }
    }
}
