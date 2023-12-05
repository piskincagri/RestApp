using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.Controllers
{
    public class QRCodeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(string value)
        {

            

            using (MemoryStream memoryStream = new MemoryStream())
            {

                QRCodeGenerator createQrCode = new QRCodeGenerator();
                QRCodeGenerator.QRCode squreCode = createQrCode.CreateQrCode(value,QRCodeGenerator.ECCLevel.H);
                using (Bitmap image = squreCode.GetGraphic(10))
                {
                    image.Save(memoryStream, ImageFormat.Png);
                    ViewBag.QrCodeImage = "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
                }
            }


                return View();
        }
    }
}
