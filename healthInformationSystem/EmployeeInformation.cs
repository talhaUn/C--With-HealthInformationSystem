﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthInformationSystem
{
    public class EmployeeInformation
    {
        public int id { get; set; }
        public int hospitalid { get; set; }
        public int policlinicid { get; set; }
        public string nameSurname { get; set; }
        public string tcNo { get; set; }
        public string telNo { get; set; }
        public string address { get; set; }
        public string title { get; set; }
        public string department { get; set; }
        public string hospitalName { get; set; }
        public string eMail { get; set; }
        public string password { get; set; }
    }
}
