﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaIRWebUI.Dtos.SocialMediaDtos
{
    public   class GetSocialMediaDto
    {
        public int SocialMediaID { get; set; }

        public string Title { get; set; }

        public string URL { get; set; }

        public string Icon { get; set; }


    }
}
