using System;
using System.Collections.Generic;
using System.Text;

namespace TemaClase
{
    class Masina
    {
        public Motor Motor;
        public string NumarMasina;
        public string MarcaMasina;

       public Masina(Motor motor,string numarMasina,string marcaMasina)
        {
            Motor = motor;
            NumarMasina = numarMasina;
            MarcaMasina = marcaMasina;
        }
    }
}
