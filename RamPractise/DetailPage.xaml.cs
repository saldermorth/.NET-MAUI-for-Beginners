using RamPractise.ViewModel;

namespace RamPractise;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailsViewModel wm)
	{
		InitializeComponent();
		BindingContext = wm;
	}
}