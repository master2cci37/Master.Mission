
using Metier.Service;
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
    public partial class FormSalarie : Form
    {
        public FormSalarie()
        {
            InitializeComponent();
        }

        private void GestionnaireCentralise(object sender, EventArgs e)
        {

        }

        private void FormSalarie_Load(object sender, EventArgs e)
        {
            var srv = new ServiceMission();
            salarieBindingSource.DataSource = srv.GetAllSalaries();
                
        }
    }
}
