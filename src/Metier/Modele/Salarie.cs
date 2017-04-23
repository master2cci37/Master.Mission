using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Modele
{
    public class Salarie : Personne, IDisposable
    {
        public string Profil{ get; set; }
        public string Matricule { get; set; }
        public string DateEntree { get; set; }
        public string DateSortie { get; set; }

        public Salarie() : base()// appel ctor personne
        {
          
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }

    public class Personne
    {
        // avant 2007
        private int identifiant;

        //identifié à la création par le matricule
        public int Identifiant {
            get { return this.identifiant; }
            set { this.identifiant = value; }
        }

        public string Nom { get; set; }

        public string MotPasse { get; set; }
        
        public string Prenom { get; set; }
        public string Email { get; set; }
        }
}


 