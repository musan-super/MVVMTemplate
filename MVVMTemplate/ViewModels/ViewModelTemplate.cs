using MVVMTemplate.ViewModels.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTemplate.ViewModels
{
    internal class ViewModelTemplate:ViewModelBase
    {
        private string _variate;
        public string Variate
        {
            get { return _variate; }
            set
            {
                UpDate<string>(ref _variate, value);
                AddRelayCommand.OnCanExecuteChanged();
            }
        }

        private RelayCommand _addRelayCommand;
        public RelayCommand AddRelayCommand
        {
            set { _addRelayCommand = value; }
            get
            {
                if (_addRelayCommand == null)
                    _addRelayCommand = new RelayCommand(() => { AddMethod(); }, () => true);
                return _addRelayCommand;
            }
        }

        private void AddMethod()
        {
            throw new NotImplementedException("实现这个方法");
        }
    }
}
