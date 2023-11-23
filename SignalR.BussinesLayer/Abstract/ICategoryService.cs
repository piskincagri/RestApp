using SignaIR.EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Abstract
{
   public interface ICategoryService:IGenericService<Category>
    {
        public int TCategoryCount();

        public int TActiveCategoryCount();

        public int TPassiveCategoryCount();

    }
}
