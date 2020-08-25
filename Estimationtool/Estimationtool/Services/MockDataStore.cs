using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estimationtool.Models;

namespace Estimationtool.Services
{
    public class MockDataStore : IDataStore<Product>
    {
        List<Product> products;

        public MockDataStore()
        {
            products = new List<Product>();
            var mockproducts = new List<Product>
            {
                new Product{Id = Guid.NewGuid().ToString(), WBSElement = "First product" , Description = "This is an product description.", ProductNo = "1234",
                ItemDescription = "This is an product description." , MatrialNo = "54321", Size = "567" , Specification = "1234567" , QtyReq = "2",
                UnitofMeasurment = "768" , UnitWt = "2345" , WeightUnit = "Kg", PurchasingDocument = "abcdfeg" , Item = "ytrgfy", PurchaseOrderNo = "456789",
                UnitRatePrice = "KG" , Currency = "RS", SupplierName = "ABB LTD.", Destination = "TATA STEEL"}

               
            };

            foreach (var product in mockproducts)
            {
                products.Add(product);
            }
        }

        public async Task<bool> AddItemAsync(Product item)
        {
            products.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {

            var oldproduct = products.Where((Product arg) => arg.Id == id).FirstOrDefault();
            products.Remove(oldproduct);

            return await Task.FromResult(true);

        }

        public async Task<Product> GetItemAsync(string id)
        {
            return  await Task.FromResult(products.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Product>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(products);
        }

        public async Task<bool> UpdateItemAsync(Product product)
        {
            var oldproduct = products.Where((Product arg) => arg.Id == product.Id).FirstOrDefault();
            products.Remove(oldproduct);
            products.Add(product);
            return await Task.FromResult(true);

        }

     
    }
}