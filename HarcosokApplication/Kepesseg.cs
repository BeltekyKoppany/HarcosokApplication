using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosokApplication
{
    class Kepesseg
    {
        int id;
        string nev;
        string leiras;

        public Kepesseg(int id, string nev, string leiras)
        {
            this.id = id;
            this.nev = nev;
            this.leiras = leiras;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public override string ToString()
        {
            return this.nev;
        }
    }
}
