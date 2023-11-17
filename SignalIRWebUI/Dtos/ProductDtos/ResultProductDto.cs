﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; }

        public bool ProductStatus { get; set; }

        public string CategoryName { get; set; }

    }
}