namespace BusinesCardWebsite.Areas.Admin.Controllers
{
    public static class Extensions
    {
        public static string CutController(this string str)
        {
            return str.Replace("Controller", "");
        }
    }
}
