using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Cadir
{
    public class CadirItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
        public int CadirBrandId { get; set; }
        public string CadirBrand { get; set; }
        public int CadirTypeId { get; set; }
        public string CadirType { get; set; }
    }
}
