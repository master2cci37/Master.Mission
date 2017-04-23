using Metier.Modele;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Mission
{

    // enumeration
    public enum Jours { Lundi, Mardi };

    class Program
    {
        public const string Version = "1.0";

        static void Main(string[] args)
        {
            // type valeurs
            int i = 0;
            decimal montant = 0.00m;
            double montantD = 0.00d;
            bool estIdentifie = true;
            char c = 'M';
            DateTime dtEntree = DateTime.Now;

            // tableau
            string[] ts = new string[3]
            {
                "un",
                "deux",
                "un"
            };
            #region TryCatch

            // try catch
            try
            {
                int a = 0, b = 0;
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("sos :" + ex.Message);
            }
            #endregion

            // instancier un objet
            Salarie bob = new Salarie() { Identifiant = 1 };

            Personne x = bob;
            Personne y = new Personne();
            y = (Personne)bob;

            // inference de type
            var jimmy = "blues";

            #region interface IDisposable => structure using
            Debug.WriteLine("Ecriture fichier");
            using (var fw = new StreamWriter("index.html"))
            {
                fw.Write("<h1>Hello Bob</h1>");
            }
            Debug.WriteLine("Lecture fichier");
            using (var fr = new StreamReader("index.html"))
            {
                var ct = fr.ReadToEnd();
                Console.WriteLine(ct);
            }
            #endregion

            // formatage des chaines
            var dtAujourdhui = DateTime.Now;
            var entier = 10;
            var reel = 3.1415927;
            var etudiant = new {Nom="FOURNIER",Prenom="Pierre" };

            Console.WriteLine(
                string.Format("Mon nom est {0} {1} !!",
                etudiant.Nom,etudiant.Prenom));
            //c# 6 - vs 2015 
            Console.WriteLine(
                $"Mon nom est {etudiant.Nom} {etudiant.Prenom} !!");

            Console.WriteLine(string.Format("Entier : {0:00}",entier));
            Console.WriteLine(string.Format("Reel : {0:0.00}",reel));

            Console.WriteLine(
                string.Format("Nous sommes le {0:dd MM yyyy}, {1}",
                dtAujourdhui, dtAujourdhui.DayOfWeek));

            // fonctions chaines
            var estNum = "A123SDFGHJ678".Contains("123");//=> true
            var chaine = "MASTER CCI";
            var leetspeak = chaine.Replace("A", "4")
                .Replace("S", "5")
                .Replace("E", "3")
                .Replace("I", "1");//=> M45T3R CC1
            Console.WriteLine(leetspeak);

            // conversion de type
            var ik = int.Parse("12345");
            var sik = 10.ToString("00");
            var siksik = Convert.ToString(10);
            


            





































            Console.WriteLine(Jours.Lundi);
            Console.WriteLine((int)Jours.Lundi);










            Console.WriteLine("Bonjour Master 2017 !!!");
            Console.ReadLine();
        }
    }
}
