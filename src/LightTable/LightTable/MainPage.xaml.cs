using LightTable.ModelView;

namespace LightTable;

public partial class MainPage : ContentPage
{

    public MainPage(MainViewModel ViewModel)
    {
        InitializeComponent();
        BindingContext = ViewModel;
    }
}

