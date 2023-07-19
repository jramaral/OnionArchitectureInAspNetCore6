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
    public class ResultService : ICustomService<Results>
    {
        private readonly IRepository<Results> _repository;

        public ResultService(IRepository<Results> repository)
        {
            _repository = repository;
        }

        public void Delete(Results entity)
        {
            _repository.Delete(entity);
            _repository.SaveChanges();
        }

        public Results Get(int Id)
        {
            var result = _repository.Get(Id);
            if (result != null)
            {
                return result;
            }

            return new Results();
        }

        public IEnumerable<Results> GetAll()
        {
            var results = _repository.GetAll();
            if (results != null)
            {
                return results;
            }

            return Enumerable.Empty<Results>();
        }

        public void Insert(Results entity)
        {
            if (entity != null)
            {
                _repository.Insert(entity);
                _repository.SaveChanges();
            }
        }

        public void Remove(Results entity)
        {
            if (entity != null)
            {
                _repository.Remove(entity);
                _repository.SaveChanges();
            }
        }

        public void Update(Results entity)
        {

            if (entity != null)
            {
                _repository.Update(entity);
                _repository.SaveChanges();
            }
        }
    }
}
