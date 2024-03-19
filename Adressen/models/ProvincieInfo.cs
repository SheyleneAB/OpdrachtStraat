using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBl.models
{
    public class ProvincieInfo
    {
        public int GemeentId { get; set; }
        public int ProvicieId { get; set; }
        public string Taal { get; set; }
        public string ProvicieNaam { get; set; }

        public ProvincieInfo(string provicieNaam)
        {
            ProvicieNaam = provicieNaam;
        }
    }
}
