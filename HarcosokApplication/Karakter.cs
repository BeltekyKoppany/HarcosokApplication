using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosokApplication
{
    class Hasznalo
    {
        int id;
        int nev;

        public Hasznalo(int id, int nev)
        {
            this.id = id;
            this.nev = nev;
        }

        public int Id { get => id;}
        public int Nev { get => nev;}
    }
}
