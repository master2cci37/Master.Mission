using Metier.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Service
{
    public class ServiceMission
    {
        private List<Salarie> listeSalaries;

        public Salarie GetSalarieByID(int id) {
            foreach (var item in this.listeSalaries)
            {
                if (item.Identifiant==id) return item;
            }

            return null;
        }

        public IList<Salarie> GetAllSalaries() {
            return this.listeSalaries;
        }

        public ServiceMission()
        {
            // ajouter 3 salaries à la liste
           var sal1 = new Salarie() { Identifiant = 1, Nom = "AILENEI", Prenom = "Adina"};
           var sal2 = new Salarie() { Identifiant = 2, Nom = "COULIBALY", Prenom = "Abdoulaye" };
           var sal3 = new Salarie() { Identifiant = 3, Nom = "DESDOUITS",Prenom = "Emmanuel"};
           this.listeSalaries = new List<Salarie>() { sal1,sal2,sal3};
            //ou Add() x3 this.listeSalaries.Add(sal1);

        }

        /// <summary>
        /// Sauvegarders this instance.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Sauvegarder()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Exporters this instance.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Exporter()
        {
            //throw new NotImplementedException();
        }
    }
}
