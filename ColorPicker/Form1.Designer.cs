namespace ColorPicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ColorPickerTopPanel = new Panel();
            bookMarkBtn = new EllipseButton();
            settingPageBtn = new EllipseButton();
            colorMarkBtn = new EllipseButton();
            colorPickBtn = new EllipseButton();
            minimizeBtn = new EllipseButton();
            maximizeBtn = new EllipseButton();
            closeBtn = new EllipseButton();
            ColorPickingPageBtn = new EllipseButton();
            ProgressBarP = new Panel();
            panel7 = new Panel();
            progressBaru3 = new ProgressBarU();
            panel6 = new Panel();
            progressBaru2 = new ProgressBarU();
            panel5 = new Panel();
            progressBaru1 = new ProgressBarU();
            MainP = new Panel();
            MainTabControl = new TabControl();
            ColorPickingPage = new TabPage();
            rgbMainP = new Panel();
            panel10 = new Panel();
            bluergbTB = new TextBox();
            panel9 = new Panel();
            greenrgbTB = new TextBox();
            panel8 = new Panel();
            redrgbTB = new TextBox();
            HexColorTB = new Panel();
            panel1 = new Panel();
            colorHexValueTB = new TextBox();
            settingPage = new TabPage();
            bookMarkPage = new TabPage();
            ColorPickerTopPanel.SuspendLayout();
            ProgressBarP.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            MainP.SuspendLayout();
            MainTabControl.SuspendLayout();
            ColorPickingPage.SuspendLayout();
            rgbMainP.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            HexColorTB.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ColorPickerTopPanel
            // 
            ColorPickerTopPanel.BackColor = Color.White;
            ColorPickerTopPanel.Controls.Add(bookMarkBtn);
            ColorPickerTopPanel.Controls.Add(settingPageBtn);
            ColorPickerTopPanel.Controls.Add(colorMarkBtn);
            ColorPickerTopPanel.Controls.Add(colorPickBtn);
            ColorPickerTopPanel.Controls.Add(minimizeBtn);
            ColorPickerTopPanel.Controls.Add(maximizeBtn);
            ColorPickerTopPanel.Controls.Add(closeBtn);
            ColorPickerTopPanel.Controls.Add(ColorPickingPageBtn);
            ColorPickerTopPanel.Dock = DockStyle.Top;
            ColorPickerTopPanel.Location = new Point(0, 0);
            ColorPickerTopPanel.Name = "ColorPickerTopPanel";
            ColorPickerTopPanel.Padding = new Padding(5);
            ColorPickerTopPanel.Size = new Size(598, 48);
            ColorPickerTopPanel.TabIndex = 7;
            ColorPickerTopPanel.Paint += ColorPickerTopPanel_Paint;
            // 
            // bookMarkBtn
            // 
            bookMarkBtn.BackColor = Color.Transparent;
            bookMarkBtn.BackgroudColor = Color.Transparent;
            bookMarkBtn.BorderColor = Color.PaleVioletRed;
            bookMarkBtn.BorderRadius1 = 10;
            bookMarkBtn.BorderSize1 = 0;
            bookMarkBtn.Dock = DockStyle.Left;
            bookMarkBtn.FlatAppearance.BorderSize = 0;
            bookMarkBtn.FlatStyle = FlatStyle.Flat;
            bookMarkBtn.ForeColor = Color.White;
            bookMarkBtn.Image = Properties.Resources.icons8_bookmark_20__2_;
            bookMarkBtn.Location = new Point(205, 5);
            bookMarkBtn.Name = "bookMarkBtn";
            bookMarkBtn.Size = new Size(50, 38);
            bookMarkBtn.TabIndex = 6;
            bookMarkBtn.TextColor = Color.White;
            bookMarkBtn.UseVisualStyleBackColor = false;
            // 
            // settingPageBtn
            // 
            settingPageBtn.BackColor = Color.Transparent;
            settingPageBtn.BackgroudColor = Color.Transparent;
            settingPageBtn.BorderColor = Color.PaleVioletRed;
            settingPageBtn.BorderRadius1 = 10;
            settingPageBtn.BorderSize1 = 0;
            settingPageBtn.Dock = DockStyle.Left;
            settingPageBtn.FlatAppearance.BorderSize = 0;
            settingPageBtn.FlatStyle = FlatStyle.Flat;
            settingPageBtn.ForeColor = Color.White;
            settingPageBtn.Image = Properties.Resources.icons8_setting_20;
            settingPageBtn.Location = new Point(155, 5);
            settingPageBtn.Name = "settingPageBtn";
            settingPageBtn.Size = new Size(50, 38);
            settingPageBtn.TabIndex = 5;
            settingPageBtn.TextColor = Color.White;
            settingPageBtn.UseVisualStyleBackColor = false;
            // 
            // colorMarkBtn
            // 
            colorMarkBtn.BackColor = Color.Transparent;
            colorMarkBtn.BackgroudColor = Color.Transparent;
            colorMarkBtn.BorderColor = Color.PaleVioletRed;
            colorMarkBtn.BorderRadius1 = 10;
            colorMarkBtn.BorderSize1 = 0;
            colorMarkBtn.Dock = DockStyle.Left;
            colorMarkBtn.FlatAppearance.BorderSize = 0;
            colorMarkBtn.FlatStyle = FlatStyle.Flat;
            colorMarkBtn.ForeColor = Color.White;
            colorMarkBtn.Image = Properties.Resources.icons8_bookmark_20;
            colorMarkBtn.Location = new Point(105, 5);
            colorMarkBtn.Name = "colorMarkBtn";
            colorMarkBtn.Size = new Size(50, 38);
            colorMarkBtn.TabIndex = 4;
            colorMarkBtn.TextColor = Color.White;
            colorMarkBtn.UseVisualStyleBackColor = false;
            // 
            // colorPickBtn
            // 
            colorPickBtn.BackColor = Color.Transparent;
            colorPickBtn.BackgroudColor = Color.Transparent;
            colorPickBtn.BorderColor = Color.PaleVioletRed;
            colorPickBtn.BorderRadius1 = 10;
            colorPickBtn.BorderSize1 = 0;
            colorPickBtn.Dock = DockStyle.Left;
            colorPickBtn.FlatAppearance.BorderSize = 0;
            colorPickBtn.FlatStyle = FlatStyle.Flat;
            colorPickBtn.ForeColor = Color.White;
            colorPickBtn.Image = Properties.Resources.icons8_color_picker_20;
            colorPickBtn.Location = new Point(55, 5);
            colorPickBtn.Name = "colorPickBtn";
            colorPickBtn.Size = new Size(50, 38);
            colorPickBtn.TabIndex = 3;
            colorPickBtn.TextColor = Color.White;
            colorPickBtn.UseVisualStyleBackColor = false;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackColor = Color.Transparent;
            minimizeBtn.BackgroudColor = Color.Transparent;
            minimizeBtn.BorderColor = Color.PaleVioletRed;
            minimizeBtn.BorderRadius1 = 10;
            minimizeBtn.BorderSize1 = 0;
            minimizeBtn.Dock = DockStyle.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Image = Properties.Resources.icons8_minimize_18;
            minimizeBtn.Location = new Point(443, 5);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(50, 38);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.TextColor = Color.White;
            minimizeBtn.UseVisualStyleBackColor = false;
            // 
            // maximizeBtn
            // 
            maximizeBtn.BackColor = Color.Transparent;
            maximizeBtn.BackgroudColor = Color.Transparent;
            maximizeBtn.BorderColor = Color.PaleVioletRed;
            maximizeBtn.BorderRadius1 = 10;
            maximizeBtn.BorderSize1 = 0;
            maximizeBtn.Dock = DockStyle.Right;
            maximizeBtn.FlatAppearance.BorderSize = 0;
            maximizeBtn.FlatStyle = FlatStyle.Flat;
            maximizeBtn.ForeColor = Color.White;
            maximizeBtn.Image = Properties.Resources.icons8_rounded_square_18;
            maximizeBtn.Location = new Point(493, 5);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(50, 38);
            maximizeBtn.TabIndex = 1;
            maximizeBtn.TextColor = Color.White;
            maximizeBtn.UseVisualStyleBackColor = false;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.BackgroudColor = Color.Transparent;
            closeBtn.BorderColor = Color.PaleVioletRed;
            closeBtn.BorderRadius1 = 10;
            closeBtn.BorderSize1 = 0;
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.ForeColor = Color.White;
            closeBtn.Image = Properties.Resources.icons8_close_18__1_;
            closeBtn.Location = new Point(543, 5);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(50, 38);
            closeBtn.TabIndex = 0;
            closeBtn.TextColor = Color.White;
            closeBtn.UseVisualStyleBackColor = false;
            // 
            // ColorPickingPageBtn
            // 
            ColorPickingPageBtn.BackColor = Color.Transparent;
            ColorPickingPageBtn.BackgroudColor = Color.Transparent;
            ColorPickingPageBtn.BorderColor = Color.PaleVioletRed;
            ColorPickingPageBtn.BorderRadius1 = 10;
            ColorPickingPageBtn.BorderSize1 = 0;
            ColorPickingPageBtn.Dock = DockStyle.Left;
            ColorPickingPageBtn.FlatAppearance.BorderSize = 0;
            ColorPickingPageBtn.FlatStyle = FlatStyle.Flat;
            ColorPickingPageBtn.ForeColor = Color.White;
            ColorPickingPageBtn.Image = Properties.Resources.icons8_color_mode_22;
            ColorPickingPageBtn.Location = new Point(5, 5);
            ColorPickingPageBtn.Name = "ColorPickingPageBtn";
            ColorPickingPageBtn.Size = new Size(50, 38);
            ColorPickingPageBtn.TabIndex = 7;
            ColorPickingPageBtn.TextColor = Color.White;
            ColorPickingPageBtn.UseVisualStyleBackColor = false;
            // 
            // ProgressBarP
            // 
            ProgressBarP.BackColor = Color.Transparent;
            ProgressBarP.Controls.Add(panel7);
            ProgressBarP.Controls.Add(panel6);
            ProgressBarP.Controls.Add(panel5);
            ProgressBarP.Dock = DockStyle.Fill;
            ProgressBarP.Location = new Point(3, 3);
            ProgressBarP.Name = "ProgressBarP";
            ProgressBarP.Size = new Size(359, 156);
            ProgressBarP.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(progressBaru3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 110);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10, 10, 10, 15);
            panel7.Size = new Size(359, 55);
            panel7.TabIndex = 2;
            // 
            // progressBaru3
            // 
            progressBaru3.CircleColor = Color.White;
            progressBaru3.Dock = DockStyle.Fill;
            progressBaru3.Location = new Point(10, 10);
            progressBaru3.Maximum = 100;
            progressBaru3.Name = "progressBaru3";
            progressBaru3.ProgressBarBackColor = Color.FromArgb(232, 245, 240);
            progressBaru3.ProgressBarColor = Color.FromArgb(65, 165, 225);
            progressBaru3.Size = new Size(339, 30);
            progressBaru3.StartPoint = 15;
            progressBaru3.TabIndex = 0;
            progressBaru3.Value = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(progressBaru2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 55);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10, 10, 10, 15);
            panel6.Size = new Size(359, 55);
            panel6.TabIndex = 1;
            // 
            // progressBaru2
            // 
            progressBaru2.CircleColor = Color.White;
            progressBaru2.Dock = DockStyle.Fill;
            progressBaru2.Location = new Point(10, 10);
            progressBaru2.Maximum = 100;
            progressBaru2.Name = "progressBaru2";
            progressBaru2.ProgressBarBackColor = Color.FromArgb(232, 245, 240);
            progressBaru2.ProgressBarColor = Color.FromArgb(105, 195, 59);
            progressBaru2.Size = new Size(339, 30);
            progressBaru2.StartPoint = 15;
            progressBaru2.TabIndex = 0;
            progressBaru2.Value = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(progressBaru1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10, 10, 10, 15);
            panel5.Size = new Size(359, 55);
            panel5.TabIndex = 0;
            // 
            // progressBaru1
            // 
            progressBaru1.CircleColor = Color.White;
            progressBaru1.Dock = DockStyle.Fill;
            progressBaru1.Location = new Point(10, 10);
            progressBaru1.Maximum = 100;
            progressBaru1.Name = "progressBaru1";
            progressBaru1.ProgressBarBackColor = Color.FromArgb(232, 245, 240);
            progressBaru1.ProgressBarColor = Color.FromArgb(255, 87, 57);
            progressBaru1.Size = new Size(339, 30);
            progressBaru1.StartPoint = 15;
            progressBaru1.TabIndex = 0;
            progressBaru1.Value = 0;
            // 
            // MainP
            // 
            MainP.BackColor = Color.White;
            MainP.BackgroundImageLayout = ImageLayout.None;
            MainP.Controls.Add(MainTabControl);
            MainP.Controls.Add(ColorPickerTopPanel);
            MainP.Dock = DockStyle.Fill;
            MainP.Location = new Point(0, 0);
            MainP.Name = "MainP";
            MainP.Size = new Size(598, 228);
            MainP.TabIndex = 9;
            MainP.Visible = false;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ColorPickingPage);
            MainTabControl.Controls.Add(settingPage);
            MainTabControl.Controls.Add(bookMarkPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.ItemSize = new Size(10, 10);
            MainTabControl.Location = new Point(0, 48);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(598, 180);
            MainTabControl.TabIndex = 12;
            // 
            // ColorPickingPage
            // 
            ColorPickingPage.Controls.Add(ProgressBarP);
            ColorPickingPage.Controls.Add(rgbMainP);
            ColorPickingPage.Controls.Add(HexColorTB);
            ColorPickingPage.Location = new Point(4, 14);
            ColorPickingPage.Name = "ColorPickingPage";
            ColorPickingPage.Padding = new Padding(3);
            ColorPickingPage.Size = new Size(590, 162);
            ColorPickingPage.TabIndex = 0;
            ColorPickingPage.UseVisualStyleBackColor = true;
            // 
            // rgbMainP
            // 
            rgbMainP.BackColor = Color.Transparent;
            rgbMainP.Controls.Add(panel10);
            rgbMainP.Controls.Add(panel9);
            rgbMainP.Controls.Add(panel8);
            rgbMainP.Dock = DockStyle.Right;
            rgbMainP.Location = new Point(362, 3);
            rgbMainP.Name = "rgbMainP";
            rgbMainP.Size = new Size(104, 156);
            rgbMainP.TabIndex = 9;
            // 
            // panel10
            // 
            panel10.Controls.Add(bluergbTB);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 110);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(10, 5, 10, 10);
            panel10.Size = new Size(104, 55);
            panel10.TabIndex = 2;
            // 
            // bluergbTB
            // 
            bluergbTB.Dock = DockStyle.Bottom;
            bluergbTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bluergbTB.Location = new Point(10, 11);
            bluergbTB.Name = "bluergbTB";
            bluergbTB.Size = new Size(84, 34);
            bluergbTB.TabIndex = 1;
            bluergbTB.TextAlign = HorizontalAlignment.Center;
            // 
            // panel9
            // 
            panel9.Controls.Add(greenrgbTB);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 55);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(10, 5, 10, 10);
            panel9.Size = new Size(104, 55);
            panel9.TabIndex = 1;
            // 
            // greenrgbTB
            // 
            greenrgbTB.Dock = DockStyle.Bottom;
            greenrgbTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greenrgbTB.Location = new Point(10, 11);
            greenrgbTB.Name = "greenrgbTB";
            greenrgbTB.Size = new Size(84, 34);
            greenrgbTB.TabIndex = 1;
            greenrgbTB.TextAlign = HorizontalAlignment.Center;
            // 
            // panel8
            // 
            panel8.Controls.Add(redrgbTB);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(10, 5, 10, 10);
            panel8.Size = new Size(104, 55);
            panel8.TabIndex = 0;
            // 
            // redrgbTB
            // 
            redrgbTB.Dock = DockStyle.Bottom;
            redrgbTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            redrgbTB.Location = new Point(10, 11);
            redrgbTB.Name = "redrgbTB";
            redrgbTB.Size = new Size(84, 34);
            redrgbTB.TabIndex = 0;
            redrgbTB.TextAlign = HorizontalAlignment.Center;
            // 
            // HexColorTB
            // 
            HexColorTB.BackColor = Color.Transparent;
            HexColorTB.Controls.Add(panel1);
            HexColorTB.Dock = DockStyle.Right;
            HexColorTB.Location = new Point(466, 3);
            HexColorTB.Name = "HexColorTB";
            HexColorTB.Padding = new Padding(5, 5, 5, 15);
            HexColorTB.Size = new Size(121, 156);
            HexColorTB.TabIndex = 11;
            HexColorTB.Paint += panel11_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(colorHexValueTB);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 5, 10, 10);
            panel1.Size = new Size(111, 158);
            panel1.TabIndex = 11;
            // 
            // colorHexValueTB
            // 
            colorHexValueTB.Dock = DockStyle.Bottom;
            colorHexValueTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colorHexValueTB.Location = new Point(10, 114);
            colorHexValueTB.Name = "colorHexValueTB";
            colorHexValueTB.Size = new Size(91, 34);
            colorHexValueTB.TabIndex = 10;
            colorHexValueTB.TextAlign = HorizontalAlignment.Center;
            // 
            // settingPage
            // 
            settingPage.BackColor = Color.White;
            settingPage.Location = new Point(4, 14);
            settingPage.Name = "settingPage";
            settingPage.Padding = new Padding(3);
            settingPage.Size = new Size(590, 162);
            settingPage.TabIndex = 1;
            // 
            // bookMarkPage
            // 
            bookMarkPage.AutoScroll = true;
            bookMarkPage.AutoScrollMinSize = new Size(8, 0);
            bookMarkPage.BackColor = Color.White;
            bookMarkPage.Location = new Point(4, 14);
            bookMarkPage.Name = "bookMarkPage";
            bookMarkPage.Padding = new Padding(3);
            bookMarkPage.Size = new Size(590, 162);
            bookMarkPage.TabIndex = 2;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.rgb__1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(598, 228);
            Controls.Add(MainP);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ColorPickerTopPanel.ResumeLayout(false);
            ProgressBarP.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            MainP.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            ColorPickingPage.ResumeLayout(false);
            rgbMainP.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            HexColorTB.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel ColorPickerTopPanel;
        private Panel ProgressBarP;
        private EllipseButton minimizeBtn;
        private EllipseButton maximizeBtn;
        private EllipseButton closeBtn;
        private Panel MainP;
        private EllipseButton settingPageBtn;
        private EllipseButton colorMarkBtn;
        private EllipseButton colorPickBtn;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel rgbMainP;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private TextBox redrgbTB;
        private Panel HexColorTB;
        private TextBox colorHexValueTB;
        private TextBox bluergbTB;
        private TextBox greenrgbTB;
        private ProgressBarU progressBaru3;
        private ProgressBarU progressBaru2;
        private ProgressBarU progressBaru1;
        private EllipseButton bookMarkBtn;
        private TabControl MainTabControl;
        private TabPage ColorPickingPage;
        private TabPage settingPage;
        private TabPage bookMarkPage;
        private Panel panel1;
        private EllipseButton ColorPickingPageBtn;
    }
}
