﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaIR.DtoLayer.ProductDto
{
    public class CreateProductDto
    {
 

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; }

        public bool ProductStatus { get; set; }

    }
}
