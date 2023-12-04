using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignaIR.DtoLayer.MessageDto;
using SignaIR.EntitiyLayer.Entities;
using SignalR.BussinesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {

        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult MessageList()

        {
            var values = _messageService.TGetListAll();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            Message message = new Message()
            {

              Mail= createMessageDto.Mail,
              MessageContent=createMessageDto.MessageContent,
              MessageSendDate=createMessageDto.MessageSendDate,
              NameSurname=createMessageDto.NameSurname,
              Phone=createMessageDto.Phone,
              Status=createMessageDto.Status,
              Subject=createMessageDto.Subject

            };
            _messageService.TAdd(message);
            return Ok("Mesaj başarılı şekilde eklendi");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            _messageService.TDelete(value);
            return Ok("Mesaj başarılı şekilde silindi");

        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateeMessageDto)
        {
            Message message = new Message()
            {
                MessageID=updateeMessageDto.MessageID,
                Mail= updateeMessageDto.Mail,
                MessageContent = updateeMessageDto.MessageContent,
                MessageSendDate = updateeMessageDto.MessageSendDate,
                NameSurname = updateeMessageDto.NameSurname,
                Phone = updateeMessageDto.Phone,
                Status = updateeMessageDto.Status,
                Subject = updateeMessageDto.Subject


            };

            _messageService.TUpdate(message);
            return Ok("Mesaj başarlı şekilde güncellendi");

        }

        [HttpGet("{id}")]

        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            return Ok(value);

        }

    }
}
