using Caliburn.Micro.SimpleMDI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Caliburn.Micro.SimpleMDI.ViewModels
{
    public class ContactViewModel : Screen
    {

        public ContactViewModel()
        {
            

        }

        public ContactViewModel(IContactModel model)
        {
            SaveModel = model;
            Name = model.Name;
            Email = model.Email;
            Phone = model.Phone;


        }
        private IContactModel SaveModel { get; set; }
        string name, email, phone;
        public bool Flag { get; set; }
      //  ContactList list = new ContactList();
        private IObservableCollection<IContactModel> _list;
        public IObservableCollection<IContactModel> List
        {
            get { return _list; }
            set
            {
                _list = value;
                NotifyOfPropertyChange(() => List);
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
            
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                NotifyOfPropertyChange(() => Email);
           
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                NotifyOfPropertyChange(() => Phone);
            }
        }
        public string CanAdd
        {
            get {

                if (Flag)
                    return "Visible";
                else
                    return "Hidden";
            }
        }
        public string CanSave
        {
            get
            {

                if (Flag)
                    return "Hidden";
                else
                    return "Visible";
            }
        }
        public void AddContact()
        {
            try
            {
                var name = AddressUtility.checkName(Name);
                var email = AddressUtility.checkEmail(Email);
                var phone = AddressUtility.checkPhone(Phone);
                IContactModel cm = new ContactModel();
                cm.Name = name;
                cm.Email = email;
                cm.Phone = phone;
                AddressBook.AddItemMenu(cm);
                EventAggregationProvider.EventAggregator.Publish(AddressBook.ListAllMenu());
                MessageBox.Show(string.Format("Hello {0} {1} {2}!", Name, Email, Phone)); //Don't do this in real life :)
                TryClose();
            }
            catch (AddressException ex)
            {
                MessageBox.Show(ex.Message);
            }

     
            
        }

        public void SaveContact()
        {
            try
            {
                IContactModel model = new ContactModel();
                model.Name = AddressUtility.checkName(Name);
                model.Email = AddressUtility.checkEmail(Email);
                model.Phone = AddressUtility.checkPhone(Phone);
                AddressBook.EditItemMenu(SaveModel.Email, model);
                EventAggregationProvider.EventAggregator.Publish(AddressBook.ListAllMenu());
                TryClose();

            }
            catch (AddressException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DelContact()
        {
            AddressBook.DeleteItemMenu(SaveModel.Email);
            EventAggregationProvider.EventAggregator.Publish(AddressBook.ListAllMenu());
            TryClose();

        }


        public void Close()
        {
            TryClose();
        }



        public void Add()
        {
            MessageBox.Show("Not Implemented");
        }

    }
}
