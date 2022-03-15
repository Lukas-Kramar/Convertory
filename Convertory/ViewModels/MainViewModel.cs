using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Convertory.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private byte _green;
        private byte _blue;
        private byte _red;
        private byte _aplha;
        private SolidColorBrush _brush;
        private Color _color;

        public MainViewModel()
        {
            _green = 255;
            _blue = 255;
            _red = 255;
            _aplha = 255;

            Colors();
            _brush = new SolidColorBrush(_color);
        }

        public byte Green
        {
            get { return _green; }
            set {
                _green = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("Color");                
            }
        }
        public byte Blue
        {
            get { return _blue; }
            set {
                _blue = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("Color");                
            }
        }
        public byte Red
        {
            get { return _red; }
            set {
                _red = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("Color");
            }
        }

        public SolidColorBrush Color
        {
            //get { return _color; }
            get
            {
                Colors();
                _brush = new SolidColorBrush(_color);
                return (_brush);
                //NotifyPropertyChanged();
            }

        }

        public void Colors ()
        {
            _color.R = _red;
            _color.G = _green;
            _color.B = _blue;
            _color.A = _aplha;
        }
    }
}
