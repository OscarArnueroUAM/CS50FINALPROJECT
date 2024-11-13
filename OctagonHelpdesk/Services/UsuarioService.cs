using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OctagonHelpdesk.Models;


namespace OctagonHelpdesk.Services
{
    public class UsuarioService
    {
        private List<UserModel> Usuarios = new List<UserModel>();
        
        public UsuarioService() 
        {
            MassFillLocal();
        }

        private void MassFillLocal()
        {
            UserModel TestingUser = new UserModel();
            TestingUser.MassFill(1, true, "123");
            AddUsuario(TestingUser);
        }



        public void AddUsuario(UserModel usuario)
        {
            Usuarios.Add(usuario);
        }
        public void RemoveUsuario(UserModel LoggedUser,UserModel usuario)
        {
            int position = FindPosition(usuario.IDUser);
            Usuarios[position].ActiveStateU = false;

        }
        public void UpdateUsuario(UserModel usuario)
        {
            int position = FindPosition(usuario.IDUser);
            Usuarios[position] = usuario;
        }

        public List<UserModel> GetUsuarios()
        {
            return Usuarios;
        }

        public int AutogeneradorID()
        {
            if (Usuarios.Count == 0)
            {
                return 1;
            }
            return Usuarios.Last().IDUser + 1;
        }
        public int FindPosition(int id)
        {
            return Usuarios.FindIndex(usuario => usuario.IDUser == id);

        }


        public bool CheckUser(string UserID, string password)
        {
            int ID = 0;
            try
            {
                ID = int.Parse(UserID);
            }
            catch { }
            
            for (int i = 0; i < Usuarios.Count; i++)
            {
                if ((ID == Usuarios[i].IDUser)&&ID != 0) 
                { 
                    if (Usuarios[i].ChecKPassword(password))
                    {
                        return true;
                    }

                }
            }

            return false;
        }

    }
}
