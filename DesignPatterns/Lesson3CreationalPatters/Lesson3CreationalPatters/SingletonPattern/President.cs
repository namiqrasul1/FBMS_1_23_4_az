namespace Lesson3CreationalPatters.SingletonPattern;

public class President
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Age { get; set; }
    static President? President1 { get; set; }

    private President() { }

    public static President GetPresident()
    {
        President1 ??= new President();
        return President1;
    }

}
