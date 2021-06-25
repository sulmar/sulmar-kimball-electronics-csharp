namespace KimballElectronics.MACGen.WinFormsClient
{
    partial class MACGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBoxPrefix = new System.Windows.Forms.TextBox();
            this.LabelPrefix = new System.Windows.Forms.Label();
            this.ButtonGenerateMACAddress = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.TextBoxMACAddress = new System.Windows.Forms.TextBox();
            this.ComboBoxSeparator = new System.Windows.Forms.ComboBox();
            this.LabelSeparator = new System.Windows.Forms.Label();
            this.CheckBoxRandom = new System.Windows.Forms.CheckBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.InputQuantity = new System.Windows.Forms.NumericUpDown();
            this.TextBoxMACAddresses = new System.Windows.Forms.TextBox();
            this.GenerateMACAddressProgressBar = new System.Windows.Forms.ProgressBar();
            this.GeneratorBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.InputQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPrefix
            // 
            this.TextBoxPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxPrefix.Location = new System.Drawing.Point(24, 115);
            this.TextBoxPrefix.Name = "TextBoxPrefix";
            this.TextBoxPrefix.Size = new System.Drawing.Size(767, 38);
            this.TextBoxPrefix.TabIndex = 0;
            this.TextBoxPrefix.DoubleClick += new System.EventHandler(this.TextBoxPrefix_DoubleClick);
            // 
            // LabelPrefix
            // 
            this.LabelPrefix.AutoSize = true;
            this.LabelPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPrefix.Location = new System.Drawing.Point(20, 92);
            this.LabelPrefix.Name = "LabelPrefix";
            this.LabelPrefix.Size = new System.Drawing.Size(48, 20);
            this.LabelPrefix.TabIndex = 1;
            this.LabelPrefix.Text = "Prefix";
            // 
            // ButtonGenerateMACAddress
            // 
            this.ButtonGenerateMACAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGenerateMACAddress.BackColor = System.Drawing.Color.Green;
            this.ButtonGenerateMACAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonGenerateMACAddress.ForeColor = System.Drawing.Color.White;
            this.ButtonGenerateMACAddress.Location = new System.Drawing.Point(12, 324);
            this.ButtonGenerateMACAddress.Name = "ButtonGenerateMACAddress";
            this.ButtonGenerateMACAddress.Size = new System.Drawing.Size(768, 62);
            this.ButtonGenerateMACAddress.TabIndex = 2;
            this.ButtonGenerateMACAddress.Text = "Generate MAC Address";
            this.ButtonGenerateMACAddress.UseVisualStyleBackColor = false;
            this.ButtonGenerateMACAddress.Click += new System.EventHandler(this.ButtonGenerateMACAddress_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelResult.Location = new System.Drawing.Point(7, 427);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(188, 20);
            this.LabelResult.TabIndex = 3;
            this.LabelResult.Text = "Generated MAC Address";
            // 
            // TextBoxMACAddress
            // 
            this.TextBoxMACAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMACAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxMACAddress.Location = new System.Drawing.Point(13, 450);
            this.TextBoxMACAddress.Name = "TextBoxMACAddress";
            this.TextBoxMACAddress.ReadOnly = true;
            this.TextBoxMACAddress.Size = new System.Drawing.Size(767, 53);
            this.TextBoxMACAddress.TabIndex = 4;
            this.TextBoxMACAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboBoxSeparator
            // 
            this.ComboBoxSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSeparator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxSeparator.FormattingEnabled = true;
            this.ComboBoxSeparator.Items.AddRange(new object[] {
            "-",
            ";",
            ":"});
            this.ComboBoxSeparator.Location = new System.Drawing.Point(23, 185);
            this.ComboBoxSeparator.Name = "ComboBoxSeparator";
            this.ComboBoxSeparator.Size = new System.Drawing.Size(768, 39);
            this.ComboBoxSeparator.TabIndex = 5;
            // 
            // LabelSeparator
            // 
            this.LabelSeparator.AutoSize = true;
            this.LabelSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSeparator.Location = new System.Drawing.Point(20, 162);
            this.LabelSeparator.Name = "LabelSeparator";
            this.LabelSeparator.Size = new System.Drawing.Size(80, 20);
            this.LabelSeparator.TabIndex = 6;
            this.LabelSeparator.Text = "Separator";
            // 
            // CheckBoxRandom
            // 
            this.CheckBoxRandom.AutoSize = true;
            this.CheckBoxRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxRandom.Location = new System.Drawing.Point(22, 37);
            this.CheckBoxRandom.Name = "CheckBoxRandom";
            this.CheckBoxRandom.Size = new System.Drawing.Size(89, 24);
            this.CheckBoxRandom.TabIndex = 7;
            this.CheckBoxRandom.Text = "Random";
            this.CheckBoxRandom.UseVisualStyleBackColor = true;
            this.CheckBoxRandom.CheckedChanged += new System.EventHandler(this.CheckBoxRandom_CheckedChanged);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(10, 735);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(767, 63);
            this.ButtonClose.TabIndex = 8;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSettings.ForeColor = System.Drawing.Color.White;
            this.ButtonSettings.Location = new System.Drawing.Point(10, 666);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(767, 63);
            this.ButtonSettings.TabIndex = 9;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantity";
            // 
            // InputQuantity
            // 
            this.InputQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InputQuantity.Location = new System.Drawing.Point(28, 270);
            this.InputQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputQuantity.Name = "InputQuantity";
            this.InputQuantity.Size = new System.Drawing.Size(763, 26);
            this.InputQuantity.TabIndex = 12;
            this.InputQuantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TextBoxMACAddresses
            // 
            this.TextBoxMACAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMACAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxMACAddresses.Location = new System.Drawing.Point(13, 526);
            this.TextBoxMACAddresses.Multiline = true;
            this.TextBoxMACAddresses.Name = "TextBoxMACAddresses";
            this.TextBoxMACAddresses.ReadOnly = true;
            this.TextBoxMACAddresses.Size = new System.Drawing.Size(767, 134);
            this.TextBoxMACAddresses.TabIndex = 13;
            this.TextBoxMACAddresses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenerateMACAddressProgressBar
            // 
            this.GenerateMACAddressProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateMACAddressProgressBar.Location = new System.Drawing.Point(13, 393);
            this.GenerateMACAddressProgressBar.Name = "GenerateMACAddressProgressBar";
            this.GenerateMACAddressProgressBar.Size = new System.Drawing.Size(764, 23);
            this.GenerateMACAddressProgressBar.Step = 1;
            this.GenerateMACAddressProgressBar.TabIndex = 14;
            // 
            // GeneratorBackgroundWorker
            // 
            this.GeneratorBackgroundWorker.WorkerReportsProgress = true;
            this.GeneratorBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GeneratorBackgroundWorker_DoWork);
            this.GeneratorBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.GeneratorBackgroundWorker_ProgressChanged);
            this.GeneratorBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GeneratorBackgroundWorker_RunWorkerCompleted);
            // 
            // MACGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 808);
            this.Controls.Add(this.GenerateMACAddressProgressBar);
            this.Controls.Add(this.TextBoxMACAddresses);
            this.Controls.Add(this.InputQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.CheckBoxRandom);
            this.Controls.Add(this.LabelSeparator);
            this.Controls.Add(this.ComboBoxSeparator);
            this.Controls.Add(this.TextBoxMACAddress);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.ButtonGenerateMACAddress);
            this.Controls.Add(this.LabelPrefix);
            this.Controls.Add(this.TextBoxPrefix);
            this.Name = "MACGenerator";
            this.Text = "MAC Address Generator";
            ((System.ComponentModel.ISupportInitialize)(this.InputQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPrefix;
        private System.Windows.Forms.Label LabelPrefix;
        private System.Windows.Forms.Button ButtonGenerateMACAddress;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.TextBox TextBoxMACAddress;
        private System.Windows.Forms.ComboBox ComboBoxSeparator;
        private System.Windows.Forms.Label LabelSeparator;
        private System.Windows.Forms.CheckBox CheckBoxRandom;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown InputQuantity;
        private System.Windows.Forms.TextBox TextBoxMACAddresses;
        private System.Windows.Forms.ProgressBar GenerateMACAddressProgressBar;
        private System.ComponentModel.BackgroundWorker GeneratorBackgroundWorker;
    }
}

