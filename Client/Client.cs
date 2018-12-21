using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

public class Client
{
    public static void Main(string[] args)
    {
        //Create an IPC client channel.
        IpcClientChannel channel = new IpcClientChannel();
        //Register the channel with ChannelServices.
        ChannelServices.RegisterChannel(channel, false);
        RemoteObject obj = (RemoteObject)Activator.GetObject(typeof(RemoteObject), "ipc://ServerChannel/RemoteObject");
        if (obj == null)
        {
            Console.WriteLine("could not locate server");
            return;
        }
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine(obj.Greeting("mmpire"));
        }
    }
}