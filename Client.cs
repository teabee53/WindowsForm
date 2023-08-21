using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    [Serializable]
    public class Client
    {
        private static int counter = 0;
        public int id { get; }
        public string nume { get; set; }
        public string cnp { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public Client() 
        {
            id = counter;
            counter++;
        }

        public Client(string nume, string cnp, string telefon, string email)
        {
            id = counter;
            counter++;
            this.nume = nume;
            this.cnp = cnp;
            this.telefon = telefon;
            this.email = email;
        }
    }
}
