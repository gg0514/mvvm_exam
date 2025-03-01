using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace mvvm_exam;

public class MainViewModel : ObservableObject
{
    public Person Person { get; set; }

    public ICommand UpdateNameCommand { get; }

    public MainViewModel()
    {
        Person = new Person { Name = "John", Age = 30 };

        UpdateNameCommand = new RelayCommand(() => Person.Name = "Updated Name"); 
    }
}