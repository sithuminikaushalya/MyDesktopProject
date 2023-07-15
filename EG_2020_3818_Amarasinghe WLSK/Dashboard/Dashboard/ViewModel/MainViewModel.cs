using CommunityToolkit.Mvvm.Input;
using Dashboard.Model;
using Dashboard.View;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Dashboard.ViewModel
{
    public partial class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Student> _students;
        public Student SelectedStudent { get; set; }


        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
            }
        }





        public MainViewModel()
        {
            Students = new ObservableCollection<Student>();

            BitmapImage image1 = new BitmapImage(new Uri("/Assets/User2.jpg", UriKind.Relative));
            Students.Add(new Student("json", "Thomas", "12/11/1943", image1, 3.2));
            BitmapImage image2 = new BitmapImage(new Uri("/Assets/user1.jpg", UriKind.Relative));
            Students.Add(new Student("Ema", "Watson", "12/05/1963", image2, 3.4));

        }

        [RelayCommand]
        private void AddStudent()
        {
            var vm = new AddStudentViewModel();
            var window = new AddStudents(vm);
            window.ShowDialog();
            if (vm.Std.FirstName != null)
            {
                _students.Add(vm.Std);
            }
            else if (vm.Std.FirstName == null)
            {
                MessageBox.Show("Please Enter your details");
            }

        }

        [RelayCommand]
        public void EditStudent()
        {
            if (SelectedStudent != null)
            {
                var vm = new EditStudentViewModel(SelectedStudent);
                var window = new EditStudent(vm);
                //window.DataContext = vm;
                window.ShowDialog();

                int index = _students.IndexOf(SelectedStudent);
                _students.RemoveAt(index);
                _students.Insert(index, vm.Std);
                MessageBox.Show("Upadted Successfully!");


            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }



        }

        [RelayCommand]
        public void Delete()
        {
            if (SelectedStudent != null)
            {
                string name = SelectedStudent.FirstName;
                _students.Remove(SelectedStudent);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");

            }
            else
            {
                MessageBox.Show("Plese Select Student before Delete.", "Error");


            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
