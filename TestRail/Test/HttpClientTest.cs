using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRail.Test
{
    public class HttpClientTest
    {
        [Test]
        public async Task SimpleHttpTest()
        {
            const string baseUrl = "https://regress.in/";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(baseUrl);
                     
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(content);
                    }

                } catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
        }
    }
}
