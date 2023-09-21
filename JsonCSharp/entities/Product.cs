using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonCSharp.entities
{
    public class Product
    {   
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}