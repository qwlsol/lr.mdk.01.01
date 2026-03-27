using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SQLTest
{
    public class User : INotifyPropertyChanged
    {

        private string login_;
        private string password_;
        private int age_;
        private string name_;

        public string Login
        {
            get { return login_; }
            set
            {
                login_ = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return password_; }
            set
            {
                password_ = value;
                OnPropertyChanged();
            }
        }
        public int Age
        {
            get { return age_; }
            set
            {
                if (age_ != value) 
                {
                    age_ = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
