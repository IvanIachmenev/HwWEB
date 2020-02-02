using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW5.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public DateTime CreationDate { get; set; }
        public TimeSpan LifeTime
        {
            get
            {
                return DateTime.Now.Subtract(CreationDate);
            }
        }
    }
}
