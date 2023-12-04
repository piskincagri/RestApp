using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignaIR.DtoLayer.ContactDto;
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
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult ContactList()
        {

            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                Location = createContactDto.Location,
                Phone = createContactDto.Phone,
                Mail = createContactDto.Mail,
                FooterDescription = createContactDto.FooterDescription,
                FooterTitle=createContactDto.FooterTitle,
                OpenDays=createContactDto.OpenDays,
                OpenDaysDescription=createContactDto.OpenDaysDescription,
                OpenHours=createContactDto.OpenHours

            });

            return Ok("Kontak bilgileri eklendi");


        }

        [HttpDelete("{id}")]
        public IActionResult ContactContact(int id)
        {

            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("Kontak bilgileri silindi");


        }

        [HttpGet("{id}")]

        public IActionResult GetContact(int id)

        {

            var value = _contactService.TGetByID(id);
            return Ok(value);

        }

        [HttpPut]

        public IActionResult UpdateContact(UpdateContactDto updateContactDto)

        {
            _contactService.TUpdate(new Contact()
            {
                ContactID=updateContactDto.ContactID,
                Location = updateContactDto.Location,
                Phone = updateContactDto.Phone,
                Mail = updateContactDto.Mail,
                FooterDescription = updateContactDto.FooterDescription,
                FooterTitle = updateContactDto.FooterTitle,
                OpenDays = updateContactDto.OpenDays,
                OpenDaysDescription = updateContactDto.OpenDaysDescription,
                OpenHours = updateContactDto.OpenHours

            });
            return Ok("Kontak Bilgileri Güncellendi");
        }

    }
}
