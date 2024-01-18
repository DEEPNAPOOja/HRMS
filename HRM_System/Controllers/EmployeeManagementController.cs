﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HRM_System.Controllers
{
    [Authorize(Roles = SD.Role_Admin)]
    public class EmployeeManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
