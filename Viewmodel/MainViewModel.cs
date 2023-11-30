using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Media;
using WpfAppexampl.Command;
using WpfAppexampl.Model;

namespace WpfAppexampl.Viewmodel
{

    public class MainViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Color _selectedColor;
        private bool _isAlphaSliderEnabled = true;
        private bool _isRedSliderEnabled = true;
        private bool _isGreenSliderEnabled = true;
        private bool _isBlueSliderEnabled = true;

        public MainViewModel()
        {
            
            SelectedColor = Colors.Black; 
        }

        public Color SelectedColor
        {
            get { return _selectedColor; }
            set
            {
                if (_selectedColor != value)
                {
                    _selectedColor = value;
                    OnPropertyChanged(nameof(SelectedColor));
                }
            }
        }
        public bool IsAlphaSliderEnabled
        {
            get { return _isAlphaSliderEnabled; }
            set
            {
                if (_isAlphaSliderEnabled != value)
                {
                    _isAlphaSliderEnabled = value;
                    OnPropertyChanged(nameof(IsAlphaSliderEnabled));
                }
            }
        }

        public bool IsRedSliderEnabled
        {
            get { return _isRedSliderEnabled; }
            set
            {
                if (_isRedSliderEnabled != value)
                {
                    _isRedSliderEnabled = value;
                    OnPropertyChanged(nameof(IsRedSliderEnabled));
                }
            }
        }

        public bool IsGreenSliderEnabled
        {
            get { return _isGreenSliderEnabled; }
            set
            {
                if (_isGreenSliderEnabled != value)
                {
                    _isGreenSliderEnabled = value;
                    OnPropertyChanged(nameof(IsGreenSliderEnabled));
                }
            }
        }

        public bool IsBlueSliderEnabled
        {
            get { return _isBlueSliderEnabled; }
            set
            {
                if (_isBlueSliderEnabled != value)
                {
                    _isBlueSliderEnabled = value;
                    OnPropertyChanged(nameof(IsBlueSliderEnabled));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}