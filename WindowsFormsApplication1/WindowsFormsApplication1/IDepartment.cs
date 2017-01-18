using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    interface IDepartment
    {
        void Insert(Department department);
        string GetDepartment(int id);
    }
}
