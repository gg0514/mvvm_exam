using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace mvvm_advanced;

// ���⼭ partial class���� �ָ�!!
public partial class MainViewModel : ObservableObject
{

    [ObservableProperty]
    public Person _person;


    [RelayCommand]
    private void UpdateName()
    {
        Person.Name = "Updated Name";

        Debug.WriteLine($"��: {Person.Name}");
    }



    public MainViewModel()
    {
        Person = new Person { Name = "Hello", Age = 30 };
    }

    partial void OnPersonChanged(Person value)
    {
        Console.WriteLine($"����ڰ� �Է��� ��: {value.Name}");
    }
}