﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.Dtos.CategoryDtos
{
    public class UpdateCategoryDto
    {

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public bool Status { get; set; }
    }
}
