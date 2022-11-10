using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSampleProject.Stock
{
    public class PriceHistoryModel
    {
        public string Date { get; set; }
        public long Close { get; set; }
        public long Open { get; set; }
        public long High { get; set; }
        public long Low { get; set; }
        public long Volume { get; set; }

    }
}
