using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TestAppBlazor.Clients;
using TestAppBlazor.Models;

namespace TestAppBlazor.Pages
{
    public partial class ShowIncident
    {
        [Parameter]
        public string Id { get; set; }
        private void NavigateToIndexComponent() { NavigationManager.NavigateTo("/", true); }
        public IncidentsModel incident { get; set; } = new IncidentsModel();

        protected override async Task OnInitializedAsync()
        {
            RestClient rest = new RestClient("https://incidentenmelder-test-fa.azurewebsites.net");
            incident = await rest.GetAsync<IncidentsModel>($"/api/incidents/{Id}?code=SSpKAQRVCPUwHHFVB1Sb7bzS9ZLHuicO2dlWIP6CCPCq8ikyWOK/RQ==");
        }
    }
}
