using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressen
{
    public class Gemeentenaam
    {
        private int gemeentenaamid;
        private string taalcodeprovincienaam;
        private string gemeentenaam;

        public int GemeenteNaamID
        {
            get { return gemeentenaamid; }
            set { gemeentenaamid = value; }
        }
        public string TaalCodeProvincieNaam
        {
            get { return taalcodeprovincienaam; }
            set { taalcodeprovincienaam = value; }
        }
        public string GemeenteNaam
        {
            get { return gemeentenaam; }
            set { gemeentenaam = value; }
        }
    }
}
