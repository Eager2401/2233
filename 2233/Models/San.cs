using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2233.Models
{
    public class San
    {
        public int SoSan { get; set; }
        public int GiaThue1Gio { get; set; }
        public string TinhTrang { get; set; }
        public List<San> KhoiTaoSan()
        {
            List<San> dsSan = new List<San>();
            dsSan.Add(new San()
            {
                SoSan = 1,
                GiaThue1Gio = 50000,
                TinhTrang = "Trong",
            });
            dsSan.Add(new San()
            {
                SoSan = 2,
                GiaThue1Gio = 51000,
                TinhTrang = "Trong",
            });
            dsSan.Add(new San()
            {
                SoSan = 3,
                GiaThue1Gio = 52000,
                TinhTrang = "Trong",
            });
            dsSan.Add(new San()
            {
                SoSan = 4,
                GiaThue1Gio = 53000,
                TinhTrang = "Trong",
            });
            return dsSan;
        }
    }
}