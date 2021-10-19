using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<int> Values { get; set; } = new ObservableCollection<int>();

        public static readonly BindableProperty SomeTextProperty = BindableProperty.Create(nameof(SomeText), typeof(string), typeof(MainPage), default(string));
        public string SomeText
        {
            get { return (string)GetValue(SomeTextProperty); }
            set { SetValue(SomeTextProperty, value); }
        }

        public MainPage()
        {
            SomeText = "Default";

            for (int i = 0; i <= 1000; i++)
                Values.Add(i);

            BindingContext = this;

            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage(this));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //GC.Collect();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            SomeText = SomeText == "Default" ? "Some Value" : "Default";
        }
    }
}
