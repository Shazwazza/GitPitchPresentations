[Weight(-10)]
public class MyDashboard : IDashboard
{
    public string Alias => "myCustomDashboard";
    public string[] Sections => new[] { "content", "settings" };
    public string View => "~/App_Plugins/MyPackage/dashboard.html";
    public IAccessRule[] AccessRules => Array.Empty<IAccessRule>();
}