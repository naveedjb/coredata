using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.SimpleMDI.Data
{
    public class AddressUpdateEventArgs : EventArgs
    {

        public AddressUpdateEventArgs(List<IContactModel> newList)
        {
            this.list = newList;


        }

        public List<IContactModel>  list { get; set; }
    }
}
