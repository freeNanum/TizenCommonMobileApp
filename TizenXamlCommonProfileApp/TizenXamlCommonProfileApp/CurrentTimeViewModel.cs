using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace TizenXamlCommonProfileApp
{
    class CurrentTimeViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;

        public event PropertyChangedEventHandler PropertyChanged;

        public CurrentTimeViewModel()
        {
            this.dateTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.dateTime = DateTime.Now;
                return true;
            });
        }

        public DateTime DateTime
        {
            set
            {
                if(dateTime != value)
                {
                    dateTime = value;
                    
                    if(PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("dateTime"));
                    }
                }

            }

            get
            {
                return this.dateTime;
            }
        }
    }
}
