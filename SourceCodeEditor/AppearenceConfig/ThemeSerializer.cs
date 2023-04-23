using FastColoredTextBoxNS;
using System.Runtime.Serialization.Formatters.Binary;

namespace SourceCodeEditor.AppearenceConfig
{
    public class ThemeSerializer
    {
        private CurrentTheme _theme;

        public ThemeSerializer(CurrentTheme theme, MainForm form)
        {
            _theme = theme;
            _theme.ThemePath = form.theme!.ThemePath;
        }

        public static T? Deserialize<T>(string path)
        {
            using (Stream str = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                var bf = new BinaryFormatter();
                var obj = (T)bf.Deserialize(str);
                str.Close();
                return obj;
            }
        }

        public void SerializeTheme()
        {
            using (Stream str = File.Open(_theme.ThemePath, FileMode.Create))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(str, _theme);
                str.Close();
            }
        }

        public void SerializeSyntax()
        {
            using (Stream str = File.Open(_theme.syntaxColors.SyntaxPath, FileMode.Create))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(str, _theme.syntaxColors);
                str.Close();
            }
        }
    }
}
