using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Departaments:BaseEntity
    {
        public int Id { get; set; } 
        public string DepartamentName { get; set; }
        public int StudentId { get; set; }
        public Student Students { get; set; }

    }
}
