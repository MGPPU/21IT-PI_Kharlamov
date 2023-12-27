namespace Task_6
{
    public class DataReader
    {
        public string FileName { get; set; }
        private IRead _reader;
        public void Write()
        {
            _reader.Write(FileName);
        }
        public DataReader(IRead Reader)
        {
            this._reader = Reader;
        }
    }
}