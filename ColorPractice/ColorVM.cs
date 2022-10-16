using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ColorPractice
{
    internal class ColorViewModel : INotifyPropertyChanged
    {
        public Color model;
        public ObservableCollection<ListBoxItem> colorList = new();
        public ColorViewModel()
        {
            model = new Color { alpha = 0, red = 0, green = 0, blue = 0 };
        }
        public int Alpha
        {
            get { return model.alpha; }
            set
            {
                model.alpha = value;
                OnPropertyChanged("Alpha");
            }
        }
        public int Red
        {
            get { return model.red; }
            set
            {
                model.red = value;
                OnPropertyChanged("Red"); 
            }
        }
        public int Green
        {
            get { return model.green; }
            set
            {
                model.green = value;
                OnPropertyChanged("Green");
            }
        }
        public int Blue
        {
            get { return model.blue; }
            set
            {
                model.blue = value;
                OnPropertyChanged("Blue");
            }
        }


        // Event binds view to ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}
