using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Snippet: prop > tab x2
    class Product
    {
        public int Id { get; set; }
        //We write CategoryId right after the Id because
        //it is foreign key
        public int CategoryId { get; set; } 
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
