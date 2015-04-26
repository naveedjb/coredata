using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Caliburn.Micro.SimpleMDI.Data
{
    class AddressUtility
    {

        public static string checkName(string name){

            var flag=name!="" && name.All(Char.IsLetter);
            if (!flag)
                throw new AddressException("Name not valid");
            return name;
        }

        public static string checkPhone(string phone)
        {

            var flag =phone!="" && phone.All(Char.IsNumber);
            if (!flag)
                throw new AddressException("Phone No not valid");
            return phone;
        }

        public static string checkEmail(string email)
        {

            var flag =  Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            
            if (!flag)
                throw new AddressException("Email not valid");
            IContactModel cm = AddressBook.list.SearchFirst(email);
            if (cm != null)
                throw new AddressException("Email already used, try another");
            
            return email;
        }

        public static bool checkInput(int key)
        {
            int[] keys={35,36,37,38,39,40,45,46};
            return keys.Contains(key);

        }

    }
}