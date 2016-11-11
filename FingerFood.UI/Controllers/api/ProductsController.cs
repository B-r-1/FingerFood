using FingerFood.Base.UI;
using Microsoft.Practices.Unity;
using FingerFood.Domain;
using FingerFood.Domain.Entities;
using Entity = FingerFood.Domain.Entities;
using FingerFood.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FingerFood.UI.Controllers.api
{
    [AllowAnonymous]
    public class ProductsController : BaseApiController<IProductRepository , Entity.Product>
    {

        public ProductsController(IProductRepository repositor)
            : base(repositor) {
        }
       
        
        // GET api/<controller>
        [AllowAnonymous]
        public List<Product> Get()
        {
            List<Product> products = new List<Product>();
             products = this.Repository.GetAll().ToList();
        
             return products;
        }



        // GET api/<controller>/5
       [AllowAnonymous]
        public Product Get(int id)
        {
            var product = this.Repository.Get().Where(x => x.Id == id).FirstOrDefault();
            return product;
        }

        // POST api/<controller>
        
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
       
        public HttpResponseMessage Put(Product product)
        {
            //base.Repository.Save(product);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, product);
            return response;
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}