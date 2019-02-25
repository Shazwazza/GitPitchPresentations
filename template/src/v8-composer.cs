public class MyComposer : IComposer
{
  public void Compose(Composition composition)
  {
    composition.ContentFinders()
        .Insert<MyFinder>();
  }
}


