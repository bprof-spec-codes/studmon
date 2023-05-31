using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json.Linq;
using studmonBackend.Data.Models;
using studmonBackend.Data.Models.ManyToManyModels;
using studmonBackend.Logic;
using studmonBackend.Logic.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace studmonBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OMToHMAPI : ControllerBase
    {
        IOraManyToHallgatoMany logic { get; set; }
        ITeljesitmenyLogic teljesitmenyLogic { get; set; }

        IHallgatoLogic hallgatoLogic { get; set; }

        IOraLogic oraLogic { get; set; }

        IHubContext<EventHub> hub;

        public OMToHMAPI(IOraManyToHallgatoMany logic, IHallgatoLogic hallgatoLogic , ITeljesitmenyLogic teljesitmenyLogic, IOraLogic oraLogic, IHubContext<EventHub> hub)
        {
            this.logic = logic;
            this.teljesitmenyLogic = teljesitmenyLogic;
            this.hallgatoLogic = hallgatoLogic;
            this.oraLogic = oraLogic;
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
            var hallgato = hallgatoLogic.Readone(value.HallgatoId);
            var ora = oraLogic.Readone(value.OraId);
            
            for (int i = 1; i <= ora.alkalmakSzama; i++)
            {
                Teljesitmeny teljesitmeny = new Teljesitmeny();
                teljesitmeny.oraId = value.OraId;
                teljesitmeny.hallgatoNeptunKod = value.HallgatoId;
                teljesitmeny.WeekNumber = i;
                teljesitmenyLogic.Create(teljesitmeny);
            }
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
            var OMToHM = logic.ReadOne(id);
            var hallgato = hallgatoLogic.Readone(OMToHM.HallgatoId);

            foreach (var item in hallgato.teljesitmeny)
            {
                if (item.hallgatoNeptunKod == hallgato.neptunKod && item.oraId == OMToHM.OraId)
                {
                    teljesitmenyLogic.Delete(item.teljesitmenyID.ToString());
                }
            }

            logic.Delete(id);

            await hub.Clients.All.SendAsync("OMToHM_Deleted", id);
        }
    }
}
