using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dashboard.Model;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Dashboard.ViewModel
{
    public partial class EditStudentViewModel : ObservableObject
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
        public EditStudentViewModel(Student std)
        {
            Std = std;
            firstname = Std.FirstName;
            lastname = Std.LastName;
            image = Std.Image;
            dateofbirth = Std.DateOfBirth;
            gpa = Std.GPA;
        }

        public EditStudentViewModel()
        {

        }

        public Action CloseAction { get; internal set; }

        public Student Std { get; private set; }

        [RelayCommand]
        public void Submit()
        {

            if (ValidateStudentData())
            {
                if (Std == null)
                {
                    Std = new Student()
                    {
                        FirstName = firstname,
                        LastName = lastname,
                        DateOfBirth = dateofbirth,
                        Image = image,
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

        [RelayCommand]
        public void ChooseImage()
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
    }
}
