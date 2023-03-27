using Microsoft.AspNetCore.Mvc;
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

        public HallgatoAPI(IHallgatoLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
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
        public void Post([FromBody] Hallgato h)
        {
            logic.Create(h);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            logic.Delete(id);
        }

        [HttpPut]
        public void Put([FromBody] Hallgato h)
        {
            logic.Update(h);
        }


    }


}
