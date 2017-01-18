using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    interface IUser
    {
        void Insert(User user);
        string GetUser(int id);
    }
}
