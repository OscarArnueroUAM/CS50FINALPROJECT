using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using OctagonHelpdesk.Services;


namespace OctagonHelpdesk.Models
{
    public class UserModel
    {
        // Nota: si esta en ingles ignoralo
        // SI ESTA EN ESPAÑOL LEELO
        public int IDEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int DeptID { get; set; }
        public Roles Roles;

        private string EncryptedPassword;
       
        // Implementar UserRoles -M

        public UserModel()
        {
            Roles = new Roles();

            //Mario: Logica basica es asi: en cuanto se crea el objeto y se le asignan las propiedades de un usuario existente
            // se busca entre donde esten almacenados los roles y se le asigna
            // la creacion de usuario va en otro lugar, en esta clase se trabaja con la asumcion de que el usuario ya existe
            UserRolesService userRolesService = new UserRolesService();
            userRolesService.RetrieveRoles(this);
            // Mario: To do, Find a way to dispose of the UserRolesServices after it's used so it doesn't hog memory

        }

        public void SetPassword(string password, bool loggedin)
        {
            if (loggedin)
            {
                EncryptedPassword = HelperPassword.HashPassword(password);
            }
 
        }

        public bool ChecKPassword(string password)
        {
            //To do, Code a way Retrieve Hashed password from wherever we store it in and compare it -M
            return HelperPassword.VerifyPassword(password, EncryptedPassword);
        }

        





    }
}
