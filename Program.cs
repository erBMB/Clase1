using System;

namespace TemaClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motorulMeu = new Motor(120,2014,"?");
            Masina masinaMea = new Masina(motorulMeu, "AR13DRD", "Ford");
        }
    }
}
