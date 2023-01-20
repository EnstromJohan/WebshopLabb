using WebshopLabb;

internal class TextIO : IUI
{

    public void Exit()
    {
        System.Environment.Exit(0);
    }

    public void Print(string text)
    {
        
    }

    public string UserInput()
    {
        return Console.ReadLine();
    }
}