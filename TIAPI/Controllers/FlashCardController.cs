using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TIAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashCardController : ControllerBase
    {
        // GET: api/FlashCard
        [HttpGet]
        public IEnumerable<FlashCard> Get()
        {
            string fileName = "flashcards.json";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string jsonString = System.IO.File.ReadAllText(path);
            JObject o = JObject.Parse(jsonString);
            JArray a = (JArray)o["flashcards"];
            IList<FlashCard> flashCards = a.ToObject<IList<FlashCard>>();
            return flashCards;
        }

        // GET: api/FlashCard/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FlashCard
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/FlashCard/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
