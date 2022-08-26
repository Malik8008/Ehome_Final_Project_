using System.Collections.Generic;

namespace Ehome_BackEnd.Models
{
    public class Matreal:BaseEntity
    {
        public string Name { get; set; }
        public List<Futniture> Futnitures { get; set; }

    }
}
