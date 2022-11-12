namespace HtmlTemplateGenerator
{
    public class Engine
    {
        public void Start()
        {
            using (StreamWriter streamWriter = new StreamWriter(DesktopLocation.path))
            {
                FileWriter fileWriter = new FileWriter(streamWriter);
                InputReciever inputReciever = new InputReciever(fileWriter);

                GenerateDefaultTemplate.DefaultTemplate(streamWriter);

                inputReciever.ProcessInput();

                GenerateDefaultTemplate.CloseTemplate(streamWriter);
            }

            Console.WriteLine("Template created!");
        }
    }
}
