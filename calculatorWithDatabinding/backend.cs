using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Windows.Media;

namespace calculatorWithDatabinding
{
    class backend : INotifyPropertyChanged
    {
        
        private string _opperation;
        public string opperation
        {
            get { return (_opperation); }
            set
            {
                _opperation = value;

                if(_opperation == "*")
                {
                    opperationText = "Multiply";
                }
                else if (_opperation == "/")
                {
                    opperationText = "Divide";
                }
                else if (_opperation == "+")
                {
                    opperationText = "Add";
                }
                else if (_opperation == "-")
                {
                    opperationText = "Subtract";
                }
            }
        }
        
        public void calculate()
        {
            if(_opperation == "")
            {
                return;
            }

            try
            {
                errorText = "";

                float input = float.Parse(_inputText);
                float input2 = float.Parse(_inputText2);

                if (_opperation == "+")
                    resultText = (input + input2).ToString();
                else if (_opperation == "-")
                    resultText = (input - input2).ToString();
                else if (_opperation == "/")
                    resultText = (input / input2).ToString();
                else if (_opperation == "*")
                    resultText = (input * input2).ToString();
            }
            catch
            {
                errorText = "Invalid Inputs!";
            }
        }


        private string _resultText;
        public string resultText
        {
            get { return (_resultText); }
            set
            {
                _resultText = value;
                OnPropertyChanged("resultText");
            }
        }

        private string _opperationText;
        public string opperationText
        {
            get{ return (_opperationText);}
            set
            {
                _opperationText = value;
                OnPropertyChanged("opperationText");
            }
        }

        private string _inputText;
        public string inputText
        {
            get { return (_inputText); }
            set
            {
                _inputText = value;
                OnPropertyChanged("inputText");
            }
        }

        private string _inputText2;
        public string inputText2
        {
            get { return (_inputText2); }
            set
            {
                _inputText2 = value;
                OnPropertyChanged("inputText2");
            }
        }


        private string _errorText;
        public string errorText
        {
            get { return (_errorText); }
            set
            {
                _errorText = value;
                OnPropertyChanged("errorText");
            }
        }

        public backend()
        {
        }


        #region Data Binding Handle

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
