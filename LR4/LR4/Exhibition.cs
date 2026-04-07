using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    public class Exhibition : INotifyPropertyChanged
    {
        private string place_;
        private DateTime dateAndTime_;
        private string performer_;
        private decimal cost_;

        public string Place
        {
            get { return place_; }
            set
            {
                place_ = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateAndTime
        {
            get { return dateAndTime_; }
            set
            {
                if (dateAndTime_ != value)
                {
                    dateAndTime_ = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Performer
        {
            get { return performer_; }
            set
            {
                performer_ = value;
                OnPropertyChanged();
            }
        }

        public decimal Cost
        {
            get { return cost_; }
            set
            {
                if (cost_ != value)
                {
                    cost_ = value;
                    OnPropertyChanged();
                }
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
