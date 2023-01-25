namespace Tester
{
    partial class ScintillaSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScintillaSample));
            this.AutoComplete = new AutocompleteMenuNS.AutocompleteMenu();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.SuspendLayout();
            // 
            // AutoComplete
            // 
            this.AutoComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AutoComplete.ImageList = null;
            this.AutoComplete.Items = new string[] {
        "Ahmed",
        "Gasser",
        "Anas",
        "Mohammed",
        "COLOR_RED_GREY",
        "COLOR_RED",
        "SendClientMessage"};
            this.AutoComplete.TargetControlWrapper = null;
            // 
            // scintilla1
            // 
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.Location = new System.Drawing.Point(0, 0);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(417, 344);
            this.scintilla1.TabIndex = 0;
            this.scintilla1.Text = "scintilla1";
            this.scintilla1.UseTabs = false;
            // 
            // ScintillaSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 344);
            this.Controls.Add(this.scintilla1);
            this.Name = "ScintillaSample";
            this.Text = "ScintillaSample";
            this.Load += new System.EventHandler(this.ScintillaSample_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private AutocompleteMenuNS.AutocompleteMenu AutoComplete;
        private ScintillaNET.Scintilla scintilla1;
    }
}