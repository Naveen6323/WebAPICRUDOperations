using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface IStudent
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public string branch { get; set; }
        public string year { get; set; }

    }
}
