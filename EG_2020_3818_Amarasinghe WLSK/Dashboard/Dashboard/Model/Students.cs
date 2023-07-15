using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace Dashboard.Model
{
    public class Student : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BitmapImage Image { get; set; }
        public string DateOfBirth { get; set; }
        public double GPA { get; set; }

        public Student(string firstName, string lastName, string dateOfBirth, BitmapImage image, double gpa)
        {

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Image = image;
            GPA = gpa;
        }

        public Student()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}
