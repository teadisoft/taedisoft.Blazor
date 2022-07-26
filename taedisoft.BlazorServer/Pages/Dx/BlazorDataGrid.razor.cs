using Microsoft.AspNetCore.Components;
using taedisoft.BlazorServer.Models;

namespace taedisoft.BlazorServer.Pages.Dx
{
    public partial class BlazorDataGrid : ComponentBase
    {
        public List<ProjectModel>? prjList { get; set; }

        ProjectModel pm = new ProjectModel();

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(GetData);
        }

        protected void GetData()
        {
            prjList = new List<ProjectModel>();
            pm.GetList();
            prjList = pm.ProjectList;
        }

    }
}
