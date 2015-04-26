using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.SimpleMDI.Data
{
   public interface IContactModel
    {
         string Name { get; set; }
        string Email { get; set; }

         string Phone { get; set; }
    }
}
