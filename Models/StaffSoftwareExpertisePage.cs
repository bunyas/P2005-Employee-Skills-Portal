using System.ComponentModel.DataAnnotations;

namespace P2005_Employee_Skills_Portal.Models
{
    public class StaffSoftwareExpertisePage
    {
        [Key]
        public int SoftwareExpertiseId { get; set; }
        public string SoftwareExpertise { get; set; }
        public string SoftwareExpertiseLevel { get; set; }
    }
}
