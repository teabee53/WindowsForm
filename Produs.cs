using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    [Serializable]
    public class Produs
    {
        private static int counter { get; set; } = 100;
        public int id { get; set; }
        public string denumire { get; set; }
        public float pret { get; set; }

        public Produs()
        {
            id = counter;
            counter++;
        }

        public Produs(string denumire, float pret)
        {
            id = counter;
            counter++;
            this.denumire = denumire;
            this.pret = pret;
        }
    }
}
