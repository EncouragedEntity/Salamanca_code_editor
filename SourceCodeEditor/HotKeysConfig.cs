using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace SourceCodeEditor
{
    public class HotKeysConfig
    {
        private readonly MenuStrip? menuStrip = null;

        public HotKeysConfig(MenuStrip MainMenuStrip) 
        {
            menuStrip = MainMenuStrip;
        }

        /// <summary>
        /// Get list of hotkeys of all ToolStripMenu items and serialize them into JSON string
        /// </summary>
        /// <param name="listofHotKeys">list of hotkeys</param>
        /// <returns>JSON string</returns>
        private static string SerializeListOfHotKeys(List<Keys> listofHotKeys)
        {
            return JsonSerializer.Serialize(listofHotKeys, new JsonSerializerOptions { WriteIndented = true});
        }

        /// <summary>
        /// Deserialize user defined JSON file into List<T>
        /// </summary>
        /// <param name="path">Path of user defined file</param>
        /// <returns>deserialized list</returns>
        private List<T> DeserializeListOfHotKeys<T>(string path = "HotKeysConfig.json")
        {
            return JsonSerializer.Deserialize<List<T>>(File.ReadAllText(path))!;
        }

        /// <summary>
        /// Saves current hotkeys of ToolStripMenu items into JSON file
        /// </summary>
        public void SaveHotkeysConfig()
        {
            File.WriteAllText("HotKeysConfig.json",SerializeListOfHotKeys(GetCurrentHotKeysNotNull()));
        }

        /// <summary>
        /// Get current loaded hotkeys
        /// </summary>
        /// <returns>List of hotkeys, where hotkeys is not null(or zero)</returns>
        public List<Keys> GetCurrentHotKeysNotNull()
        {
            var listOfHeaderItems = menuStrip!.Items;
            var listOfHotKeys = new List<Keys>();
            foreach (var MainItem in listOfHeaderItems)
            {
                foreach (ToolStripMenuItem item in Header.GetHeaderItems(MainItem))
                {
                    listOfHotKeys.Add(item.ShortcutKeys);
                }
            }
            listOfHotKeys = listOfHotKeys.Where(value => value != 0).ToList();
            return listOfHotKeys;
        }

        /// <summary>
        /// Get current loaded hotkeys
        /// </summary>
        /// <returns>List of hotkeys(including nulls and zeros)</returns>
        public List<Keys> GetCurrentHotKeys()
        {
            var listOfHeaderItems = menuStrip!.Items;
            var listOfHotKeys = new List<Keys>();
            foreach (var MainItem in listOfHeaderItems)
            {
                foreach (ToolStripMenuItem item in Header.GetHeaderItems(MainItem))
                {
                    listOfHotKeys.Add(item.ShortcutKeys);
                }
            }
            return listOfHotKeys;
        }

        /// <summary>
        /// Loads hotkey values from JSON file and assigns them to ToolStripMenu items
        /// </summary>
        public void LoadHotkeysConfig() 
        {
            var listOfHeaderItems = menuStrip!.Items;

            var listOfHotKeys = DeserializeListOfHotKeys<Keys>("HotKeysConfig.json");

            int i = 0;
            foreach (ToolStripItem MainItem in listOfHeaderItems)
            {
                foreach (ToolStripMenuItem item in Header.GetHeaderItems(MainItem))
                {
                    if (i == listOfHotKeys.Count) return;
                    var hotkey = listOfHotKeys[i];
                    item.ShortcutKeys = hotkey;
                    i++;
                }
            }
        }
    }   
}
