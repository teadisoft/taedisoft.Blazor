using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using taedisoft.BlazorServer.Models;

namespace taedisoft.BlazorServer.Pages.List
{
    public partial class SearchList : ComponentBase
    {

        public IEnumerable<ProjectModel> Projects { get; set; } = Enumerable.Empty<ProjectModel>();

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(CreateJsonFile);
        }

        public void CreateJsonFile()
        {
            List<ProjectModel> pmList = new List<ProjectModel>()
            {
                new ProjectModel() { Sabun=1, Name="홍길동", DepartMent="개발팀", Email="gildong@taedisoft.com", Gender =Gender.Male, PhotoPath="111" }
               ,new ProjectModel() { Sabun=2, Name="이순신", DepartMent="총괄팀", Email="sunsin@taedisoft.com", Gender =Gender.Male, PhotoPath="222" }
               ,new ProjectModel() { Sabun=3, Name="김간난", DepartMent="재무팀", Email="gannan@taedisoft.com", Gender =Gender.Female, PhotoPath="333" }
               ,new ProjectModel() { Sabun=4, Name="우영우", DepartMent="법무팀", Email="youyoungyou@taedisoft.com", Gender =Gender.Female, PhotoPath="444" }
            };

            string jsonString = JsonConvert.SerializeObject(pmList);


        }
    }
}
