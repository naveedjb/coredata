using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;


namespace Caliburn.Micro.SimpleMDI.Data
{
    public class ContactList :  PropertyChangedBase, IContact
    {
        public List<IContactModel> contacts = new List<IContactModel>();


        
        
        public ContactList()
        {
                 
                 try
                     {
                 
                         using (Stream stream = File.Open("data.bin", FileMode.Open))
                         {
                             BinaryFormatter bin = new BinaryFormatter();

                             contacts = (List<IContactModel>)bin.Deserialize(stream);
                             Console.WriteLine(contacts.Count);

                         }
                     }
                     catch (Exception e)
                     {
                         MessageBox.Show(e.Message);

                     }
            
                 
           


                
        }

         public void WriteList()
          {
              try
              {
                  using (Stream stream = File.Open("data.bin", FileMode.Create))
                  {
                      BinaryFormatter bin = new BinaryFormatter();
                      bin.Serialize(stream, contacts);
                  }
              }
              catch (IOException)
              {
              }


          }
          
        public int AddContact(IContactModel contact) {

            contacts.Add(contact);
            return contacts.Count;
        }
        public bool DeleteContact(string email) {
            IContactModel item = contacts.Find(x => x.Email == email);
            
            if(item !=null)
            {
                return contacts.Remove(item);
            }
            return false;
        }
        public List<IContactModel> ListAll() {
            return contacts;
        }
        public bool EditContact(IContactModel add, IContactModel delete) {

            contacts.Remove(delete);
                contacts.Add(add);
            return true;
        }

        public IContactModel SearchFirst(string email)
        {
            IContactModel item = contacts.Find(x => x.Email == email);
            return item;

        }


        public List<IContactModel> SearchContact(string search) {

           var list= contacts.FindAll(delegate(IContactModel model)
            {
                return model.Email.Contains(search) || model.Name.Contains(search) || model.Phone.Contains(search);


            });
           return list;
        }
    }
}
