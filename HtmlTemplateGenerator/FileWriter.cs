namespace HtmlTemplateGenerator
{
    public class FileWriter
    {
        private StreamWriter _streamWriter;

        public FileWriter(StreamWriter streamWriter)
        {
            _streamWriter = streamWriter;
        }

        public void CreateTag(string elementName)
        {
            _streamWriter.WriteLine($"   <{elementName} />");
            _streamWriter.WriteLine();
        }

        public void CreateElement(string elementName, string elementText, string elementHref = null)
        {
            if (elementHref != null)
            {
                _streamWriter.WriteLine($"   <{elementName} href=\"{elementHref}\">{elementText}</{elementName}>");
            }
            else
            {
                _streamWriter.WriteLine($"   <{elementName}>{elementText}</{elementName}>");
            }

            _streamWriter.WriteLine();
        }
    }
}
