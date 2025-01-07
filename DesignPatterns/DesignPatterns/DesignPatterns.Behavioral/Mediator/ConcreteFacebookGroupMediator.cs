using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteFacebookGroupMediator : FacebookGroupMediator
    {
        private List<User> userList = new List<User>();

        public void RegisterUser(User user)
        {
            userList.Add(user); 
        }

        public void SendMessage(string msg, User user)
        {
            foreach (var item in userList)
            {
                if (item != user)
                {
                    item.Receive(msg);
                }
            }
        }
    }
}
