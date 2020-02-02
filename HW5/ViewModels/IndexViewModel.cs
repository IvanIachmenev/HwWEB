using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW5.Models;

namespace HW5.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Water> Waters { get; set; }
        public IEnumerable<BrandModel> Brands { get; set; }
    }
}
