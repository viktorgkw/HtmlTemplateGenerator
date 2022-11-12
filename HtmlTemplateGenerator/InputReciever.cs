namespace HtmlTemplateGenerator
{
    internal class InputReciever
    {
        private FileWriter _fileWriter;

        public InputReciever(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void ProcessInput()
        {
            string element;

            while ((element = Console.ReadLine().ToLower()) != "end")
            {
                string[] elementInformation = element.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);

                if (elementInformation.Length == 1)
                {
                    _fileWriter.CreateTag(elementInformation[0]);
                }
                else if (elementInformation.Length == 2)
                {
                    _fileWriter.CreateElement(elementInformation[0], elementInformation[1]);
                }
                else if (elementInformation.Length == 3)
                {
                    _fileWriter.CreateElement(elementInformation[0], elementInformation[1], elementInformation[2]);
                }
            }
        }
    }
}