using System.ComponentModel;
using System.Windows.Input;

public class ProfileViewModel : INotifyPropertyChanged
{
    public ICommand EditProfileCommand { get; set; }
    public ICommand ChangePasswordCommand { get; set; }
    public ICommand AddDeleteCreditCardCommand { get; set; }
    public ICommand ViewHistoryCommand { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
