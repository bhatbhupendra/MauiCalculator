using MauiCalculator.MVVM.ViewModel;

namespace MauiCalculator.MVVM;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		BindingContext = new CalcViewModel();
	}
}