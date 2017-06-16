using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class RandomViewModel
    {
        public List<Movies> Movie { get; set; }
        public List<Customers> Customers;
    }
}