using FluentAssertions;
using KronotropOrder.Products.Models;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace KronotropOrderAPI.Tests
{
    public class MenuApiTests
    {
        [Fact]
        public async Task Test_Get_Menu()
        {
            /*
             * API'yi test etmek için TestClientProvider class'ı ekledim,
             * ve buradan gelen client ile testleri yapıyorum.
             */
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/menu/get");
                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }

        }


        [Fact]
        public async Task Test_AddNewBeverage_ToMenu()
        {

            using (var client = new TestClientProvider().Client)
            {
                /*we have 4 items default, we are adding one more item to menu.
                 * We expect to have returned 5 items in total.
                 */
                var response = await client.GetAsync("/api/menu/add/beverage?_Id=5&_Name=Filter Coffee");
                response.EnsureSuccessStatusCode();
                var stringResponse = await response.Content.ReadAsStringAsync();
                var terms = JsonConvert.DeserializeObject<Menu>(stringResponse);
                Assert.True(terms.Beverages.Count > 4);

            }

        }

        [Fact]
        public async Task Test_AddNewAddition_ToMenu()
        {

            using (var client = new TestClientProvider().Client)
            {
                /*we have 3 items default, we are adding one more item to menu.
                 * We expect to have returned 4 items in total.
                 */
                var response = await client.GetAsync("/api/menu/add/addition?_Id=4&_Name=Sugar");
                response.EnsureSuccessStatusCode();
                var stringResponse = await response.Content.ReadAsStringAsync();
                var terms = JsonConvert.DeserializeObject<Menu>(stringResponse);
                Assert.True(terms.Additions.Count > 3);

            }

        }
    }
}
