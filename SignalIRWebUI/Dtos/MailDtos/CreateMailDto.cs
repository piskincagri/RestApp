using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.Dtos.MailDtos
{
    public class CreateMailDto


    {

        public string ReciverMail { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

    }
}
