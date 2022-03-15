﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Technical_Assessement_V01.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }

        [Required , DataType(DataType.Date), Display(Name ="Date Of Puplication")]
        public DateTime DateOfPuplication { get; set; }

        //this is a cover image
        public string Cover { get; set; }


        public string Description { get; set; }

        public virtual List<Author>  Authors{ get; set; }
    }
}
