using System;
using System.Collections.Generic;
using Xamarin.Forms;

public class MainPage: ContentPage
{
    public MainPage()
    {
        var image = new Image
        {
            Aspect = Aspect.AspectFit,
    Source = ImageSource.FromUri(new Uri("http://xamarin.com/content/images/pages/branding/assets/xamagon.png")),
        };
        
        var text = new Entry
        {
            Placeholder = "url of image"
        };
        
        var button = new Button
        {
            Text = "load",
            BorderWidth = 1
        };
        button.Clicked += (s, e) =>
        {
            image.Source = ImageSource.FromUri(new Uri(text.Text));
        };
        
        Content = new StackLayout
        {
            Children =
            {
                text,
                button,
                image
            }
        };
    }
}

public class App: Application
{
    public App()
    {
        MainPage = new NavigationPage(new MainPage());
    }
}
