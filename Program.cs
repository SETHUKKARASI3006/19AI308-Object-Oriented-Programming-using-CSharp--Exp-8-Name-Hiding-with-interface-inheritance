using System;
using System.IO;
public interface IMario
{
    void Ability();
}
class Mario:IMario
{
    public virtual void Ability()
    {
        Console.WriteLine("This is inside Mario Class");
    }
}
class SuperMario:Mario
{
    public new void Ability()
    {
        Console.WriteLine("This is inside SuperMario");
    }
}
public class MarioGame
{
    public static void Main(string[] args)
    {
        SuperMario s = new SuperMario();
        s.Ability();
        Mario m = new Mario();
        m.Ability();

    }
}