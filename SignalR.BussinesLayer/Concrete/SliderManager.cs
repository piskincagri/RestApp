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
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider entitiy)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Slider entitiy)
        {
            throw new NotImplementedException();
        }

        public Slider TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Slider> TGetListAll()
        {
            return _sliderDal.GetListAll();
        }

        public void TUpdate(Slider entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
