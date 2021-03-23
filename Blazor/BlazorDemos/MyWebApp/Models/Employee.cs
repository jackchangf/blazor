using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyWebApp.Models
{
    [Table("Employees")] //user , in employees text to add scheme "Employees, schema"
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        virtual public int EmployeeID { get; set; }

        [Required]
        [StringLength(60)]
        virtual public string EmployeeName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DefaultValue(0.0)]
        public decimal Salary { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsEnabled { get; set; }

    }
}
