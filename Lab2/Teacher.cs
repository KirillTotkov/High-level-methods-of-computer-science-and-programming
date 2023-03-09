namespace Lab2
{
    public class Teacher
    {
        public string FullName { get; set; }
        public string AcademicDegree { get; set; }
        public string ProgrammingLanguages { get; set; }
        public string DevelopmentEnvironments { get; set; }
        public string TechnologyStack { get; set; }

        public Teacher(string fullName, string academicDegree, string programmingLanguages, string developmentEnvironments, string technologyStack)
        {
            FullName = fullName;
            AcademicDegree = academicDegree;
            ProgrammingLanguages = programmingLanguages;
            DevelopmentEnvironments = developmentEnvironments;
            TechnologyStack = technologyStack;
        }

    }
}
