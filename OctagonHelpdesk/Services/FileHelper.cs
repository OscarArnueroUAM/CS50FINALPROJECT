using OctagonHelpdesk.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctagonHelpdesk.Services
{
    internal class FileHelper
    {
        public void SaveUser(List<UserModel> userLists, string rutaArchivo)
        {
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    foreach (UserModel userList in userLists)
                    {
                        escritor.Write(userList.IDUser);
                        escritor.Write(userList.ActiveStateU);
                        //Ayuda para componer esta cosa
                        escritor.Write(userList.Roles.ToString());
                        escritor.Write(userList.Roles.AdminPerms);
                        escritor.Write(userList.Roles.ITPerms);
                        escritor.Write(userList.Roles.BasicPerms);
                        escritor.Write(userList.Name);
                        escritor.Write(userList.Lastname);
                        escritor.Write(userList.Email);
                        string fechaComoCadena = userList.CreationDate.ToString("dd/MM/yyyy");
                        escritor.Write(fechaComoCadena);
                    }
                }
            }
        }

        public List<UserModel> GetUsers(string rutaArchivo)
        {
            List<UserModel> userModels = new List<UserModel>();
            if(!File.Exists(rutaArchivo)) return userModels;
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read)) 
            {
                using (BinaryReader lector = new BinaryReader(archivo)) 
                {
                    while (archivo.Position != archivo.Length)
                    {
                        UserModel userModel = new UserModel();
                        userModel.IDUser = lector.ReadInt32();
                        //Falta como leer el rol (dice la alica que leerlo como int)
                        userModel.ActiveStateU = lector.ReadBoolean();
                        userModel.Name = lector.ReadString();
                        userModel.Lastname = lector.ReadString();
                        userModel.Email = lector.ReadString();
                        //userModel.IDDept = lector.ReadInt32();   
                        string fechaComoCadena = lector.ReadString();
                        userModel.CreationDate = DateTime.ParseExact(fechaComoCadena, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        
                        userModels.Add(userModel);
                    }
                }
            }
            return userModels;
        }
    }
}
