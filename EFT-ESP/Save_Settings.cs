using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace EFT_ESP
{
    public class Save_Settings
    {
        public string GameFolder { get; set; }
        public string ESPFolder { get; set; }

        public static void Save(string Path_game, string Path_esp)
        {
            Save_Settings setting = new Save_Settings();

            string serialized;
            string filename = "Setting.json";

            StiingJson mySettings = new StiingJson();
            mySettings.SettingsJson = new Save_Settings[1];

            mySettings.SettingsJson[0] = new Save_Settings()
            {
                GameFolder = $"{Path_game}",
                ESPFolder = $"{Path_esp}",
            };

            serialized = JsonConvert.SerializeObject(mySettings);

            if (serialized.Count() > 1)
            {
                if (!File.Exists(filename))
                    File.Create(filename).Close();
                File.WriteAllText(filename, serialized);
            }
        }
    }

    public class StiingJson { public Save_Settings[] SettingsJson { get; set; } }
}
