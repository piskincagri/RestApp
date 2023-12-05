using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignaIR.EntitiyLayer.Entities;
using SignaIRWebUI.Dtos.IdentitiyDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.Controllers
{
    public class SettingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditDto userEditDto = new UserEditDto();
            userEditDto.Surname = values.Surname;
            userEditDto.Name = values.Name;
            userEditDto.UserName = values.UserName;
            userEditDto.Mail = values.Email;
          
            return View(userEditDto);
        }
    }
}
