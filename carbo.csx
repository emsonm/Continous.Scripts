using System;
using System.Collections.Generic;
using Xamarin.Forms;

public class App : Application
{
    
    public App ()
    {
        var weight = new Entry 
        {
          Placeholder = "Weight"
        };
        
        var carbs = new Entry 
        {
          Placeholder = "Carbs"
        };
        
        var newWeight = new Entry 
        {
          Placeholder = "New weight"
        };
      
        var go = new Button
        {
          Text="Go",
          VerticalOptions = LayoutOptions.CenterAndExpand,
          FontSize = 25,
          BorderWidth = 1,
        };
        
        var reset = new Button
        {
          Text="Reset",
          VerticalOptions = LayoutOptions.CenterAndExpand,
          FontSize = 25,
          BorderWidth = 1,
        };
        
        var result = new Label
        {
          Text = "...",
          VerticalOptions = LayoutOptions.CenterAndExpand,
          HorizontalOptions = LayoutOptions.CenterAndExpand
        };
        
                
        go.Clicked += (s,e) => 
        {
          var weightv = string.IsNullOrEmpty(weight.Text)? 0: float.Parse(weight.Text);
          
          var carbv = string.IsNullOrEmpty(carbs.Text)? 0: float.Parse(carbs.Text);
          
          var newWeightv = string.IsNullOrEmpty(newWeight.Text)? 0: float.Parse(newWeight.Text);
          
          var resultv = (carbv / weightv) * newWeightv;
          
          result.Text = resultv.ToString();
          
        };
        
        reset.Clicked += (s,e) => 
        {
          result.Text = "0";
        };
        
        
        
        
        MainPage = new ContentPage
        {
            Content = new StackLayout 
            {
               Padding = new Thickness(25),
               Orientation = StackOrientation.Vertical,
               Children =
               {
                 new Label
                 {
                   FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                   Text = "Carb calculator"
                 },
                 weight,
                 carbs,
                 newWeight,
                 new StackLayout
                 {
                   Orientation = StackOrientation.Vertical,
                   Children =
                   {
                     result, 
                     go,
                     reset
                   }
                 },
               }
            }             
                
        };
    }
}

var app = new App();
