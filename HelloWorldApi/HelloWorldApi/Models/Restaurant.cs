using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldApi.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public int Rank { get; set; }

    }
}