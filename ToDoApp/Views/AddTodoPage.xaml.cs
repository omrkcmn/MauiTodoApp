using ToDoApp.ViewModels;

namespace ToDoApp.Views;

public partial class AddTodoPage : ContentPage
{
	public AddTodoPage()
	{
		InitializeComponent();
		BindingContext = new AddTodoPageViewModel();
	}
}
