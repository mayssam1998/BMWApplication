﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tache.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int salaire { get; set; }
    }
}