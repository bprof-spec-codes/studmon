using Microsoft.AspNetCore.Mvc;
using studmonBackend.Data.Models;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TanarAPI : ControllerBase
    {
        ITanarLogic logic { get; set; }

        public TanarAPI(ITanarLogic logic)
        {
            this.logic = logic;
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
        public void Post([FromBody] Tanar h)
        {
            logic.Create(h);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            logic.Delete(id);
        }

        [HttpPut]
        public void Put([FromBody] Tanar h)
        {
            logic.Update(h);
        }
    }
}
