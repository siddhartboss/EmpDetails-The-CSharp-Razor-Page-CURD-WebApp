﻿using System.Security.Principal;

namespace RazorPageCurdDemo.Models
{
    public class EmpModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }

    }
}