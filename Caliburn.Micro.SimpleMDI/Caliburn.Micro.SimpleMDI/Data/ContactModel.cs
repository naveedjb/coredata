using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.SimpleMDI.Data
{
    [Serializable()]
    class ContactModel : IContactModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
