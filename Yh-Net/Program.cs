using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yh_Net
{
    class Program
    {
        static void Main(string[] args)
        {
        }



    }

    public class ContentFactory
    {
        public static string GetTextMessage(string recipiant, string text)
        {
            return "{ recipient: {  id:"+recipiant+ ",message:{ text:"+ text + "}}";
        }

    }

    public class DataDto
    {
        [JsonProperty("object")]
        public string Object;
        
        public EntryDto[] entry;
    }
    public class EntryDto
    {
        public string id;

        public EventDto[] messaging;
    }

    public class EventDto
    {
        public string message;
    }

    

    public class Fb : Nancy.NancyModule
    {
        public Fb()
        {
            Post["/webhoock"] = _ => {



                return 200; };
            Get["/webhoock"] = _ => { return }
        }
    }
}
