using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreapp.Models
{
    public class MyOptions
    {
        public string HomeTitle { get; set; }
        public string HomeKeyword { get; set; }
        public string HomeDescription { get; set; }

        public string PageSize { get; set; }


        public SubOptions SubOptions { get; set; }

    }

    public class SubOptions
    {
        public string Option1 { get; set; }
        public string Option2 { get; set; }

    }
}
