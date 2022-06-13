using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TestAppBlazor.Clients;
using TestAppBlazor.Models;

namespace TestAppBlazor.Pages
{
    public partial class AddAndEdit
    {
        [Parameter]
        public string Id { get; set; }
        private void NavigateToIndexComponent() { NavigationManager.NavigateTo("/", true); }

        public string[] StatusAry = { "New", "In progress", "Done" };
        public string[] WeightAry = { "Low", "Medium", "High", "Immediate" };
        public IncidentsModel incident { get; set; } = new IncidentsModel();

        protected override async Task OnInitializedAsync()
        {
            if (Id != "0" && Id != null)
            {
                RestClient rest = new RestClient("https://incidentenmelder-test-fa.azurewebsites.net");
                incident = await rest.GetAsync<IncidentsModel>($"/api/incidents/{Id}?code=SSpKAQRVCPUwHHFVB1Sb7bzS9ZLHuicO2dlWIP6CCPCq8ikyWOK/RQ==");
            }
        }
        public async Task AddOrEditItem()
        {
            if (Id == "0" || Id == null)
            {
                IncidentsModel FormCreateSubmit = incident;
                RestClient rest = new RestClient("https://incidentenmelder-test-fa.azurewebsites.net");
                var stringContent = new StringContent(JsonConvert.SerializeObject(incident));
                var test = await rest.PostAsync<IncidentsModel>("/api/incidents?code=iN4kjNUs5ROraP1pqpHBTJU7c8W00bbfihljF47UMWqRKzTjUgtMqg==", stringContent);
                NavigateToIndexComponent();
            }
            else
            {
                IncidentsModel FormCreateSubmit = incident;
                RestClient rest = new RestClient("https://incidentenmelder-test-fa.azurewebsites.net");
                var stringContent = new StringContent(JsonConvert.SerializeObject(incident));
                var test = await rest.PutAsync<IncidentsModel>($"/api/incidents?code=yQkQaCf/EV56rQEhq2FmYostNubefVHcUi69HHqD/GJIzmiocSiOHg==", stringContent);
                NavigateToIndexComponent();
            }
        }
    }
}
