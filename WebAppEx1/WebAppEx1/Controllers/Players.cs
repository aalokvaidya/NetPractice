using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppEx1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Players : ControllerBase
    {
        static List<Player> listNames = new List<Player>()
        {
        new Player{Pid=1,Pname="Sam Dicosta",Pcode=1011,Pemail="sam_rox@gmail.com"},
        new Player{Pid=2,Pname="Vijay Malliya",Pcode=1025,Pemail="kingfisher@gmail.com"},
        new Player{Pid=3,Pname="Mukesh Ambani",Pcode=1033,Pemail="rich@gmail.com"},
        };
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return listNames;
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var result = listNames.SingleOrDefault(n => n.Pid == id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = listNames.SingleOrDefault(n => n.Pid == id);
            if (result == null)
            {
                return NotFound();
            }
            else
            {

                listNames.RemoveAt(id);
                return NoContent();
            }
        }
        [HttpPost]
        public IEnumerable<Player> Post([FromBody] Player newplayer)
        {
            Player obj = new Player()
            {
                Pid = newplayer.Pid,
                Pname=newplayer.Pname,
                Pcode=newplayer.Pcode,
                Pemail=newplayer.Pemail
            };
            listNames.Add(obj);

            return listNames;

        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Player n)
        {
            var result = listNames.Find(n => n.Pid == id);
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                Player obj = new Player()
                {
                    Pid = n.Pid,
                    Pname = n.Pname,
                    Pcode = n.Pcode,
                    Pemail = n.Pemail
                };
                listNames.Add(obj);
                return Ok();
            }
        }
    }

}

