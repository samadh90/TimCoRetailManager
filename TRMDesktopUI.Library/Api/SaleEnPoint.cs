using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TRMDesktopUI.Library.Models;

namespace TRMDesktopUI.Library.Api
{
    public class SaleEnPoint : ISaleEnPoint
    {
        private IAPIHelper _apiHelper;

        public SaleEnPoint(IAPIHelper aPIHelper)
        {
            _apiHelper = aPIHelper;
        }

        public async Task PostSale(SaleModel sale)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Sale", sale))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Log successful call?
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
