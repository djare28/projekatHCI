using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Projekat.klase
{
    class TipModel
    {
        private string Oznaka { get; set; }
        private string Naziv { get; set; }
        private string Opis { get; set; }
        private BitmapImage Slika { get; set; }
        private bool PostojiResursSaOvimTipom { get; set; }

        public TipModel()
        {
            this.PostojiResursSaOvimTipom = false;
        }
    }

}
