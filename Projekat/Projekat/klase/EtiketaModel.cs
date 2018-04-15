using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Projekat.klase
{
    class EtiketaModel
    {
        private string Oznaka { get; set; }
        private Color Boja { get; set; }
        private string Opis { get; set; }
        private bool PostojiEtiketaSaOvimTipom { get; set; }

        public EtiketaModel()
        {
            this.PostojiEtiketaSaOvimTipom = false;
        }
    }
}
