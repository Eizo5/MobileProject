using Az.Models;

namespace Az;

public partial class EnrollmentPage : ContentPage
{
    int Stu_ID;
    int Crs_ID;
	public EnrollmentPage()
	{
		InitializeComponent();
        Student_List_View.ItemsSource = App.DBTrans.getAllStudents();
        Course_List_View.ItemsSource = App.DBTrans.getAllCourses();
        Enrollment_List_View.ItemsSource = App.DBTrans.getEnrolls();
	}

    private void Add_Enrollment_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddEnroll(new Models.Enroll
        {
            Student_ID = Stu_ID,
            Course_ID = Crs_ID,
        });
    }

    private void Show_Enrollment_Clicked(object sender, EventArgs e)
    {
        Enrollment_List_View.ItemsSource = App.DBTrans.getEnrolls();
    }

    private void Delete_Enrollment_Clicked(object sender, EventArgs e)
    {

        Button button = (Button)sender;
        App.DBTrans.DeleteEnroll((int)button.BindingContext);
        Enrollment_List_View.ItemsSource = App.DBTrans.getEnrolls();
    }

    private void Student_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var student = e.Item as Student;
        Stu_ID = student.Student_ID;
    }

    private void Course_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var course = e.Item as Course;
        Crs_ID = course.Course_ID;


    }

    private void Enrollment_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }

    private void Show_Selection_Button_Clicked(object sender, EventArgs e)
    {
      
        Student_List_View.ItemsSource = App.DBTrans.getAllStudents();
        Course_List_View.ItemsSource = App.DBTrans.getAllCourses();
    }

}