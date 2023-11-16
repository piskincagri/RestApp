using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIR.EntitiyLayer.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public bool Status { get; set; }

        public List<Product> Products { get; set; }

    }
}
