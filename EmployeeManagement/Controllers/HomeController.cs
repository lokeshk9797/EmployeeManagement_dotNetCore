﻿using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository )
        {
            _employeeRepository = employeeRepository;     
        }
        public String Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
    }
}
