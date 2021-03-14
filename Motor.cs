using System;
using System.Collections.Generic;
using System.Text;

namespace TemaClase
{
    class Motor
    {
        public int CaiPutere { get; set; }
        public int AnFabricatie { get; set; }
        public string Tip { get; set; }

        public Motor(int caiPutere, int anFabricatie, string tip)
        {
            CaiPutere = caiPutere;
            AnFabricatie = anFabricatie;
            Tip = tip;
        }

    }
}
