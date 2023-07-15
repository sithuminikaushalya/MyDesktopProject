using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dashboard.Model;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Dashboard.ViewModel
{
    public partial class AddStudentViewModel : ObservableObject
    {

        [ObservableProperty]
        public string firstname;
        [ObservableProperty]
        public string lastname;
        [ObservableProperty]
        public BitmapImage image;
        [ObservableProperty]
        public string dateofbirth;
        [ObservableProperty]
        public double gpa;
        public string this[string columnName] => throw new NotImplementedException();


        public AddStudentViewModel(Student std)
        {
            Std = std;
            firstname = Std.FirstName;
            lastname = Std.LastName;
            image = Std.Image;
            dateofbirth = Std.DateOfBirth;
            gpa = Std.GPA;




        }
        public AddStudentViewModel()
        {

        }


        [RelayCommand]
        private void ChooseImage()
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                image = new BitmapImage(new Uri(dialog.FileName));

                MessageBox.Show("Imgae successfuly uploded!", "successfull");

            }

        }

        public Action CloseAction { get; internal set; }

        public Student Std { get; private set; }

        [RelayCommand]
        private void Submit(object obj)
        {


            if (ValidateStudentData())
            {
                if (Std == null)
                {
                    Std = new Student()
                    {
                        FirstName = firstname,
                        LastName = lastname,
                        Image = image,
                        DateOfBirth = dateofbirth,
                        GPA = gpa
                    };
                }
                else
                {
                    Std.FirstName = firstname;
                    Std.LastName = lastname;
                    Std.Image = image;
                    Std.DateOfBirth = dateofbirth;
                    Std.GPA = gpa;



                }
                if (Std.FirstName != null)
                {

                    CloseAction();
                }
                Application.Current.MainWindow.Show();
            }
            else
            {
                MessageBox.Show("Your Input Data Invalid");
            }


        }

        private bool ValidateStudentData()
        {
            // Implement your validation logic here, for example:
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("First Name and Last Name are required.");
                return false;
            }
            if (dateofbirth == null)
            {
                MessageBox.Show("Date of Birth is required.");
                return false;
            }
            if (image == null)
            {
                MessageBox.Show("Image is Required.");
                return false;
            }
            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA must be between 0 and 4.");
                return false;
            }

            return true;
        }



        //// Update the properties to use the Student model
        //public string FirstName
        //{
        //    get => Student.FirstName;
        //    set
        //    {
        //        if (Student.FirstName != value)
        //        {
        //            Student.FirstName = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        //public string LastName
        //{

        //    get => Student.LastName;
        //    set
        //    {
        //        if (Student.LastName != value)
        //        {
        //            Student.LastName = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        //public BitmapImage Image1
        //{
        //    get => Student.Image;
        //    set
        //    {
        //        if(Student.Image != image)
        //        {
        //            Student.Image = image;
        //            OnPropertyChanged("Image");
        //        }
        //    }


        //}

        //public string DateOfBirth
        //{
        //    get => Student.DateOfBirth;
        //    set
        //    {
        //        if (Student.DateOfBirth !=value)
        //        {
        //            Student.DateOfBirth = value;
        //            OnPropertyChanged();
        //        }
        //    }

        //}


        //public double GPA
        //{
        //    get => Student. GPA;
        //    set
        //    {
        //        if(Student.GPA != value)
        //        {
        //            Student.GPA = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}


        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }



}
