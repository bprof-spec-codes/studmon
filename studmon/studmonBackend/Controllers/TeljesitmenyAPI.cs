using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using studmonBackend.Data.Models;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeljesitmenyAPI : ControllerBase
    {
        ITeljesitmenyLogic logic { get; set; }
        IHubContext<EventHub> hub;
        public TeljesitmenyAPI(ITeljesitmenyLogic logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }


        [HttpGet]
        public IEnumerable<Teljesitmeny> GetAll()
        {
            return logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Teljesitmeny Get(string id)
        {
            return logic.Readone(id);
        }

        [HttpPost]
        public async void Post([FromBody] Teljesitmeny h)
        {
            logic.Create(h);
            await hub.Clients.All.SendAsync("teljesitmenyCreated", h);

        }

        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            logic.Delete(id);
            await hub.Clients.All.SendAsync("teljesitmenyDeleted", id);

        }

        [HttpPut]
        public async void Put([FromBody] Teljesitmeny h)
        {
            logic.Update(h);
            await hub.Clients.All.SendAsync("teljesitmenyEdited", h);

        }
    }
}
