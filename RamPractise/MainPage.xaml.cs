using RamPractise.ViewModel;

namespace RamPractise;

public partial class MainPage : ContentPage
{


    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;

    }





}

