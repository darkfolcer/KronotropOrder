using FluentAssertions;
using KronotropOrder.Products.Models;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace KronotropOrderAPI.Tests
{
    public class OrderApiTests
    {
        [Fact]
        public async Task Test_Get_OrderList()
        {
            /*
             * API'yi test etmek için TestClientProvider class'ı ekledim,
             * ve buradan gelen client ile testleri yapıyorum.
             * StatusCode'lar için ise FluentAssetions NuGet paketini kullandım.
             */
            using (var client = new TestClientProvider().Client)
            { 
                var response = await client.GetAsync("/api/orders/list");
                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }   

        }

        [Fact]
        public async Task Test_NewOrderItem_WithoutAddition()
        {

            using (var client = new TestClientProvider().Client)
            {
                //testing only with 1 beverage
                var response = await client.GetAsync("/api/orders/add?beverageId=1");
                response.EnsureSuccessStatusCode();
                var stringResponse = await response.Content.ReadAsStringAsync();
                var terms = JsonConvert.DeserializeObject<OrderList>(stringResponse);
                var returnedItems = terms.items;
                Assert.Single(returnedItems);
                Assert.Contains(returnedItems, x => x.addition.Count == 0);
                Assert.Contains(returnedItems, x => x.beverage != null);

            }

        }
        [Fact]
        public async Task Test_NewOrderItem_WithAddition()
        {
            using (var client = new TestClientProvider().Client)
            {
                //1 beverage 1 milk addition
                var response = await client.GetAsync("/api/orders/add?beverageId=1&additionIds=1");
                response.EnsureSuccessStatusCode();
                var stringResponse = await response.Content.ReadAsStringAsync();
                var terms = JsonConvert.DeserializeObject<OrderList>(stringResponse);
                var returnedItems = terms.items;
                Assert.Single(returnedItems);
                Assert.Contains(returnedItems, x => x.addition.Count > 0);
                Assert.Contains(returnedItems, x => x.beverage != null);
            }

        }

        [Fact]
        public async Task Test_NewOrderItem_WithMultiAddition()
        {
            using (var client = new TestClientProvider().Client)
            {
                //1 beverage 2 milk additions
                var response = await client.GetAsync("/api/orders/add?beverageId=1&additionIds=1&additionIds=1");
                response.EnsureSuccessStatusCode();
                var stringResponse = await response.Content.ReadAsStringAsync();
                var terms = JsonConvert.DeserializeObject<OrderList>(stringResponse);
                var returnedItems = terms.items;
                Assert.Single(returnedItems);
                Assert.Contains(returnedItems, x => x.addition.Count > 1);
                Assert.Contains(returnedItems, x => x.beverage != null);

            }

        }
        [Fact]
        public async Task Test_Remove_OrderItem()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/orders/remove?id=1");
                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }

        }
    }
}
