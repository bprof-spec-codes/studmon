using Microsoft.AspNetCore.Mvc;
using studmonBackend.Data.Models;
using studmonBackend.Logic.Interfaces;

namespace studmonBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeremAPI : ControllerBase
    {
        ITeremLogic logic { get; set; }

        public TeremAPI(ITeremLogic logic)
        {
            this.logic = logic;
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
        public void Post([FromBody] Terem h)
        {
            logic.Create(h);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            logic.Delete(id);
        }

        [HttpPut]
        public void Put([FromBody] Terem h)
        {
            logic.Update(h);
        }
    }
}
