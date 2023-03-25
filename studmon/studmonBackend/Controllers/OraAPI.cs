using Microsoft.AspNetCore.Mvc;
using studmon.Models;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OraAPI : ControllerBase
    {
        IOraLogic logic { get; set; }

        public OraAPI(IOraLogic logic)
        {
            this.logic = logic;
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
        public void Post([FromBody] Ora h)
        {
            logic.Create(h);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            logic.Delete(id);
        }

        [HttpPut]
        public void Put([FromBody] Ora h)
        {
            logic.Update(h);
        }
    }
}
