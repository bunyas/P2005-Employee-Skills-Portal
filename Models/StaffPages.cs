namespace P2005_Employee_Skills_Portal.Models
{
    public class StaffPages
    {
        public int Id { get; set; }
        public string IndexNumber { get; set; }
        public string FullNames { get; set; }
        public string Email { get; set; }
        public string CurrentLocation { get; set; }
        public string HighestLevelOfEducation { get; set; }
        public string DutyStation { get; set; }
        public bool AvailabilityForRemoteWork { get; set; }

        public string ProjectTitle { get; set; }
        public string Location { get; set; }
        public string LevelofResponsibility { get; set; }
        public string Description { get; set; }

        public string Language { get; set; }
        public string LanguageLevelofResponsibility { get; set; }

        public string SoftwareExpertise { get; set; }
        public string SoftwareExpertiseLevel { get; set; }
        public ICollection<StaffLanguagesPage> StaffLanguagesPages { get; set; }
        public ICollection<StaffProjectsPage> StaffProjectsPages { get; set; }
        public ICollection<StaffSoftwareExpertisePage> StaffSoftwareExpertisePages { get; set; }
    }
}
