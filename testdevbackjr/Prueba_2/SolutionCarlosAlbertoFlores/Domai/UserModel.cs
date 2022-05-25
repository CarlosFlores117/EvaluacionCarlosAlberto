using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataA;


namespace Domai
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        //Atributos
        private int userId;
        private string Nombre;
        private string Paterno;
        private string Materno;
        private string Login;
        private string Sueldo;
        private string Fecha_Ingreso;
        public UserModel(int userId, string Nombre, string Paterno, string Materno, string Login, string Sueldo, string Fecha_Ingreso)
        {
            this.userId = userId;
            this.Nombre = Nombre;
            this.Paterno = Paterno;
            this.Materno = Materno;
            this.Login = Login;
            this.Sueldo = Sueldo;
            this.Fecha_Ingreso = Fecha_Ingreso;
        }
        public UserModel()
        {

        }
        public string UserEditProfile()
        {
            userDao.EditProfile(userId, Nombre, Paterno, Materno, Login);
            return "Tú perfil ha sido actualizado satisfactoriamente";
        }
        public string AdddProfile()
        {
            userDao.AddProfile(userId, Nombre, Paterno, Materno,Login, Sueldo, Fecha_Ingreso);
            return "Tú perfil ha sido agregado satisfactoriamente";
            
        }
    }
        
}
