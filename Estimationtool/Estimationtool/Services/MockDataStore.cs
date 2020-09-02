using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Estimationtool.Helper;
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
                new Product{Id = "1", WBSElement = "First product" , Description = "This is an product description.", ProductNo = "1234",Project = "CasterCSP",
                ItemDescription = "This is an product description." , MatrialNo = "54321", Size = "567" , Specification = "1234567" , QtyReq = "2",NetOrderPrice = "500000078905.879",
                UnitofMeasurment = "768" , UnitWt = "2345" , WeightUnit = "Kg", PurchasingDocument = "abcdfeg" , Item = "ytrgfy", PurchaseOrderNo = "456789",
                UnitRatePrice = "KG" , Currency = "RS", SupplierName = "ABB LTD.", Destination = "TATA STEEL"},

                 new Product{Id = "2", WBSElement = "Second product" , Description = "This is an product description.", ProductNo = "1234",Project = "CasterCSP",
                ItemDescription = "This is an product description." , MatrialNo = "54321", Size = "567" , Specification = "1234567" , QtyReq = "2",NetOrderPrice = "500000078905.879",
                UnitofMeasurment = "768" , UnitWt = "2345" , WeightUnit = "Kg", PurchasingDocument = "abcdfeg" , Item = "ytrgfy", PurchaseOrderNo = "456789",
                UnitRatePrice = "KG" , Currency = "RS", SupplierName = "ABB LTD.", Destination = "TATA STEEL"},

                new Product{Id = "3", WBSElement = "Third product" , Description = "This is an product description.", ProductNo = "1234",Project = "CasterCSP",
                ItemDescription = "This is an product description." , MatrialNo = "54321", Size = "567" , Specification = "1234567" , QtyReq = "2",NetOrderPrice = "500000078905.879",
                UnitofMeasurment = "768" , UnitWt = "2345" , WeightUnit = "Kg", PurchasingDocument = "abcdfeg" , Item = "ytrgfy", PurchaseOrderNo = "456789",
                UnitRatePrice = "KG" , Currency = "RS", SupplierName = "ABB LTD.", Destination = "TATA STEEL"},

                new Product{Id = "4", WBSElement = "Forth product" , Description = "This is an product description.", ProductNo = "1234",Project = "CasterCSP",
                ItemDescription = "This is an product description." , MatrialNo = "54321", Size = "567" , Specification = "1234567" , QtyReq = "2",NetOrderPrice = "500000078905.879",
                UnitofMeasurment = "768" , UnitWt = "2345" , WeightUnit = "Kg", PurchasingDocument = "abcdfeg" , Item = "ytrgfy", PurchaseOrderNo = "456789",
                UnitRatePrice = "KG" , Currency = "RS", SupplierName = "ABB LTD.", Destination = "TATA STEEL"},

                new Product{Id = "5", WBSElement = "Five product" , Description = "This is an product description.", ProductNo = "1234",Project = "CasterCSP",
                ItemDescription = "This is an product description." , MatrialNo = "54321", Size = "567" , Specification = "1234567" , QtyReq = "2",NetOrderPrice = "500000078905.879",
                UnitofMeasurment = "768" , UnitWt = "2345" , WeightUnit = "Kg", PurchasingDocument = "abcdfeg" , Item = "ytrgfy", PurchaseOrderNo = "456789",
                UnitRatePrice = "KG" , Currency = "RS", SupplierName = "ABB LTD.", Destination = "TATA STEEL"},



            };

            foreach (var product in mockproducts)
            {
                products.Add(product);
            }
        }

        public  List<string> AddItemAsync(string propertyname)
        {
            var list = new List<string>();
            foreach (var item in products)
            {
                var value = ReflectionExtensions.getPropertyValue(item, propertyname);


                list.Add(value);
            }


            return list;
        }


        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {

            var oldproduct = products.Where((Product arg) => arg.Id == id).FirstOrDefault();
            products.Remove(oldproduct);

            return await Task.FromResult(true);

        }

        public async Task<List<Product>> GetListOfItemAsync(string searchitem, string searchvalue)
        {

            var searchitems = new List<Product>();

          
            if (searchitem == "WBSElement")
            {
                searchitems.Clear();

                foreach (var item in products)
                {
                    if (item.WBSElement == searchvalue)
                        searchitems.Add(item);
                }
            }

            if (searchitem == "ProductNo")
            {
                searchitems.Clear();

                foreach (var item in products)
                {
                    if (item.ProductNo == searchvalue)
                        searchitems.Add(item);
                }
            }


            if (searchitem == "MatrialNo")
            {
                searchitems.Clear();

                foreach (var item in products)
                {
                    if (item.MatrialNo == searchvalue)
                        searchitems.Add(item);
                }
            }


            if (searchitem == "Specification")
            {
                searchitems.Clear();


                foreach (var item in products)
                {
                    if (item.Specification == searchvalue)
                        searchitems.Add(item);
                }
            }

            if (searchitem =="All")
            {
                searchitems.Clear();


                foreach (var item in products)
                {
                    searchitems.Add(item);
                   
                }
            }




            return await Task.FromResult(searchitems);


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