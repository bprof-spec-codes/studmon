using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using studmonBackend.Data.Models;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TanarAPI : ControllerBase
    {
        ITanarLogic logic { get; set; }
        IHubContext<EventHub> hub;
        public TanarAPI(ITanarLogic logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }


        [HttpGet]
        public IEnumerable<Tanar> GetAll()
        {
            return logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Tanar Get(string id)
        {
            return logic.Readone(id);
        }

        [HttpPost]
        public async void Post([FromBody] Tanar h)
        {
            logic.Create(h);
            await hub.Clients.All.SendAsync("tanarCreated", h);

        }

        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            logic.Delete(id);
            await hub.Clients.All.SendAsync("tanarDeleted", id);

        }

        [HttpPut]
        public async void Put([FromBody] Tanar h)
        {
            logic.Update(h);
            await hub.Clients.All.SendAsync("tanarEdited", h);

        }
    }
}
