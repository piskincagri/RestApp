﻿using SignaIR.DataAccessLayer.Abstract;
using SignaIR.DataAccessLayer.Concrete;
using SignaIR.DataAccessLayer.Repositories;
using SignaIR.EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaIR.DataAccessLayer.EntitiyFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(SignalRContext context) : base(context)
        {
        }
    }
}
