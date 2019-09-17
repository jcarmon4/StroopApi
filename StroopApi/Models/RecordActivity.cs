using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StroopApi.Models
{
    public class RecordActivity
    {
        public long Id { get; set; }
        public long IdUser { get; set; }
        public string Stage { get; set; }
        public string Status { get; set; }
        public string Text { get; set; }
        public string Ink { get; set; }
        public string Selected { get; set; }
        public string Time { get; set; }
    }
}
