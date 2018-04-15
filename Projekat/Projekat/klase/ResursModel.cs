using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Projekat.klase
{
    class ResursModel
    {
        private string Oznaka { get; set; }
        private string Naziv { get; set; }
        private string Opis { get; set; }
        private string Tip { get; set; }
        private double Cena { get; set; }
        private bool MogucnostEksploatacije { get; set; }
        private bool StrateskaVaznost { get; set; }
        private bool Obnovljivost { get; set; }
        private DateTime Datum { get; set; }
        private string JedinicaMere { get; set; }
        private string FrekvencijaPojavljivanja { get; set; }
        private BitmapImage Slika { get; set; }
        private List<EtiketaModel> ListaEtiketa;

        public ResursModel()
        {
            this.ListaEtiketa = new List<EtiketaModel>();
        }

        public void DodajEtiketu(EtiketaModel etiketa)
        {
            this.ListaEtiketa.Add(etiketa);
        }

        public void UkloniEtiketu(EtiketaModel etiketa)
        {
            this.ListaEtiketa.Remove(etiketa);
        }
    }
}
