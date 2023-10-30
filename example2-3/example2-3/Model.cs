using System;

namespace example2_3;

public class A
{
    public A()
    {
        Console.WriteLine(GetType());
    }
}
    
public class B
{
    public B(A a)
    {
        Console.WriteLine(GetType());
    }
}