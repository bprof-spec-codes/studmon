using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using studmonBackend.Data.Models;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeremAPI : ControllerBase
    {
        ITeremLogic logic { get; set; }
        IHubContext<EventHub> hub;
        public TeremAPI(ITeremLogic logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }


        [HttpGet]
        public IEnumerable<Terem> GetAll()
        {
            return logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Terem Get(string id)
        {
            return logic.Readone(id);
        }

        [HttpPost]
        public async void Post([FromBody] Terem h)
        {
            logic.Create(h);
            await hub.Clients.All.SendAsync("teremCreated", h);

        }

        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            logic.Delete(id);
            await hub.Clients.All.SendAsync("teremDeleted", id);

        }

        [HttpPut]
        public async void Put([FromBody] Terem h)
        {
            logic.Update(h);
            await hub.Clients.All.SendAsync("teremEdited", h);

        }
    }
}
