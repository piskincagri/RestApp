﻿using SignaIR.EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaIR.DataAccessLayer.Abstract
{
   public interface ICategoryDal:IGenericDal<Category>
    {
        public int CategoryCount();

        public int ActiveCategoryCount();

        public int PassiveCategoryCount();

    }
}
