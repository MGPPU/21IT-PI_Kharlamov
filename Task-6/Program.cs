namespace Task_6
{
    class Progrma
    {
        static void Main(string[] args)
        {
            // Выведет в консоль файл json
            var BuilderJSON = new DataReaderBuilder("test.json");
            BuilderJSON.GetDataReader().Write();

            // Выведет в консоль файл csv
            var BuilderCSV = new DataReaderBuilder("test.csv");
            BuilderCSV.GetDataReader().Write();

            // Вызовет исключение с причиной "Неизвестный формат файла"
            var BuilderXML = new DataReaderBuilder("test.xml");
            BuilderXML.GetDataReader().Write();
        }
    }
}