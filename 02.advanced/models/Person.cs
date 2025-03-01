using CommunityToolkit.Mvvm.ComponentModel;

namespace mvvm_advanced;
public partial class Person : ObservableObject
{

    [ObservableProperty]
    private string  _name;

    [ObservableProperty]
    private int     _age;
    
    // Name ���� ����
    partial void OnNameChanged(string value)
    {
       Console.WriteLine($"����ڰ� �Է��� �� �̸�: {value}");
    }

}