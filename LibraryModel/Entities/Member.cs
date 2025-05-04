using LibraryData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel.Entities
{
    //Member
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        [MaxLength(50)]
        [Required(AllowEmptyStrings = false)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        public int MemberNum { get; set; }
        public bool GenderID { get; set; }

        [MaxLength(10)]
        public string? NationalCode { get; set; }

        [MaxLength(10)]
        public string? DateOfBirth { get; set; }

        [MaxLength(10)]
        public string? FirstDate { get; set; }
        [MaxLength(10)]

        public string? CurrentDate { get; set; }

        [MaxLength(50)]
        public string? DegreeEducation { get; set; }

        [MaxLength(50)]
        public string? Mobile { get; set; }
        public string? Address { get; set; }

        [ForeignKey(nameof(ProfilePicture))]
        public Guid? ProfilePictureId { get; set; }
        public virtual ProfileImages? ProfilePicture { get; set; }
    }
}
