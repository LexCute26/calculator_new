using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class CalculatorModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private  string _firstNumber;

        private  string _secondNumber;

        private char _strOperator = ' ';

        private string _result;

        public string FirstNumber
        {
            get
            {
                return _firstNumber;
            }
            set
            {
                _firstNumber = value;
                OnPropertyChanged("FirstNumber");
            }
        }

        public string SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                _secondNumber = value;
                OnPropertyChanged("SecondNumber");
            }
        }

        public char Operator
        {
            get
            {
                return _strOperator;
            }
            set
            {
                _strOperator = value;
                OnPropertyChanged("Operator");
            }
        }

        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

    }
}
