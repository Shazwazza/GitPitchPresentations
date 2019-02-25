public class MyComposer : IComposer
{
  public void Compose(Composition composition)
  {
    //register MyController - lifetime is IMPORTANT!
    composition.Register<MyController>(Lifetime.Request);
    
    //Example of a custom Singleton service
    composition.RegisterUnique<MyService>();
  }
}

