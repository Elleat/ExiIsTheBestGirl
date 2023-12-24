namespace Laba6Observer;
public static class Program
{
    public static void Main (string [] args)
    {
        var Obseerver = new ConcreteObserver();
        var Subject = new Subject();
        Subject.Add(Obseerver);
        Subject.ReadData();
    }
}
public interface IObserver 
{
    void Notify();
}
public class ConcreteObserver : IObserver
{
    public void Notify()
    {
        Console.WriteLine("Я поддерживаю Я");
    }
}
public class Subject
{
    private List<IObserver> observers =
        new List<IObserver>();

    public void Add(IObserver o)
    {
        observers.Add(o);
    }

    public void Remove (IObserver o)
    {
        observers.Remove(o);
    }

    public void Notify()
    {
        foreach (IObserver o in observers)
            o.Notify ();
    }

    public void ReadData()
    {
        Console.WriteLine("Введите число");
        string? data = Console.ReadLine();
        try 
        {
            if (Convert.ToInt16(data)==2025)
            {
                Notify();
            }
            else
            {
                Console.WriteLine("Числа не равны");
            }
        }
        catch
        {
            Console.WriteLine("Нужно ввести число");

        }
    } 
}

