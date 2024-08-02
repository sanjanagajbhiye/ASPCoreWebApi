using System;
using System.Collections.Generic;

namespace ASPCoreWebApi.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string Standard { get; set; } = null!;
        public DateTime Dob { get; set; }
    }
}
