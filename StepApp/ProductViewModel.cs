using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class ProductViewModel : INotifyPropertyChanged
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public ICommand AddToCartCommand { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName]string propertyName =null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
