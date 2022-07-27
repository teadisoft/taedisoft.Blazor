using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using taedisoft.BlazorServer.Models;
using taedisoft.BlazorServer.Utils;

namespace taedisoft.BlazorServer.Pages.List
{
    public partial class SearchList : ComponentBase
    {
        //public IEnumerable<ProjectModel> Projects { get; set; } = Enumerable.Empty<ProjectModel>();
        public IEnumerable<ProjectModel>? Projects { get; set; }
        private ProjectModel pm = new ProjectModel();

        public string PROJECT_JSON { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            //pm = new ProjectModel();
            await Task.Run(JsonSerialize);
        }

        /// <summary>
        /// Serialize (직렬화)
        /// </summary>
        public void JsonSerialize()
        {
            //List<ProjectModel> pmList = new()
            //{
            //    new ProjectModel() { Sabun=1, Name="홍길동", DepartMent="개발팀", Email="gildong@taedisoft.com", Gender =Gender.Male, PhotoPath="111" }
            //   ,new ProjectModel() { Sabun=2, Name="이순신", DepartMent="총괄팀", Email="sunsin@taedisoft.com", Gender =Gender.Male, PhotoPath="222" }
            //   ,new ProjectModel() { Sabun=3, Name="김간난", DepartMent="재무팀", Email="gannan@taedisoft.com", Gender =Gender.Female, PhotoPath="333" }
            //   ,new ProjectModel() { Sabun=4, Name="우영우", DepartMent="법무팀", Email="youyoungyou@taedisoft.com", Gender =Gender.Female, PhotoPath="444" }
            //};
            pm.GetList();
            PROJECT_JSON = JsonUtil.GetJsonString<ProjectModel>(pm.ProjectList);
            //PROJECT_JSON = JsonConvert.SerializeObject(pmList);        
        }

        /// <summary>
        /// DeSerialize (역직렬화)
        /// </summary>
        public void JsonDeSerialize()
        {
            Projects = JsonUtil.GetJsonModel<ProjectModel>(PROJECT_JSON);
            //Projects = JsonConvert.DeserializeObject<List<ProjectModel>>(PROJECT_JSON);
        }
    }
}
