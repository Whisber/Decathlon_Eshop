using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Cadir
{
    public class CadirRoot
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public List<CadirItem> Data { get; set; }
    }
}
