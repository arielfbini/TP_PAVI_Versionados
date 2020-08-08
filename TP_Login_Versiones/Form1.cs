using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Login_Versiones
{
    public partial class frm_logueo : Form
    {
        public frm_logueo()
        {
            InitializeComponent();
        }

        private void frm_logueo_Load(object sender, EventArgs e)
        {
            txt_contraseña.PasswordChar = '*';
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//comentario de Fran