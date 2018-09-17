using HelloWorldApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldApi.Controllers
{
    public class RestaurantController : ApiController
    {
        RestaurantRepo _repo = new RestaurantRepo();
        public IEnumerable<Restaurant> GetAll()
        {
            return _repo.GetAllRestaurant();
        }

        //[HttpGet]
        //public HttpResponseMessage RestaurantById(int id)
        //{
        //    var res = _repo.GetById(id);
        //    if (res != null)
        //        return Request.CreateResponse<Restaurant>(HttpStatusCode.OK, res);
        //    else
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Id not matched !!");
        //}

        [HttpGet]
        public IHttpActionResult RestaurantById(int id)
        {
            var res = _repo.GetById(id);
            if (res != null)
                return Ok<Restaurant>(res);
            else
                return NotFound();
        }

        //public HttpResponseMessage PostRestaurnt(Restaurant rest)
        //{
        //    _repo.AddRestaurant(rest);


        //    var response = Request.CreateResponse(HttpStatusCode.Created, rest);
        //    response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = rest.Id }));
        //    return response;

        //}
        public IHttpActionResult PostRestaurnt(Restaurant rest)
        {
            _repo.AddRestaurant(rest);

            return CreatedAtRoute<Restaurant>("DefaultApi", new { id = rest.Id }, rest);

            

        }

        [HttpPut]
        public HttpResponseMessage EditRestaurant(int id, Restaurant rest)
        {
            _repo.EditRestaurant(id, rest);
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }

       [HttpDelete]
       public HttpResponseMessage RemoveRestaurant(int id)
        {
            _repo.RemoveRestaurantById(id);
            return Request.CreateResponse(HttpStatusCode.Gone);
        }
    }
}
