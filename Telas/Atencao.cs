using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_POO_Abril_Ian_Pereira
{
    public partial class Atencao : Form
    {
        public static Atencao instance;

        public Atencao()
        {
            InitializeComponent();

            instance = this;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
