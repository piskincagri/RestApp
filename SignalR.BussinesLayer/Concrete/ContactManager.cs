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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this._contactDal = contactDal;
        }

        public void TAdd(Contact entitiy)
        {
            _contactDal.Add(entitiy);
        }

        public void TDelete(Contact entitiy)
        {
            _contactDal.Delete(entitiy);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void TUpdate(Contact entitiy)
        {
            _contactDal.Update(entitiy);
        }
    }
}
