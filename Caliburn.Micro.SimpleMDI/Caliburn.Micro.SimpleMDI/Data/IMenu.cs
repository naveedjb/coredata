using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.SimpleMDI.Data
{
    interface IMenu
    {
        void StarMenu();
        void AddItemMenu();
        void DeleteItemMenu();
        void EditItemMenu();
    }
}
