using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Cadir
{
    public class CadirTipi
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return Type;
        }
    }
}
