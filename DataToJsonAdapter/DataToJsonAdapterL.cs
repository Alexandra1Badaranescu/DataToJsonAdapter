using Newtonsoft.Json;
using DatabaseReader;

namespace DataToJsonAdapter
{
    internal class DataToJsonAdapterL:ITarget
    {
        private readonly DataBaseReaderL? dataBaseReader;

        public DataToJsonAdapterL(DataBaseReaderL dataBaseReader)
        {
            this.dataBaseReader = dataBaseReader;
        }
        public string ReadDataFromSource()
        {
            var DataList = dataBaseReader?.GetData();
            string jsonString = JsonConvert.SerializeObject(DataList);
            return jsonString;
        }
    }
}