using System.Runtime.Serialization.Formatters.Binary;

namespace SourceCodeEditor
{
    public class ContentSerializer
    {
        public string? Content { get; set; }

        public ContentSerializer(string content)
        {
            Content = content;
        }

        public ContentSerializer() : this(String.Empty) { }

        public void SerializeContent()
        {
            using (Stream str = File.Open("TextFieldContent.bin", FileMode.Create))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(str, Content);
                str.Close();
            }
        }

        public string? Deserialize()
        {
            using (Stream str = File.Open("TextFieldContent.bin", FileMode.Open))
            {
                var bf = new BinaryFormatter();
                return Content = bf.Deserialize(str) as String;
            }
        }
    }
}
