using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using studmonBackend.Data.Models;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OraAPI : ControllerBase
    {
        IOraLogic logic { get; set; }
        IHubContext<EventHub> hub;

        public OraAPI(IOraLogic logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }


        [HttpGet]
        public IEnumerable<Ora> GetAll()
        {
            return logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Ora Get(string id)
        {
            return logic.Readone(id);
        }

        [HttpPost]
        public async void Post([FromBody] Ora h)
        {
            logic.Create(h);
            await hub.Clients.All.SendAsync("oraCreated", h);

        }

        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            logic.Delete(id);
            await hub.Clients.All.SendAsync("oraDeleted", id);

        }

        [HttpPut]
        public async void Put([FromBody] Ora h)
        {
            logic.Update(h);
            await hub.Clients.All.SendAsync("oraEdited", h);

        }
    }
}
