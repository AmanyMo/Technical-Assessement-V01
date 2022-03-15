using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Technical_Assessement_V01.Models
{
    public class Author
    {
        [Key]
        public int ID{ get; set; }

        [Required]
        public string Name { get; set; }

        [Required , DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public string Bio { get; set; }

        public string Image { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
