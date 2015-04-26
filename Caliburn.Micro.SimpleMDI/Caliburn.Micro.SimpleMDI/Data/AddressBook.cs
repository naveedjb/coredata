using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Caliburn.Micro.SimpleMDI.Data
{
   public partial class AddressBook
    {
       
        public static ContactList list = new ContactList();
    
        
        public static void AddItemMenu(IContactModel model)
        {
            list.AddContact(model);

           
         //   AddessBook.dataGridView1.Update();

        }
        public static bool DeleteItemMenu(string email)
        {
            

            bool flag = list.DeleteContact(email);

            return flag;
        }

        public static IContactModel GetItemByEmail(string email)
        {

            IContactModel oldData = list.SearchFirst(email);
            return oldData;
           


        }

        public static void EditItemMenu(string email, IContactModel model)
        {
            
            IContactModel oldData = list.SearchFirst(email);
            
            list.EditContact(model, oldData);
          

        }

        
        public static List<IContactModel> ListAllMenu()
        {

            List<IContactModel> contacts = list.ListAll();
            return contacts;

        }

 

        public static List<IContactModel> SearchMenu(string data)
        {                      
            
            var contacts = list.SearchContact(data);
            return contacts;
        }

       


    }
}
