public interface ISilence
{
    void Speak();
}

public class EmptyRoom : ISilence
{
    public void Speak()
    {
        // ...
        // ...
        // ...
    }
}

class Night
{
    static void Main()
    {
        ISilence room = new EmptyRoom();

        room.Speak();
    }
}