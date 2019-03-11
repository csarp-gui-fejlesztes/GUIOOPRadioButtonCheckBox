using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIOOPRadioButtonCheckboxTeleKocsi.modell
{
    enum Uticel { DEBRECEN, BUDAPEST, GYOR};

    class TeleKocsi
    {
        static int ferohely = 4;
        private Uticel uticel;
        private bool kedvezmeny;
        private int utasokSzama;

        public TeleKocsi()
        {
            uticel = Uticel.BUDAPEST;
            kedvezmeny = false;
            utasokSzama = 0;
        }

        public TeleKocsi(Uticel uticel, bool kedvezmeny, int utasokSzama)
        {
            this.uticel = uticel;
            this.kedvezmeny = kedvezmeny;
            this.utasokSzama = utasokSzama;
        }

        public void modositUticeltBudapestre()
        { }
        public void modositUticelGyor()
        { }
        public void modositUticelDebrecen()
        { }
        public void valtoztatKedvezmenyt()
        { }
        public void modositUtasokSzama(int utasokSzama)
        { }
        public int szamolAr()
        { return 0;}
    }
}
