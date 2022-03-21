using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Core.Model
{
    public class Investor
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string ProfilePic { get; set; }
        public decimal? Total_Investment { get; set; }
        public string Gender { get; set; }
    }
}
