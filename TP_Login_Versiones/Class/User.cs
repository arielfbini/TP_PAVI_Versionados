using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Login_Versiones.Class
{
    class User
    {
        private string usuario;
        private string contraseña;

        public User(string usuario, string contraseña)
        {
            this.Usuario = usuario;
            this.Contraseña = contraseña;
        }

        public string Usuario {
            get => usuario;
            set => usuario = value;
        }

        public string Contraseña {
            get => contraseña;
            set => contraseña = value;
        }
    }
}
