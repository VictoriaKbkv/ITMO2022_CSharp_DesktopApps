using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ITMO_CSharp_DesktopApps_WPF_Lab09Ex1
{
    public class StudentList : ObservableCollection<Student>
    {

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private System.Collections.IEnumerable studentCollection1;

        public System.Collections.IEnumerable studentCollection { get => studentCollection1; set => SetProperty(ref studentCollection1, value); }
    }
}
