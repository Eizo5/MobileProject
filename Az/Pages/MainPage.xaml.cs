namespace Az
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            Student_List_View.ItemsSource = App.DBTrans.getAllStudents();
        }

        private void Add_Student_Clicked(object sender, EventArgs e)
        {
            App.DBTrans.AddStudents(new Models.Student
            {
                Student_Name = Student_Name.Text,
                Student_Department = Student_Department.Text,
            });
        }

        private void Show_Student_Clicked(object sender, EventArgs e)
        {
            Student_List_View.ItemsSource = App.DBTrans.getAllStudents();

        }

        private void Delete_Student_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            App.DBTrans.DeleteStudent((int)button.BindingContext);
            Student_List_View.ItemsSource = App.DBTrans.getAllStudents();
        }

        private void Student_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }

}
