namespace text2mojibake
{
    partial class text2mojibake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(text2mojibake));
            this.label1 = new System.Windows.Forms.Label();
            this.OriginalTextHolder = new System.Windows.Forms.ComboBox();
            this.EncodingType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecodingType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputTextHolder = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // OriginalTextHolder
            // 
            resources.ApplyResources(this.OriginalTextHolder, "OriginalTextHolder");
            this.OriginalTextHolder.FormattingEnabled = true;
            this.OriginalTextHolder.Items.AddRange(new object[] {
            resources.GetString("OriginalTextHolder.Items"),
            resources.GetString("OriginalTextHolder.Items1"),
            resources.GetString("OriginalTextHolder.Items2")});
            this.OriginalTextHolder.Name = "OriginalTextHolder";
            this.OriginalTextHolder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OriginalTextHolder_KeyUp);
            this.OriginalTextHolder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OriginalTextHolder_MouseDoubleClick);
            // 
            // EncodingType
            // 
            this.EncodingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.EncodingType, "EncodingType");
            this.EncodingType.FormattingEnabled = true;
            this.EncodingType.Name = "EncodingType";
            this.EncodingType.SelectedIndexChanged += new System.EventHandler(this.EncodingType_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DecodingType
            // 
            this.DecodingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.DecodingType, "DecodingType");
            this.DecodingType.FormattingEnabled = true;
            this.DecodingType.Name = "DecodingType";
            this.DecodingType.SelectedIndexChanged += new System.EventHandler(this.DecodingType_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // OutputTextHolder
            // 
            resources.ApplyResources(this.OutputTextHolder, "OutputTextHolder");
            this.OutputTextHolder.Name = "OutputTextHolder";
            this.OutputTextHolder.ReadOnly = true;
            this.OutputTextHolder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OutputTextHolder_MouseDoubleClick);
            // 
            // CopyButton
            // 
            resources.ApplyResources(this.CopyButton, "CopyButton");
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // AboutButton
            // 
            resources.ApplyResources(this.AboutButton, "AboutButton");
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // QuitButton
            // 
            resources.ApplyResources(this.QuitButton, "QuitButton");
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // text2mojibake
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.OutputTextHolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecodingType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EncodingType);
            this.Controls.Add(this.OriginalTextHolder);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "text2mojibake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.text2mojibake_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text2mojibake_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OriginalTextHolder;
        private System.Windows.Forms.ComboBox EncodingType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DecodingType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OutputTextHolder;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button QuitButton;
    }
}