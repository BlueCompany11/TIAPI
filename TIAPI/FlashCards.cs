using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIAPI
{
    public class FlashCards
    {
        [JsonProperty("flashcards")]
        public List<FlashCard> flashCards { get; set; }
    }
}
