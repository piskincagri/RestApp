using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaIRWebUI.Dtos.NatificationDtos
{
  public  class CreateNotificationDto
    {
     

        public string Type { get; set; }
        public string Icon { get; set; }

        public string Desciption { get; set; }

        public DateTime Date { get; set; }

        public bool Status { get; set; }

    }
}
