using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OctagonHelpdesk.Models;

namespace OctagonHelpdesk.Services
{
    internal class UsuarioService
    {
        private List<UserModel> Usuarios = new List<UserModel>();

        public void AddUsuario(UserModel usuario)
        {
            Usuarios.Add(usuario);
        }
        public void RemoveUsuario(UserModel usuario)
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
            return Usuarios.FindIndex(x => x.IDUser == id);

        }

    }
}
