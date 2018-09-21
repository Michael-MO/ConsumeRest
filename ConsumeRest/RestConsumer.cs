using ModelLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ConsumeRest
{
    public class RestConsumer
    {
        private const string URI = "https://jsonplaceholder.typicode.com/todos";

        public RestConsumer() { }

        public void Start()
        {
            var restDatas = GetAll();
            
            foreach (RestData data in restDatas)
            {
                Console.WriteLine(data);
            }
        }

        private IList<RestData> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = client.GetStringAsync(URI).Result;
                IList<RestData> cList = JsonConvert.DeserializeObject<IList<RestData>>(content);
                return cList;
            }
        }

        private RestData GetOne(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string content = client.GetStringAsync(URI).Result;
                RestData obj = JsonConvert.DeserializeObject<RestData>(content);
                return obj;
            }
        }
    }
}