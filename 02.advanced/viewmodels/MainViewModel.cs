using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace mvvm_advanced;

// 여기서 partial class임을 주목!!
public partial class MainViewModel : ObservableObject
{

    [ObservableProperty]
    public Person _person;


    [RelayCommand]
    private void UpdateName()
    {
        Person.Name = "Updated Name";

        Debug.WriteLine($"값: {Person.Name}");
    }



    public MainViewModel()
    {
        Person = new Person { Name = "Hello", Age = 30 };
    }

    partial void OnPersonChanged(Person value)
    {
        Console.WriteLine($"사용자가 입력한 값: {value.Name}");
    }
}