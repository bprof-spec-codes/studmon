using Microsoft.AspNetCore.Mvc;
using studmon.Models;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeljesitmenyAPI : ControllerBase
    {
        ITeljesitmenyLogic logic { get; set; }

        public TeljesitmenyAPI(ITeljesitmenyLogic logic)
        {
            this.logic = logic;
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
        public void Post([FromBody] Teljesitmeny h)
        {
            logic.Create(h);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            logic.Delete(id);
        }

        [HttpPut]
        public void Put([FromBody] Teljesitmeny h)
        {
            logic.Update(h);
        }
    }
}
