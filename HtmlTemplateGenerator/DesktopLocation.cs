namespace HtmlTemplateGenerator
{
    public static class DesktopLocation
    {
        private static string fileName = "/template.html";
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + fileName;
    }
}
