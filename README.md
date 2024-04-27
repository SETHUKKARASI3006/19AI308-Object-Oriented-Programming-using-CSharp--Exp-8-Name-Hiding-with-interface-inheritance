# 19AI308-Object-Oriented-Programming-using-CSharp--Exp-8-Name-Hiding-with-interface-inheritance
# AIM:
To implement name hiding with interface inheritance. Aim is to create an interface IMario with a method Ability(). 
Implement this interface in a class Mario and override the Ability() method also to create another class SuperMario that inherits from Mario and hides the Ability() method using the new keyword.

# ALGORITHM:
## Step 1: 
Create interface IMario with method Ability for Mario classes.
## Step 2: 
Mario class implements IMario, defines virtual Ability method.
## Step 3: 
SuperMario extends Mario, overrides Ability method with new.
## Step 4: 
Instantiate SuperMario and Mario, call Ability on each.
## Step 5: 
SuperMario's Ability prints "This is inside SuperMario", Mario's prints "This is inside Mario".

# PROGRAM:
Developed By: SETHUKKARASI C<br>
Register Number: 212223230201

```
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
```

# OUTPUT:
![output](image.png)

# RESULT:
Thus, C# program to implement name hiding with interface inheritance is verified and executed successfully.