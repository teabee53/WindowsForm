using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    [Serializable]
    public class Tranzactie
    {
        private static int counter { get; set; } = 10000;
        public int id { get; set; }
        public Client client { get; set; }
        public List<Produs> listaProduse { get; set; }
        public List<int> cantitateProduse { get; set; }

        public Tranzactie()
        {
            id = counter;
            counter++;
        }

        public Tranzactie(Client client, List<Produs> listaProduse, List<int> cantitateProduse)
        {
            id = counter;
            counter++;
            this.client = client;
            this.listaProduse = listaProduse;
            this.cantitateProduse = cantitateProduse;
        }

        public float sumaPreturi()
        {
            float suma = 0;
            int length = listaProduse.Count();
            for (int i = 0; i < length; i++)
            {
                suma += listaProduse[i].pret * cantitateProduse[i];
            }
            return suma;
        }

        public override string ToString()
        {
            String newline = Environment.NewLine;
            String stringy = newline + " - - - - - - - BON FISCAL - - - - - - -" + newline + newline + newline + newline;
            stringy += "Nume client: " + client.nume + newline + newline;
            int length = listaProduse.Count();
            for (int i = 0; i < length; i++)
            {
                stringy += (listaProduse[i].denumire + " x " + cantitateProduse[i]+" buc.").PadRight(33) +
                    listaProduse[i].pret * cantitateProduse[i] + newline;
            }
            stringy += newline + newline + newline + "TOTAL".PadRight(33) + sumaPreturi();
            
            return stringy;
        }
    }
}
