﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nexu_SMS.DTO
{
    public class Teacherdto
    {
        public string teacherid { get; set; }
        public string teacherFirstName { get; set; }

        public string teacherLastName { get; set;}
        public DateTime dateOfBirth { get; set; }

        
        public string teacherGender { get; set; }


        public string teacherSubjectTaught { get; set; }

        public string teacherEmail { get; set; }
        
    }
}
