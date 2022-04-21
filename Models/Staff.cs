using System.ComponentModel.DataAnnotations;

namespace AuthTest.Models
{
    public class Staff
    {
        public int Id { get; set; } 
        [Display(Name="Tên của nhân viên")]
        public string Name { get; set; }
        public int StaffId { get; set; }
        public string Department { get; set; }
        public DateTime CreatedDate { get; set; }
        

        //
        // public ICollection<Enrollment>? Enrollments { get; set; }
    }
}