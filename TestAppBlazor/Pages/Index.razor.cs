using System.Threading.Tasks;
using TestAppBlazor.Models;
using System.Net.Http.Json;
using System.Net.Http;
using TestAppBlazor.Clients;
using Newtonsoft.Json;


namespace TestAppBlazor.Pages
{
    public partial class Index
    {
        private IncidentsModel[] incidents;
  
        protected override async Task OnInitializedAsync()
        {
            HttpClient Http = new HttpClient();
            incidents = await Http.GetFromJsonAsync<IncidentsModel[]>("https://incidentenmelder-test-fa.azurewebsites.net/api/incidents?code=QEUlS8ZK4qfMEITWaEs8k4ScU2aHxJROSNJ4vBzFuzMPxTG/XxQ7kQ==");
        }
        private void NavigateToAddComponent() { NavigationManager.NavigateTo("/add-incident"); }
        private void NavigateToEditComponent(int Id) { 
            NavigationManager.NavigateTo($"/add-incident/{Id}"); 
        }

        private async Task Delete(int Id)
        {
            RestClient rest = new RestClient("https://incidentenmelder-test-fa.azurewebsites.net");
            incidents = await rest.DeleteAsync<IncidentsModel[]>($"/api/incidents/{Id}?code=Fgk9CfT4C2JM4oGhZiwds/r07kV/SmKJxXPw32gHzyFilWXsN/0aPw==");
            NavigationManager.NavigateTo("/", true);
        }
    }
}
