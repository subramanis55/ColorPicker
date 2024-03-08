using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class BookMarkU : UserControl
    {
        private Color color=Color.White;
        public Color ColorValue
        {
            
            get
            {
                return color;
            }
            set
            {
                HexValueLB.Text = ColorTranslator.ToHtml(value);
                
                RGBValueLB.Text=value.R+","+value.G+","+value.B;
                //ColorP.BackColor = value;
                color = value;
                ColorP.Invalidate();
            }
        }

        public BookMarkU()
        {
            InitializeComponent();
            ColorP.Paint += ColorPPaint;
            HexValueLB.MouseDown += label1_MouseDown;
            HexValueLB.MouseMove += label1_MouseMove;
            HexValueLB.MouseUp += label1_MouseUp;
            HexValueLB.DragEnter += Label1_DragEnter;
            HexValueLB.DragDrop += Label1_DragDrop;

        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Control control=(Control)sender;
            if (e.Button == MouseButtons.Left)
            {
                control.DoDragDrop(control.Text, DragDropEffects.Copy);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                control.DoDragDrop(control.Text, DragDropEffects.Copy);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            if (e.Button == MouseButtons.Left)
            {
                control.DoDragDrop(control.Text, DragDropEffects.Copy);
            }
        }
        private void Label1_DragEnter(object sender, DragEventArgs e)
        {
            Control control = (Control)sender;
           
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy; // Allow the drop
            }
            else
            {
                e.Effect = DragDropEffects.None; // Don't allow the drop
            }
        }

        private void Label1_DragDrop(object sender, DragEventArgs e)
        {
            Control control = (Control)sender;
            string droppedText = (string)e.Data.GetData(DataFormats.Text);
            control.Text = droppedText;
        }
        public GraphicsPath GetPath() {
            int width = ColorP.Height - 1;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(ColorP.Width / 2 - (width / 2), 0, 5, 5, 180, 90);
            path.AddArc(ColorP.Width / 2 + (width / 2)-5, 0, 5, 5, 270, 90);
            path.AddArc(ColorP.Width / 2 + (width / 2) - 5, width - 5, 5, 5, 0, 90);
            path.AddArc(ColorP.Width / 2 - (width / 2), width-5, 5, 5, 90, 90);
           
            path.CloseFigure();
            return path;
        }
        private void ColorPPaint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
           using(SolidBrush b=new SolidBrush(color)) {
                // e.Graphics.FillEllipse(b, ColorP.Width / 2 - (ColorP.Height / 2), 1, ColorP.Height-1, ColorP.Height - 1);
                e.Graphics.FillPath(b,GetPath());
            }
        }
    }
}
