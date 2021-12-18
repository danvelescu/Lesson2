using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Model
{
    public class Product
    {

        public Product() {
            ProductID.ID++;
            this.Id = ProductID.ID;
        }

        public int Id { get; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public TypeOfProduct TypeOfProduct { get; set; }
        public string Description { get; set; }
    }
}
