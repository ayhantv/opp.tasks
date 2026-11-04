using opps.tasks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace opps.tasks.Data
{
    public  class Student:BaseEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }    
        public string Email { get; set; }    
        public string Address { get; set; }
        public double Grade { get; set; }
    }
}
