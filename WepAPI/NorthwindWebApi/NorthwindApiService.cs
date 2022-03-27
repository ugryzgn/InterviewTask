using Core.Entities;
using Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WepAPI.NorthwindWebApi
{
    public class NorthwindApiService
    {
        private readonly HttpClient httpClient;
        public NorthwindApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<T>> GetEntities<T>() where T : class, IEntity, new()
        {
            T entity = new T();
            IEnumerable<T> ts;
            var result = await httpClient.GetAsync($"{entity}");
            if (result.IsSuccessStatusCode)
            {
                ts = JsonConvert.DeserializeObject<IEnumerable<T>>(await result.Content.ReadAsStringAsync());
            }
            else
            {
                ts = null;
            }
            return ts;
        }

      

    }
}
