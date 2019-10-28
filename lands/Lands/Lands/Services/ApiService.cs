
namespace Lands.Services
{
    using Models;
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Plugin.Connectivity;
    using System.Threading.Tasks;

    public class ApiService
    {
        public async Task<Response> CheckConnection()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Por favor conéctese al internet",
                };
            }
        }

    }
}
