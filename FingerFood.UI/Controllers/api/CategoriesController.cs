using FingerFood.DataAccess;
using FingerFood.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FingerFood.UI.Controllers.api
{
    public class CategoriesController : ApiController
    {
        // GET: api/Categories
        GeneralDbContext db = new GeneralDbContext();
        // GET api/<controller>
        public IEnumerable<Category> Get()
        {
            List<Category> categories = new List<Category>();
            foreach (var item in db.Categories)
            {
                categories.Add(item);

            }
            return categories;
        }


        // GET: api/Categories/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Categories
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categories/5
        public void Delete(int id)
        {
        }
    }
}
