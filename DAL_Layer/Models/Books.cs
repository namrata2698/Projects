using System;
using System.Collections.Generic;

namespace DAL_Layer.Models
{
    public partial class Books
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
    }
}
