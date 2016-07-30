﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace VentaPorRutaWindowsPhone.ViewModel
{
    class LoginViewModel
    {
        public async Task<string> Login(string user, string pass)
        {
            HttpClient client = new HttpClient();
            Uri dataUri = new Uri("http://localhost/WSRuta/VentasService.svc/login/" + user +"/"+ pass);
            string jsonText = await client.GetStringAsync(dataUri);
            string confirmado = JsonConvert.DeserializeObject<string>(jsonText);
            return confirmado;

        } 
    }
}
