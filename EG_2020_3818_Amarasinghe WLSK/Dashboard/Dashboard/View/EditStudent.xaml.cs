using Dashboard.ViewModel;
using System.Windows;

namespace Dashboard.View
{
    /// <summary>
    /// Interaction logic for EditStudent.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        public EditStudent(EditStudentViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();

        }


    }
}
