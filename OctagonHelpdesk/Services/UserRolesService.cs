using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OctagonHelpdesk.Models;

namespace OctagonHelpdesk.Services
{
    internal class UserRolesService 
    {
        public void AssignPerms(UserModel currentUser, UserModel targetUser,Roles assignedRoles)
        {
            // Mario: To do, Retrieve Target User from whatever we use to mass store stuff
            if (currentUser.Roles.AdminPerms)
            {
                targetUser.Roles.ITperms = assignedRoles.ITperms;
                targetUser.Roles.BasicPerms = assignedRoles.BasicPerms;
            }
        }


        public void RetrieveRoles(UserModel currentUser)
        {

            // Mario: To do, Retrieve Target User from whatever we use to mass store stuff
            Roles assignedRoles = new Roles();

            currentUser.Roles.BasicPerms = assignedRoles.BasicPerms;
            currentUser.Roles.ITperms = assignedRoles.ITperms;
           
        }

        //Mario: To Do, Enable Admins to create other admins
        private void AdminSetter(UserModel CurrentUser, Roles AssignedRole, string AdminPasskey)
        {
            string secretkey = "admin"; // Mario: To Do, DO NOT HARDCODE ADMIN PASSWORDS ON PRODUCTION VERSIONS
            if (CurrentUser.Roles.AdminPerms && AdminPasskey == secretkey)
            {
                //To do Implement Admin creation logic -Mario
            }
        }
    }
}
