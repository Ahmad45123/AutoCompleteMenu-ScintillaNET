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
            this.AutoComplete.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("AutoComplete.Colors")));
            this.AutoComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoComplete.ImageList = null;
            this.AutoComplete.Items = new string[] {
        "Ahmed",
        "Gasser",
        "Anas",
        "Mohammed",
        "COLOR_RED_GREY",
        "COLOR_RED",
        "SendClientMessage"};
            this.AutoComplete.MaximumSize = new System.Drawing.Size(300, 200);
            this.AutoComplete.TargetControlWrapper = null;
            // 
            // scintilla1
            // 
            this.scintilla1.AutoCMaxHeight = 9;
            this.scintilla1.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            this.scintilla1.CaretLineBackColor = System.Drawing.Color.White;
            this.scintilla1.CaretLineVisible = true;
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.LexerName = null;
            this.scintilla1.Location = new System.Drawing.Point(0, 0);
            this.scintilla1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.ScrollWidth = 93;
            this.scintilla1.Size = new System.Drawing.Size(904, 847);
            this.scintilla1.TabIndents = true;
            this.scintilla1.TabIndex = 0;
            this.scintilla1.Text = "scintilla1";
            this.scintilla1.UseRightToLeftReadingLayout = false;
            this.scintilla1.WrapMode = ScintillaNET.WrapMode.None;
            // 
            // ScintillaSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 847);
            this.Controls.Add(this.scintilla1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
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