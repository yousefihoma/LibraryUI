using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=Library;User Id=LAdmin;Password=;jhfohkI20;");
        }
        public virtual DbSet<Member> Members { get; set; }
    }


    //User
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(50)]
        public string UseName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

    }

    //Member
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        [MaxLength(50)]
        [Required(AllowEmptyStrings =false)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public int MemberNum { get; set; }
        public bool GenderID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string NationalCode { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string DateOfBirth { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string FirstDate { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CurrentDate { get; set; }

        [MaxLength(50)]
        public string DegreeEducation { get; set; }

        [MaxLength(50)]
        public string Mobile { get; set; }
        public string Address { get; set; }

        public byte[] Picture { get; set; }
    }

}
