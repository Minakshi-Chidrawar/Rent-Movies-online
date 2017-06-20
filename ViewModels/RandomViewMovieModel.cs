using System;
using Vidly.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.ViewModels
{
    public class RandomViewMovieModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}