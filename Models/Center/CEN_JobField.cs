﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JOBGATE.Models
{
    public class CEN_JobField
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string JobFieldID { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string JobFieldTH { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string JobFieldEN { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string JobCategoryID { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string JobCategoryTH { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string JobCategoryEN { get; set; }
    }
}
