public class MyController : RenderMvcController
{
  public MyController(MyService myService,
      ...) : base(...)
  {
      _myService = myService;
  }
  
  private readonly MyService _myService;

  public override ActionResult Index(
    ContentModel model)
  {
      _myService.DoStuff(model);    
      return base.Index(model);
  }
}