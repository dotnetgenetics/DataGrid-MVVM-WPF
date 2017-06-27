using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMDataGrid
{
    public class CustomerViewModel : ViewModelBase
    {
        private ObservableCollection<Customer> _cusGridData;
        private NorthwindEntities _context;

        public CustomerViewModel()
        {
            _context = new NorthwindEntities();
            LoadInitialData();
        }

        private void LoadInitialData(){
            CustomerData = new ObservableCollection<Customer>(from c in _context.Customers select c);
        }

        public ObservableCollection<Customer> CustomerData
        {
            get 
            { 
                return _cusGridData; 
            }
            set
            {
                _cusGridData = value;
                OnPropertyChanged("CustomerData");
            }
        }
    }
}
