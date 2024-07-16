using Calculator.MVVM.ViewModels;

namespace Calculator.MVVM.Views;

public partial class CalcView : ContentPage
{
    public CalcView()
    {
        InitializeComponent();
        BindingContext = new CalcViewModel();
    }
}