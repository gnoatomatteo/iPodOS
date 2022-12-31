using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPodOS.Model
{
    public class Patient : INotifyPropertyChanged
    {
        #region Properties
        private string _guid;
        public string Guid
        {
            get { return _guid; }
            set
            {
                _guid = value;
                OnPropertyChanged("guid");
            }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name");
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged("surnname");
            }
        }

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                _dateOfBirth = value;
                OnPropertyChanged("dateOfBirth");
            }
        }

        private List<MedicalExamination> _medicalExaminations;
        public List<MedicalExamination> MedicalExaminations
        {
            get
            {
                if (_medicalExaminations == null) _medicalExaminations = new List<MedicalExamination>();
                return _medicalExaminations;
            }
            set
            {
                _medicalExaminations = value;
                OnPropertyChanged("medicalExaminations");
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
