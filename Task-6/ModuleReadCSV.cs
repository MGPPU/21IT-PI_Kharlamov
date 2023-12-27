namespace Task_6
{
    public class ModuleReadCSV : IRead
    {
        public void Write(string FileName)
        {
            Console.WriteLine(File.ReadAllText(FileName));
        }
    }
}