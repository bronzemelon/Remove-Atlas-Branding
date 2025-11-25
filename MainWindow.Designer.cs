namespace Remove_Atlas_Branding
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            RemoveAll = new Button();
            ApplyChanges = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Model = new TextBox();
            Manufacturer = new TextBox();
            SupportPhone = new TextBox();
            SupportURL = new TextBox();
            OpenAboutSettings = new Button();
            label5 = new Label();
            Organization = new TextBox();
            Winver = new Button();
            SuspendLayout();
            // 
            // RemoveAll
            // 
            RemoveAll.Location = new Point(39, 380);
            RemoveAll.Name = "RemoveAll";
            RemoveAll.Size = new Size(135, 23);
            RemoveAll.TabIndex = 0;
            RemoveAll.Text = "Remove All";
            RemoveAll.UseVisualStyleBackColor = true;
            RemoveAll.Click += RemoveAll_Click;
            // 
            // ApplyChanges
            // 
            ApplyChanges.Location = new Point(203, 380);
            ApplyChanges.Name = "ApplyChanges";
            ApplyChanges.Size = new Size(135, 23);
            ApplyChanges.TabIndex = 1;
            ApplyChanges.Text = "Apply Changes";
            ApplyChanges.UseVisualStyleBackColor = true;
            ApplyChanges.Click += ApplyChanges_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 50);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Manufacturer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 74);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Support Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 103);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 5;
            label4.Text = "Support URL";
            // 
            // Model
            // 
            Model.Location = new Point(39, 165);
            Model.Name = "Model";
            Model.Size = new Size(299, 23);
            Model.TabIndex = 6;
            Model.Text = "Set Model Text";
            Model.TextChanged += Model_TextChanged;
            // 
            // Manufacturer
            // 
            Manufacturer.Location = new Point(39, 206);
            Manufacturer.Name = "Manufacturer";
            Manufacturer.Size = new Size(299, 23);
            Manufacturer.TabIndex = 7;
            Manufacturer.Text = "Set Manufacturer Text";
            Manufacturer.TextChanged += Manufacturer_TextChanged;
            // 
            // SupportPhone
            // 
            SupportPhone.Location = new Point(39, 248);
            SupportPhone.Name = "SupportPhone";
            SupportPhone.Size = new Size(299, 23);
            SupportPhone.TabIndex = 8;
            SupportPhone.Text = "Set Support Phone Text";
            SupportPhone.TextChanged += SupportPhone_TextChanged;
            // 
            // SupportURL
            // 
            SupportURL.Location = new Point(39, 290);
            SupportURL.Name = "SupportURL";
            SupportURL.Size = new Size(299, 23);
            SupportURL.TabIndex = 9;
            SupportURL.Text = "Set Support URL Text";
            SupportURL.TextChanged += SupportURL_TextChanged;
            // 
            // OpenAboutSettings
            // 
            OpenAboutSettings.Location = new Point(39, 409);
            OpenAboutSettings.Name = "OpenAboutSettings";
            OpenAboutSettings.Size = new Size(135, 23);
            OpenAboutSettings.TabIndex = 10;
            OpenAboutSettings.Text = "Open About Settings";
            OpenAboutSettings.UseVisualStyleBackColor = true;
            OpenAboutSettings.Click += OpenAboutSettings_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 131);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 5;
            label5.Text = "Organization";
            // 
            // Organization
            // 
            Organization.Location = new Point(39, 331);
            Organization.Name = "Organization";
            Organization.Size = new Size(299, 23);
            Organization.TabIndex = 9;
            Organization.Text = "Set Organization Text";
            Organization.TextChanged += Organization_TextChanged;
            // 
            // Winver
            // 
            Winver.Location = new Point(203, 409);
            Winver.Name = "Winver";
            Winver.Size = new Size(135, 23);
            Winver.TabIndex = 11;
            Winver.Text = "Open Winver";
            Winver.UseVisualStyleBackColor = true;
            Winver.Click += Winver_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(Winver);
            Controls.Add(OpenAboutSettings);
            Controls.Add(Organization);
            Controls.Add(SupportURL);
            Controls.Add(SupportPhone);
            Controls.Add(Manufacturer);
            Controls.Add(Model);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ApplyChanges);
            Controls.Add(RemoveAll);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "MainWindow";
            Text = "Remove Atlas Branding";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RemoveAll;
        private Button ApplyChanges;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Model;
        private TextBox Manufacturer;
        private TextBox SupportPhone;
        private TextBox SupportURL;
        private Button OpenAboutSettings;
        private Label label5;
        private TextBox Organization;
        private Button Winver;
    }
}
