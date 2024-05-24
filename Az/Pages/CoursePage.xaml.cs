namespace Az;

public partial class CoursePage : ContentPage
{
	public CoursePage()
	{
		InitializeComponent();
        Course_List_View.ItemsSource = App.DBTrans.getAllCourses();
	}

    private void Add_Course_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddCourses(new Models.Course
        {
            Course_Code = Course_Code.Text,
            Course_Name = Course_Name.Text,
        });

    }

    private void Show_Course_Clicked(object sender, EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans.getAllCourses();
    }

    private void Delete_Course_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteCourse((int)button.BindingContext);
        Course_List_View.ItemsSource = App.DBTrans.getAllCourses();
    }

    private void Course_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }
}