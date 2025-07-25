using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.WebÖdev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static private List<Product> products = new();

        [HttpGet]
        public IEnumerable<Product> GetList()
        {
            return products;
        }

        [HttpGet("{id}")]
        public Product? GetProduct(int id)
        {
            return products.Find(x => x.Id == id);
        }

        [HttpPost]
        public void AddProduct(string name,decimal price,string category)
        {
            var item = new Product
            {
                Id = products.Count + 1,
                Name = name,
                Price = price,
                Category = category
            };

            products.Add(item);
            
        }

        [HttpPut("{id}")]
        public void UpdateProduct(int id,string name,decimal price,string category)
        {
            var i = products.Find(x => x.Id == id);
            if(i == null)
            {
                return;
            }
            
            i.Name = name;
            i.Price = price;
            i.Category = category;
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            var silinecek = products.Find(x => x.Id == id);

            if(silinecek == null)
            {
                return;
            }

            products.Remove(silinecek);
        }

    }
}
