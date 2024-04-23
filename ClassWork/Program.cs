using System;

public interface IPlayable
{
    void Play();
}

public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Guitar is now playing");
    }
}

public class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Piano is now playing");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Guitar guitar = new Guitar();
        Piano piano = new Piano();

        
        guitar.Play();

        
        piano.Play();
    }
}
