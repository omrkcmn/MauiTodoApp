using ToDoApp.ViewModels;

namespace ToDoApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}

	
}


