﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace USDASearchApp.API.Interfaces.USDAAPI
{
    internal interface IHttpClientWrapper
    {
        Task<string> GetAsync(string uri);
        Task<string> PostAsync(string uri);
    }
}
