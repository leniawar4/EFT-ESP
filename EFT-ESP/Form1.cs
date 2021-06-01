using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFT_ESP
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Save_Settings settings = new Save_Settings();
        public string Path_Game { get; set; }
        public string Path_ESP { get; set; }
        public string Path_Temp_Game { get; set; }

        public static string textbox;

        public Form1()
        {
            InitializeComponent();
        }

        public void TextBox_Viwe(string text)
        {
            Info_text_box.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string serialized;
            string filename = "Setting.json";
            string Path_game2 = "", Path_esp2 = "";

            try
            {
                if (File.Exists(filename))
                {
                    serialized = File.ReadAllText(filename);

                    dynamic json = JObject.Parse(serialized);
                    Path_game2 = json.SettingsJson[0].GameFolder;
                    Path_esp2 = json.SettingsJson[0].ESPFolder;
                }
                if (!File.Exists(Path_Temp_Game))
                {
                    string a = Path.GetTempPath();
                    var s = a + "\\FolderTemp";
                    Directory.CreateDirectory(s);
                    Path_Temp_Game = s;
                }
            }
            catch { }

            Path_Game = Path_game2;
            Path_ESP = Path_esp2;

            if (Path_Game != "" && Path_ESP != "")
            {
                textbox = "Путь до игры : " + Path_Game + "\r\n" + "Путь до ESP : " + Path_ESP + "\r\n" + "Путь до временной папки : " + Path_Temp_Game + "\r\n";
                TextBox_Viwe(textbox);
            }
            else
            {
                textbox = "Путь до игры : Пока что не указано\r\n" + "Путь до ESP : Пока что не указано\r\n" + "Путь до временной папки : " + Path_Temp_Game + "\r\n";
                TextBox_Viwe(textbox);
            }
        }

        public void Rabota (string Path, string Path1, bool kek)
        {
            DirectoryCopy.Copy(Path, Path1, kek);

            MessageBox.Show("Поток завершон!!");
        }

        public void Rabota2(string Path, string Path1, bool kek)
        {
            DirectoryCopy.Copy(Path, Path1, kek);

            MessageBox.Show("Поток завершон!!");

            textbox = "Очистка временного хранилища";
            TextBox_Viwe(textbox);

            textbox = "Ещё увидимся пока )";
            TextBox_Viwe(textbox);
        }

        private void bt_Path_Game_Click(object sender, EventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Path_Game = fbd.SelectedPath;
                }
            }
            if (Path_Game != null)
            {
                textbox = "Ваш путь до игры : " + Path_Game + "\r\n";
                TextBox_Viwe(textbox);
            }
                
        }

        private void bt_Path_ESP_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path_Game))
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        Path_ESP = fbd.SelectedPath;
                    }
                }

                textbox = "Ваш путь до ESP : " + Path_ESP + "\r\n";
                TextBox_Viwe(textbox);
            }
            else
            {
                textbox = "Путь до игры не выбран" + "\r\n";
                TextBox_Viwe(textbox);
            }
        }

        private void bt_Temp_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Path_Temp_Game = fbd.SelectedPath;
                }
            }
            textbox = "Ваш путь до временой папки : " + Path_Temp_Game + "\r\n";
            TextBox_Viwe(textbox);
        }

        private void btn_inject_Click(object sender, EventArgs e)
        {
            string filename = "Setting.json";

            if (!File.Exists(filename))
            {
                textbox = "Сохранения настроек" + "\r\n";
                TextBox_Viwe(textbox);
                Save_Settings.Save(Path_Game, Path_ESP);
            }

            textbox = "Начало замены" + "\r\n";
            TextBox_Viwe(textbox);

            Rabota(Path_ESP, Path_Game, true);

            textbox = "Приятной игры" + "\r\n";
            TextBox_Viwe(textbox);
        }

        private void bt_file_copy_temp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дождитесь сообщения о том что поток завершен");
            Thread th = new Thread(() => Rabota(Path_Game, Path_Temp_Game, true));
            th.Start();
        }

        private void btn_reinject_Click(object sender, EventArgs e)
        {
            textbox = "Начало замены" + "\r\n";
            TextBox_Viwe(textbox);

            MessageBox.Show("Дождитесь сообщения о том что поток завершен");
            Thread th = new Thread(() => Rabota2(Path_Temp_Game, Path_Game, true));
            th.Start();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Directory.Delete(Path_Temp_Game, true);
        }
    }
}
