using HomeworkOne.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOne.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(LoginViewModel login)
        {
            if (ModelState.IsValid)
                return Ok(new ResponseViewModel() { Success = true, Data = "Giriş İşlemi Başarılı", ErrorMessage = string.Empty });
            else
                return BadRequest(new ResponseViewModel() { Success = false, Data = "Giriş İşlemi Başarısız", ErrorMessage = "Hatalı Giriş!" });

        }
    }
}
