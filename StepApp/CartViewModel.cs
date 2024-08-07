using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

public class CartViewModel : INotifyPropertyChanged
{
    public ObservableCollection<CartItem> CartItems { get; set; }
    public ICommand DecreaseCountCommand { get; set; }
    public ICommand IncreaseCountCommand { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class CartItem
{
    public string ProductName { get; set; }
    public int Count { get; set; }
    public decimal TotalPrice { get; set; }
}
