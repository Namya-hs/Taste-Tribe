﻿using Microsoft.AspNetCore.Mvc;
using Shared;
using System.Text.Json;
using Users.Services;

namespace Users.Controllers
{
    public class UserController : Controller
    {
        public IUserService _user;
        public UserController(IUserService user)
        {
            _user = user;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            var u = _user.SendMessage("User-Topic", JsonSerializer.Serialize(user));
            return Ok(u);
        }
    }
}