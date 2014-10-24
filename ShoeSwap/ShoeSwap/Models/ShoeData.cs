using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeSwap.Models
{
    public class ShoeData
    {
        public string ShoeColor { get; set; }
        public string ShoeType { get; set; }
        public int ShoeSize { get; set; }
        public bool Sock { get; set; }
        public string lattitude { get; set; }
        public string longitude { get; set; }
    }
}