using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductAPI.Controllers
{
    public class ProductController : ApiController
    {
        CompanyProductsDataContext db = new CompanyProductsDataContext();
        // GET: api/Product
        public IEnumerable<CompanyProduct> Get()
        {
            var allProducts = db.CompanyProducts.ToList();

            return allProducts;
        }

        // GET: api/Product/5
        [HttpGet]
        public CompanyProduct GetProductDetails(int id)
        {
            var product = db.CompanyProducts.Where(p => p.Product_Id == id).SingleOrDefault();
            return product;
        }

        // POST: api/Product
        [HttpPost]
        public void Post(CompanyProduct product)
        {       
                db.CompanyProducts.InsertOnSubmit(product);

                db.SubmitChanges();         
        }

        // PUT: api/Product/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Product/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
