using System;
using System.Windows.Input;
using ToDoApp.Views;

namespace ToDoApp.ViewModels
{
	public class MainPageViewModel
	{
        public Command GoToAddList { get; private set; }

        public MainPageViewModel()
		{
			GoToAddList = new Command(async () => await GoTodoPage());
		}


		async Task GoTodoPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new AddTodoPage());
		}
	}
}

