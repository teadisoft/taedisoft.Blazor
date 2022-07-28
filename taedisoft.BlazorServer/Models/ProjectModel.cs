namespace taedisoft.BlazorServer.Models
{
    public class ProjectModel
    {

        public int Sabun { get; set; }
        public string? Name { get; set; }
        public string? DepartMent { get; set; }
        public string? Email { get; set; }
        public Gender Gender { get; set; }
        public string? PhotoPath { get; set; }

        public IEnumerable<ProjectModel>? ProjectList { get; set; }

        public void GetList()
        {
            if (ProjectList == null)
            {
                IEnumerable<ProjectModel> pmList = new List<ProjectModel>()
                {
                    new() { Sabun=1, Name="홍길동", DepartMent="개발팀", Email="gildong@taedisoft.com", Gender =Gender.Male, PhotoPath="111" }
                   ,new() { Sabun=2, Name="이순신", DepartMent="총괄팀", Email="sunsin@taedisoft.com", Gender =Gender.Male, PhotoPath="222" }
                   ,new() { Sabun=3, Name="김간난", DepartMent="재무팀", Email="gannan@taedisoft.com", Gender =Gender.Female, PhotoPath="333" }
                   ,new() { Sabun=4, Name="우영우", DepartMent="법무팀", Email="youyoungyou@taedisoft.com", Gender =Gender.Female, PhotoPath="444" }
                };

                ProjectList = pmList;
            }

        }
    }
}
