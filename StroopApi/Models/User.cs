using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StroopApi.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
