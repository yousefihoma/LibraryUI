using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel.Entities
{
    //User
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(50)]
        public string? UseName { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }

    }
}
