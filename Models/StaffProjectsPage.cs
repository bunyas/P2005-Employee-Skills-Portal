using System.ComponentModel.DataAnnotations;

namespace P2005_Employee_Skills_Portal.Models
{
    public class StaffProjectsPage
    {
        [Key]
        public int ProjectsId { get; set; }
        public string ProjectTitle { get; set; }
        public string Location { get; set; }
        public string LevelofResponsibility { get; set; }
        public string Description { get; set; }
    }
}
