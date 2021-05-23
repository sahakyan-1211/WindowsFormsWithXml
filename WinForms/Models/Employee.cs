using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models
    {
    class Employee
        {
        public Guid _id { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public int _age { get; set; }
        public string _email { get; set; }

        }
    }
