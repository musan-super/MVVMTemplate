using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTemplate.ViewModels.MVVM
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void UpDate<T>(ref T t1, T t2, [CallerMemberName] string propertyname = null)
        {
            if (!EqualityComparer<T>.Default.Equals(t1, t2))
            {
                t1 = t2;
               OnPropertyChanged(propertyname);
            }
        }
        public void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
