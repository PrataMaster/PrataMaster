using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FFUniverse.API
{
    public static class API
    {
        public static async Task<ObservableCollection<Model.SetIso>> GetSetIso()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync("http://192.168.1.2:8084/MFFWS/webresources/model.setiso");
                var ConjuntosetIso = JsonConvert.DeserializeObject<ObservableCollection<Model.SetIso>>(json);
                return ConjuntosetIso;
            }
        }
    }
}
