using System.Collections.Generic;

namespace Ehome_BackEnd.Models
{
    public class Color:BaseEntity
    {
        public string Name { get; set; }
        public List<Futniture> Futniture { get; set; }
    }
}
