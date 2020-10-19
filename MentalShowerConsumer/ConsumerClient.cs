using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SensorLibrary;

namespace MentalShowerConsumer
{
    public class ConsumerClient
    {
        public static void Start()
        {
        }
        public async Task<IList<Sensor>> GetAllItemsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(URI);
                IList<Sensor> cList =
                    JsonConvert.DeserializeObject<IList<Sensor>>(content);
                return cList;
            }
        }
    }
}
