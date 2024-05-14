namespace WinFormsApp1
{
    partial class MainForm
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
            usCtrl = new WinFormsControlLibrary1.UserControl1();
            SuspendLayout();
            // 
            // usCtrl
            // 
            usCtrl.CustomProperty = "Numbers";
            usCtrl.Location = new Point(106, 89);
            usCtrl.Name = "usCtrl";
            usCtrl.Size = new Size(232, 169);
            usCtrl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 382);
            Controls.Add(usCtrl);
            Name = "MainForm";
            Text = "Form1";
            SizeChanged += Size;
            ResumeLayout(false);
        }

        #endregion

        private WinFormsControlLibrary1.UserControl1 usCtrl;
    }
}
