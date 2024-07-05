using System.ComponentModel.DataAnnotations;

namespace P2005_Employee_Skills_Portal.Models
{
    public class StaffLanguagesPage
    {
        [Key]
        public int StaffLanguagesId { get; set; }
        public string Language { get; set; }
        public string LanguageLevelofResponsibility { get; set; }
    }
}

