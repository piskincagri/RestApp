using SignaIR.DataAccessLayer.Abstract;
using SignaIR.EntitiyLayer.Entities;
using SignalR.BussinesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void BookingStatusApproved(int id)
        {
            _bookingDal.BookingStatusApproved(id);
        }

        public void BookingStatusCancelled(int id)
        {
            _bookingDal.BookingStatusCancelled(id);
        }

        public void TAdd(Booking entitiy)
        {
            _bookingDal.Add(entitiy);
        }

        public void TDelete(Booking entitiy)
        {
            _bookingDal.Delete(entitiy);
        }

        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetListAll()
        {
            return _bookingDal.GetListAll();
        }

        public void TUpdate(Booking entitiy)
        {
            _bookingDal.Update(entitiy);
        }
    }
}
