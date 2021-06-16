using System;
using Microsoft.AspNetCore.Mvc;

namespace OnionInvesto.UI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

    }
}
