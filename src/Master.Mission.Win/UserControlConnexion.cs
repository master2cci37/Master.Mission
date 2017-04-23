using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master.Mission.Win
{
    public partial class UserControlConnexion : UserControl
    {
        public string Identifiant { get {
                return this.textBoxIdentifiant.Text;
            } }
        public string MotPasse    { get {
                return this.textBoxMdp.Text;
            } }

        public UserControlConnexion()
        {
            InitializeComponent();
        }
    }
}
