
namespace EFT_ESP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_Path_Game = new MetroFramework.Controls.MetroButton();
            this.bt_Path_ESP = new MetroFramework.Controls.MetroButton();
            this.btn_inject = new MetroFramework.Controls.MetroButton();
            this.btn_reinject = new MetroFramework.Controls.MetroButton();
            this.Info_text_box = new MetroFramework.Controls.MetroTextBox();
            this.bt_file_copy_temp = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // bt_Path_Game
            // 
            this.bt_Path_Game.Location = new System.Drawing.Point(23, 82);
            this.bt_Path_Game.Name = "bt_Path_Game";
            this.bt_Path_Game.Size = new System.Drawing.Size(338, 39);
            this.bt_Path_Game.TabIndex = 0;
            this.bt_Path_Game.Text = "Upload Path Game";
            this.bt_Path_Game.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bt_Path_Game.UseSelectable = true;
            this.bt_Path_Game.UseStyleColors = true;
            this.bt_Path_Game.Click += new System.EventHandler(this.bt_Path_Game_Click);
            // 
            // bt_Path_ESP
            // 
            this.bt_Path_ESP.Location = new System.Drawing.Point(20, 196);
            this.bt_Path_ESP.Name = "bt_Path_ESP";
            this.bt_Path_ESP.Size = new System.Drawing.Size(338, 39);
            this.bt_Path_ESP.TabIndex = 1;
            this.bt_Path_ESP.Text = "Upload Path ESP";
            this.bt_Path_ESP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bt_Path_ESP.UseSelectable = true;
            this.bt_Path_ESP.UseStyleColors = true;
            this.bt_Path_ESP.Click += new System.EventHandler(this.bt_Path_ESP_Click);
            // 
            // btn_inject
            // 
            this.btn_inject.Location = new System.Drawing.Point(22, 252);
            this.btn_inject.Name = "btn_inject";
            this.btn_inject.Size = new System.Drawing.Size(164, 39);
            this.btn_inject.TabIndex = 3;
            this.btn_inject.Text = "inject File";
            this.btn_inject.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_inject.UseSelectable = true;
            this.btn_inject.UseStyleColors = true;
            this.btn_inject.Click += new System.EventHandler(this.btn_inject_Click);
            // 
            // btn_reinject
            // 
            this.btn_reinject.Location = new System.Drawing.Point(192, 252);
            this.btn_reinject.Name = "btn_reinject";
            this.btn_reinject.Size = new System.Drawing.Size(166, 39);
            this.btn_reinject.TabIndex = 4;
            this.btn_reinject.Text = "Reinject File";
            this.btn_reinject.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_reinject.UseSelectable = true;
            this.btn_reinject.UseStyleColors = true;
            this.btn_reinject.Click += new System.EventHandler(this.btn_reinject_Click);
            // 
            // Info_text_box
            // 
            // 
            // 
            // 
            this.Info_text_box.CustomButton.Image = null;
            this.Info_text_box.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.Info_text_box.CustomButton.Name = "";
            this.Info_text_box.CustomButton.Size = new System.Drawing.Size(125, 125);
            this.Info_text_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Info_text_box.CustomButton.TabIndex = 1;
            this.Info_text_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Info_text_box.CustomButton.UseSelectable = true;
            this.Info_text_box.CustomButton.Visible = false;
            this.Info_text_box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Info_text_box.Lines = new string[0];
            this.Info_text_box.Location = new System.Drawing.Point(23, 316);
            this.Info_text_box.MaxLength = 32767;
            this.Info_text_box.Multiline = true;
            this.Info_text_box.Name = "Info_text_box";
            this.Info_text_box.PasswordChar = '\0';
            this.Info_text_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Info_text_box.SelectedText = "";
            this.Info_text_box.SelectionLength = 0;
            this.Info_text_box.SelectionStart = 0;
            this.Info_text_box.ShortcutsEnabled = true;
            this.Info_text_box.Size = new System.Drawing.Size(335, 127);
            this.Info_text_box.Style = MetroFramework.MetroColorStyle.Blue;
            this.Info_text_box.TabIndex = 5;
            this.Info_text_box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Info_text_box.UseSelectable = true;
            this.Info_text_box.UseStyleColors = true;
            this.Info_text_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Info_text_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bt_file_copy_temp
            // 
            this.bt_file_copy_temp.Location = new System.Drawing.Point(20, 138);
            this.bt_file_copy_temp.Name = "bt_file_copy_temp";
            this.bt_file_copy_temp.Size = new System.Drawing.Size(338, 39);
            this.bt_file_copy_temp.TabIndex = 6;
            this.bt_file_copy_temp.Text = "Copy Folder in Temp";
            this.bt_file_copy_temp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bt_file_copy_temp.UseSelectable = true;
            this.bt_file_copy_temp.UseStyleColors = true;
            this.bt_file_copy_temp.Click += new System.EventHandler(this.bt_file_copy_temp_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 457);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(338, 31);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Delite Temp";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 509);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.bt_file_copy_temp);
            this.Controls.Add(this.Info_text_box);
            this.Controls.Add(this.btn_reinject);
            this.Controls.Add(this.btn_inject);
            this.Controls.Add(this.bt_Path_ESP);
            this.Controls.Add(this.bt_Path_Game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "EFT ESP by Leniawar";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton bt_Path_Game;
        private MetroFramework.Controls.MetroButton bt_Path_ESP;
        private MetroFramework.Controls.MetroButton btn_inject;
        private MetroFramework.Controls.MetroButton btn_reinject;
        private MetroFramework.Controls.MetroTextBox Info_text_box;
        private MetroFramework.Controls.MetroButton bt_file_copy_temp;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

