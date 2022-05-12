namespace Test_soft;

using Divine.Service;


public class Class1 : Bootstrapper
{
    protected override void OnActivate()
    {
        System.Console.WriteLine("OnActivate()");
    }

    protected override void OnDeactivate()
    { 
        System.Console.WriteLine("OnDeactivate()");
    }
}
