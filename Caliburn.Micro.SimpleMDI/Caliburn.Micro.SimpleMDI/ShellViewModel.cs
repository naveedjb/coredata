using System.Windows;


namespace Caliburn.Micro.SimpleMDI {

    using Caliburn.Micro.SimpleMDI;
    using Caliburn.Micro.SimpleMDI.Data;
    using Caliburn.Micro.SimpleMDI.ViewModels;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IHandle<List<IContactModel>> 
    {
        int count = 1;
        private ObservableCollection<IContactModel> _list;
        public ObservableCollection<IContactModel> List
        {
            get { return _list; }
            set
            {
                _list = value;
                NotifyOfPropertyChange(() => List);
            }
        }

       
        public ShellViewModel()
        {
            EventAggregationProvider.EventAggregator.Subscribe(this);
            List = new ObservableCollection<IContactModel>(AddressBook.ListAllMenu());
          
        }
        public void Handle(List<IContactModel> message)
        {
            //MessageBox.Show("Not Implemented");
         //   Collection<IContactModel> collection = new Collection<IContactModel>(message);
            List = new ObservableCollection<IContactModel>(message);

            //do the save process
        }
        public void Add()
        {
          //  MessageBox.Show("Not Implemented");

            WindowManager windowManager = new WindowManager();
            ContactViewModel vm = new ContactViewModel();
          //  SearchViewModel vm1 = new SearchViewModel();
            vm.Flag = true;
            windowManager.ShowDialog(vm);
        }
        public void RowSelect(IContactModel row)
        {
            WindowManager windowManager = new WindowManager();
            ContactViewModel vm = new ContactViewModel(row);
           
            //  SearchViewModel vm1 = new SearchViewModel();
            vm.Flag = false;
            windowManager.ShowDialog(vm);
          //  MessageBox.Show("");
            //now how to access the selected row after the double click event?
        }

        public void NameLostFocus(string text)
        {
          //  text = text.Trim();
        //    if (string.IsNullOrEmpty(text))
          //      return;
            
            var list = AddressBook.SearchMenu(text);
            List = new ObservableCollection<IContactModel>(list);
        }

        protected override void OnDeactivate(bool close)
        {

            AddressBook.list.WriteList();
        }
    }
}