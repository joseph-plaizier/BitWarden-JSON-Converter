namespace BitWarden_JSON
{
    partial class Hide_Columns
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
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(27, 26);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(254, 508);
            checkedListBox1.TabIndex = 0;
            // 
            // Hide_Columns
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 643);
            Controls.Add(checkedListBox1);
            Name = "Hide_Columns";
            Text = "Hide_Columns";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
    }
}