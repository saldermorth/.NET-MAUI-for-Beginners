using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RamPractise.ViewModel
{
    [QueryProperty("Text", "Text")]
    public partial class DetailsViewModel : ObservableObject
    {
        public DetailsViewModel() { }
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
