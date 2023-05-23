using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json.Linq;
using studmonBackend.Data.Models.ManyToManyModels;
using studmonBackend.Logic.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace studmonBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OMToHMAPI : ControllerBase
    {
        IOraManyToHallgatoMany logic { get; set; }
        IHubContext<EventHub> hub;

        public OMToHMAPI(IOraManyToHallgatoMany logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }

        
        [HttpGet]
        public IEnumerable<OraManyToHallgatoMany> GetAll()
        {
            return logic.ReadAll();
        }

        
        [HttpGet("{id}")]
        public OraManyToHallgatoMany Get(string id)
        {
            return logic.ReadOne(id);
        }

        
        [HttpPost]
        public async void Post([FromBody] OraManyToHallgatoMany value)
        {
            logic.Create(value);
            await hub.Clients.All.SendAsync("OMToHM_Created", value);
        }

        
        [HttpPut]
        public async void Put([FromBody] OraManyToHallgatoMany value)
        {
            logic.Update(value);
            await hub.Clients.All.SendAsync("OMToHM_Updated", value);
        }

        
        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            logic.Delete(id);
            await hub.Clients.All.SendAsync("OMToHM_Deleted", id);
        }
    }
}
