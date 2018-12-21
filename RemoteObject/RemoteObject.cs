using System;
public class RemoteObject : MarshalByRefObject
{
    public RemoteObject()
    {
        Console.WriteLine("Constructor called");
    }
    public string Greeting(string name)
    {
        Console.WriteLine("Greeting called");
        return "Hello," + name;
    }
}
