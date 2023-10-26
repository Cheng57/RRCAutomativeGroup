using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wu.Cheng.RRCAGApp
{
    internal class Fragrance
    {
        public string Description
        {
            get;
          
            set;
        }
        public decimal Price
        {
            get;

            set;
        }

        public Fragrance()
        {

        }

        public Fragrance(string description, decimal price)
        {
            this.Description = description;
            this.Price = price;
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
