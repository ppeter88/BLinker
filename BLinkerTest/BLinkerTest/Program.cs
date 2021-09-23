using BLinkerTest.BLinkerAPI;
using BLinkerTest.Ninject;
using Newtonsoft.Json;
using BLinkerTest.Models;
using BLinkerTest.BLinkerAPI.Services;

namespace BLinkerTest
{
    class Program
    {
        static void Main(string[] args)
        {

            DepInj.Initialize();
            BLApi baseLinkerApi = DepInj.Create<BLApi>();
            int orderId = 11005687;        // Id zamówienia, które będziemy pobierać
            string productId = "20159499"; // Id produktu (GRATIS), który będziemy dodawać

            //Pobranie zamówienia 
            string resultGetOrder = GetOrder(baseLinkerApi, orderId);

            //Pobranie danych produktu jaki dodamy do zamówienia
            var product = GetProduct(baseLinkerApi, productId);

            //Utworzenie zamówienia z bonusem
            var orderWithBonus = CreateOrderWithBonus(orderId, resultGetOrder, product);

            //Wysyłka zamówienia
            string resultSendOrder = SendOrder(baseLinkerApi, orderWithBonus);

        }

        private static string GetOrder(BLApi baseLinkerApi, int orderId)
        {
            string parameters = JsonConvert.SerializeObject(new GetOrderDto { order_id = orderId });
            var connector = new BLConnector("getOrders", parameters);

            string result = baseLinkerApi.SendRequest(connector);
            return result;
        }
        private static Product GetProduct(BLApi baseLinkerApi, string productId)
        {
            string parameters = JsonConvert.SerializeObject(new GetProductsDto("bl_1", productId));
            var connector = new BLConnector("getProductsList", parameters);
            string result = baseLinkerApi.SendRequest(connector);

            var getProductResponse = JsonConvert.DeserializeObject<GetProductsListResponse>(result);
            Product productobj = getProductResponse.GetObject(productId);

            return productobj;
        }
        private static CreateOrderDto CreateOrderWithBonus(int orderId, string result, Product additionalProduct)
        {
            var getOrdersResponse = JsonConvert.DeserializeObject<GetOrdersResponse>(result);
            Order order = getOrdersResponse.GetObject(orderId);
            var bonusesService = DepInj.Create<BonusesService>();

            CreateOrderDto orderWithBonus = bonusesService.CreateOrderWithBonus(order, additionalProduct);

            return orderWithBonus;
        }
        private static string SendOrder(BLApi baseLinkerApi, CreateOrderDto orderWithBonus)
        {
            string parameters = JsonConvert.SerializeObject(orderWithBonus);
            var connector = new BLConnector("addOrder", parameters);
            string result = baseLinkerApi.SendRequest(connector);
            return result;
        }
    }
}
