using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using studmonBackend.Data.Models;
using studmonBackend.Logic.Interfaces;
using System;

namespace studmonBackend.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class HallgatoAPI : ControllerBase
    {
        IHallgatoLogic logic { get; set; }
        IHubContext<EventHub> hub;

        public HallgatoAPI(IHallgatoLogic logic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
        }


        [HttpGet]
        //[Authorize]
        public IEnumerable<Hallgato> GetAll()
        {
            return logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Hallgato Get(string id)
        {
            return logic.Readone(id);
        }

        [HttpPost]
        public async void Post([FromBody] Hallgato h)
        {
            logic.Create(h);
            await hub.Clients.All.SendAsync("hallgatoCreated",h);
        }

        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            logic.Delete(id);
            await hub.Clients.All.SendAsync("hallgatoDeleted", id);
        }

        [HttpPut]
        public async void Put([FromBody] Hallgato h)
        {
            logic.Update(h);
            await hub.Clients.All.SendAsync("hallgatoEdited", h);
        }


    }


}
