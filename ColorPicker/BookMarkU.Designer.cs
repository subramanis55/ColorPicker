namespace ColorPicker
{
    partial class BookMarkU
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HexValueLB = new Label();
            RGBValueLB = new Label();
            ColorP = new Panel();
            RGBValueP = new Panel();
            HexValueP = new Panel();
            RGBValueP.SuspendLayout();
            HexValueP.SuspendLayout();
            SuspendLayout();
            // 
            // HexValueLB
            // 
            HexValueLB.AllowDrop = true;
            HexValueLB.AutoSize = true;
            HexValueLB.Dock = DockStyle.Bottom;
            HexValueLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HexValueLB.Location = new Point(15, 1);
            HexValueLB.Name = "HexValueLB";
            HexValueLB.Size = new Size(65, 28);
            HexValueLB.TabIndex = 0;
            HexValueLB.Text = "label1";
            // 
            // RGBValueLB
            // 
            RGBValueLB.AllowDrop = true;
            RGBValueLB.AutoSize = true;
            RGBValueLB.Dock = DockStyle.Bottom;
            RGBValueLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RGBValueLB.Location = new Point(25, 1);
            RGBValueLB.Name = "RGBValueLB";
            RGBValueLB.Size = new Size(65, 28);
            RGBValueLB.TabIndex = 1;
            RGBValueLB.Text = "label2";
            RGBValueLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ColorP
            // 
            ColorP.Dock = DockStyle.Left;
            ColorP.Location = new Point(3, 3);
            ColorP.Name = "ColorP";
            ColorP.Size = new Size(97, 34);
            ColorP.TabIndex = 2;
            // 
            // RGBValueP
            // 
            RGBValueP.Controls.Add(RGBValueLB);
            RGBValueP.Dock = DockStyle.Fill;
            RGBValueP.Location = new Point(100, 3);
            RGBValueP.Name = "RGBValueP";
            RGBValueP.Padding = new Padding(25, 10, 5, 5);
            RGBValueP.Size = new Size(189, 34);
            RGBValueP.TabIndex = 3;
            // 
            // HexValueP
            // 
            HexValueP.AllowDrop = true;
            HexValueP.Controls.Add(HexValueLB);
            HexValueP.Dock = DockStyle.Right;
            HexValueP.Location = new Point(289, 3);
            HexValueP.Name = "HexValueP";
            HexValueP.Padding = new Padding(15, 10, 5, 5);
            HexValueP.Size = new Size(180, 34);
            HexValueP.TabIndex = 4;
            // 
            // BookMarkU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RGBValueP);
            Controls.Add(HexValueP);
            Controls.Add(ColorP);
            Name = "BookMarkU";
            Padding = new Padding(3);
            Size = new Size(472, 40);
            RGBValueP.ResumeLayout(false);
            RGBValueP.PerformLayout();
            HexValueP.ResumeLayout(false);
            HexValueP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label HexValueLB;
        private Label RGBValueLB;
        private Panel ColorP;
        private Panel RGBValueP;
        private Panel HexValueP;
    }
}
