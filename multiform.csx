using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

public class MainFormPage: ContentPage
{
  public MainFormPage()
  {
    var go = new Button
    {
      Text="Go",
      VerticalOptions = LayoutOptions.CenterAndExpand,
      FontSize = 25,
      BorderWidth = 1,
    };
    
    go.Clicked += OnGoClicked;
    
    Content = new StackLayout 
    {
         Padding = new Thickness(25),
         Orientation = StackOrientation.Vertical,
         Children = { go }
    };
    
  }
  
  async void OnGoClicked(object sender, EventArgs e)
	{
			await Navigation.PushAsync(new SubFormPage ());
	}
  
}

public class SubFormPage: ContentPage
{
  public SubFormPage()
  {
    Content = new StackLayout 
    {
         Padding = new Thickness(25),
         Orientation = StackOrientation.Vertical,
         Children = { new Label
                 {
                   FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                   Text = "Sub form"
                 },
                 }
    };
  }
}



public class App: Application
{
  public App()
  {
    MainPage = new NavigationPage(new MainFormPage());
  }
  
  ContentPage CreateSub()
  {
    return new ContentPage{};
  }
}

var app = new App();
