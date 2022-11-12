namespace HtmlTemplateGenerator
{
    public static class GenerateDefaultTemplate
    {
        public static void DefaultTemplate(StreamWriter streamWriter)
        {
            streamWriter.WriteLine("<!DOCTYPE html>");
            streamWriter.WriteLine("<html lang=\"en\">");
            streamWriter.WriteLine("<head>");
            streamWriter.WriteLine("   <meta charset=\"UTF-8\">");
            streamWriter.WriteLine("   <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
            streamWriter.WriteLine("   <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            streamWriter.WriteLine("   <title>Template</title>");
            streamWriter.WriteLine("</head>");
            streamWriter.WriteLine("<body>");
        }

        public static void CloseTemplate(StreamWriter streamWriter)
        {
            streamWriter.WriteLine("</body>");
            streamWriter.WriteLine("</html>");
        }
    }
}
