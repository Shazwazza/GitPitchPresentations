public class MyController : RenderMvcController
{
  public override ActionResult Index(
    ContentModel model)
  {
      //... do stuff... 
      
      return base.Index(model);
  }
}