﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp.ViewModels
{
    public class EmployeeViewModel : Employee
    {
        [Display(Name = "Employee ID")] //this is the label
        public override int EmployeeID { get => base.EmployeeID; set => base.EmployeeID = value; }

        [Display(Name = "Employee Name")]
        [MinLength(3, ErrorMessage = "Employee Name cannot be lesser than 3 characters")]
        [MaxLength(60, ErrorMessage ="Name cannot have more than 60 characters")]
        public override string EmployeeName { get => base.EmployeeName; set => base.EmployeeName = value; }
    }
}
