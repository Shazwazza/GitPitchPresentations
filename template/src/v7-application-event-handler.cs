public class MyApp : ApplicationEventHandler
{
  protected override void ApplicationStarting(
      UmbracoApplicationBase umbracoApplication,
      ApplicationContext applicationContext) 
  {
    ContentFinderResolver.Current
        .Insert<MyFinder>();
  }
}