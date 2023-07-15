using Dashboard.ViewModel;
using System.Windows;

namespace Dashboard.View
{
    /// <summary>
    /// Interaction logic for AddStudents.xaml
    /// </summary>
    public partial class AddStudents : Window
    {
        public AddStudents(AddStudentViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }
    }
}
