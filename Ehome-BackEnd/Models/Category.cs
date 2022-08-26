using System.Collections.Generic;

namespace Ehome_BackEnd.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Futniture> Futnitures  { get; set; }
    }
}
