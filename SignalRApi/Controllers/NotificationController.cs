using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignaIR.DtoLayer.NotificationDto;
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
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]

        public IActionResult NotificationList()
        {
            return Ok(_notificationService.TGetListAll());

        }

        [HttpGet("NotificationCountByStatusFalse")]

        public IActionResult NotificationCountByStatusFalse()
        {
            return Ok(_notificationService.TNotificationCountByStatusFalse());

        }

        [HttpGet("GetAllNotificationByFalse")]
        public IActionResult GetAllNotificationByFalse()
        {
            return Ok(_notificationService.TGetAllNotificationByFalse());

        }

        [HttpPost]

        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            Notification notification = new Notification()
            {
                Desciption = createNotificationDto.Desciption,
                Icon = createNotificationDto.Icon,
                Status = false,
                Type = createNotificationDto.Type,
                Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())

        };
            _notificationService.TAdd(notification);

            return Ok("Bildirim ekleme işlemi başarılı");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNotification(int id)
        {
            var value = _notificationService.TGetByID(id);
            _notificationService.TDelete(value);

            return Ok("Bildirim Alanı silindi");

        }

        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _notificationService.TGetByID(id);

            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            Notification notification = new Notification()
            {
                NotificationID=updateNotificationDto.NotificationID,
                Desciption = updateNotificationDto.Desciption,
                Icon = updateNotificationDto.Icon,
                Status = updateNotificationDto.Status,
                Type = updateNotificationDto.Type,
                Date = updateNotificationDto.Date

            };
            _notificationService.TUpdate(notification);

            return Ok("Bildirim güncelleme işlemi başarılı");

        }

        [HttpGet("NotificationStatusChangeToFalse/{id}")]
        public IActionResult NotificationStatusChangeToFalse(int id)
        {
            _notificationService.TNotificationStatusChangeToFalse(id);

            return Ok("Bildirim güncellemesi yapıldı.");
        }

        [HttpGet("NotificationStatusChangeToTrue/{id}")]
        public IActionResult NotificationStatusChangeToTrue(int id)
        {
            _notificationService.TNotificationStatusChangeToTrue(id);

            return Ok("Bildirim güncellemesi yapıldı.");
        }

    }
}
