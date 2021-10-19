using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPage : ContentPage
    {
        public MainPage MyMainPage { get; set; }

        public NewPage(MainPage mainpage)
        {
            BindingContext = MyMainPage = mainpage;
           
            InitializeComponent();
        }
    }
}