using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SignaIRWebUI.Dtos.MailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CreateMailDto createMailDto)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Banker's Burger Rezervasyon", "xxxx@hotmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", createMailDto.ReciverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = createMailDto.Body;

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject= createMailDto.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.office365.com", 587, false);
            client.Authenticate("xxxx@hotmail.com", "password");

            client.Send(mimeMessage);
            client.Disconnect(true);



            return RedirectToAction("Index", "Category");
        }

    }

}
