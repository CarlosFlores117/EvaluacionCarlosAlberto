using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domai;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAc_Click(object sender, EventArgs e)
        {
            var userModel = new UserModel(userId:0, Nombre: txtNombre.Text, Paterno: txtPaterno.Text, Materno: txtPaterno.Text, Login: txtLogin.Text, Sueldo:"",Fecha_Ingreso:"");
            var result = userModel.UserEditProfile();
            MessageBox.Show(result);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var userModel = new UserModel(userId: 0, Nombre: txtNombre.Text, Paterno: txtPaterno.Text, Materno: txtMaterno.Text, Login: txtLogin.Text, Fecha_Ingreso:fecha.Text, Sueldo:"5000");
            var result = userModel.AdddProfile();
            MessageBox.Show(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fecha.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
