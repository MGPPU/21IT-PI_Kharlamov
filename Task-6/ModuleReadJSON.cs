namespace Task_6
{
    public class ModuleReadJSON : IRead
    {
        public void Write(string FileName)
        {
            Console.WriteLine(File.ReadAllText(FileName));
        }
    }
}