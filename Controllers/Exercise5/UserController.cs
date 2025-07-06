using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.MVC;
using Views;

namespace Controllers
{
    public class UserController
    {
        public User LoadUser() => UserView.CreateUser();
        public void ShowUser(User user) => UserView.ShowUser(user);
    }
}
