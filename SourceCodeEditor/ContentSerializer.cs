using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SourceCodeEditor
{
    public class ContentSerializer
    {
        private string _path;

        public ContentSerializer(string path = "TextFieldContent.bin")
        {
            _path = path;
        }

        public ContentSerializer() : this(String.Empty) { }

        public void SerializeContent(string Content)
        {
            if (_path == String.Empty)
                _path = "TextFieldContent.bin";
            using (Stream str = File.Open(_path, FileMode.Create))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(str, Content);
                str.Close();
            }
        }

        public string? Deserialize()
        {
            using (Stream str = File.Open(_path, FileMode.Open))
            {
                var bf = new BinaryFormatter();
                return bf.Deserialize(str) as String;
            }
        }
    }
}
