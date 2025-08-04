namespace MonkeyFinder.ViewModel;

public partial class BaseViewModel : ObservableObject
{
   
    public BaseViewModel()
    {
    
    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;
    
}

