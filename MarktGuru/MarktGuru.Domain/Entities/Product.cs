using MarktGuru.Domain.Common;
using System;

namespace MarktGuru.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
