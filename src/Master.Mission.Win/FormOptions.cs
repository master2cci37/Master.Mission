using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master.Mission.Win
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            //.... alimenter la liste avec 
            // FR/MA/ES/AR
            var langues = new List<Langage>()
            {
                new Langage() {Pays="FR",Langue="Français" },
                new Langage() {Pays="ES",Langue="Espagnol" },
                new Langage() {Pays="AR",Langue="Arabe" },
                new Langage() {Pays="DE",Langue="Allemand" },

            };
             
            comboBoxLangue.DataSource = langues;
            comboBoxLangue.DisplayMember ="Langue";
            comboBoxLangue.ValueMember =  "Pays";

            // var lvilangues=
            // listViewLangues.Items = lvilangues;

        }

        private void comboBoxLangue_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Choix "+
            //  ((Langage)  comboBoxLangue.SelectedItem).Pays);
        }

        private void timerHeure_Tick(object sender, EventArgs e)
        {
            labelHeure.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }

    internal class Langage
    {
        public string Pays { get; set; }
        public string Langue { get; set; }
    }
}
