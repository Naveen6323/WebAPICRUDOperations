using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Student: IStudent
    {
        [Key]
        public int rollno { get; set; }
        [Column("StudentName", TypeName = "varchar(100)")]
        public string name { get; set; }
        [Column("StudentBranch", TypeName = "varchar(50)")]
        public string branch { get; set; }
        [Column("StudentYear", TypeName = "varchar(20)")]
        public string year { get; set; }

    }
}
