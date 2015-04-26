using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.SimpleMDI.Data
{
    interface IContact
    {
        int AddContact(IContactModel contact);
        bool DeleteContact(string email);
        List<IContactModel> ListAll();
        bool EditContact(IContactModel add, IContactModel delete);
        List<IContactModel> SearchContact(string search);
    }
}
