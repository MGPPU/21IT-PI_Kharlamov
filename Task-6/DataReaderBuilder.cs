namespace Task_6
{
    class DataReaderBuilder : IDataReaderBuilder
    {
        private DataReader _DataReader;

        public DataReaderBuilder(String FileName)
        {
            var File = new FileInfo(FileName);
            switch (File.Extension)
            {
                case ".csv":
                    _DataReader = new DataReader(new ModuleReadCSV());
                    break;
                case ".json":
                    _DataReader = new DataReader(new ModuleReadJSON());
                    break;
                default:
                    throw new Exception("Неизвестный формат файла");
            }
            _DataReader.FileName = FileName;
        }
        public DataReader GetDataReader()
        {
            return _DataReader;
        }
    }
}