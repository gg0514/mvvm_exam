using CommunityToolkit.Mvvm.ComponentModel;

namespace mvvm_advanced;
public partial class Person : ObservableObject
{

    [ObservableProperty]
    private string  _name;

    [ObservableProperty]
    private int     _age;
    
    // Name 변경 감지
    partial void OnNameChanged(string value)
    {
       Console.WriteLine($"사용자가 입력한 새 이름: {value}");
    }

}