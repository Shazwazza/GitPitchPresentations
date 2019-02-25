public class MyController : RenderMvcController
{
  public override ActionResult Index(
    RenderModel model)
  {
      //... do stuff... 

      return base.Index(model);
  }
}