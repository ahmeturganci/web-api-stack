using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_api_stack.Models;

namespace web_api_stack.BL
{
    public class UtilsController : ApiController
    {
        ProductModel db = new ProductModel();

        [HttpGet]
        [Route("TestMethodInUtils")]
        public string TestMethodInUtils()
        {
            return "Test method return value";
        }

        // A custom delete function 
        [HttpPost]
        [Route("DeleteProduct/{id}")]
        public bool DeleteProduct(Int32 id)
        {
            var k = db.Products.Find(id);
            db.Products.Remove(k);
            int r = db.SaveChanges();
            if (r > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
