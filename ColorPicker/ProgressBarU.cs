using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public delegate void ProgessBarHandler(object sender, int e);

    public partial class ProgressBarU : UserControl
    {
        private int circleRadius;
        private Color circleColor = Color.White;
        private Color progressBarColor = Color.DodgerBlue;
        private int startPoint = 0;
        private int endPoint = 0;
        private int value = 1;
        private int maximum = 100;
        private Color progressBarBackColor = Color.FromArgb(232, 245, 240);
      
        public event ProgessBarHandler ValueChanged;
        public int Value
        {
            set
            {
                if (0 <= value && value <= maximum)
                {
                    this.value = value;
                    StartPoint = (int)(((float)value / (float)maximum) * (float)(Width - Height)) + circleRadius;                 
                }
                
            }
            get
            {
                return value;
            }
        }
        public int Maximum
        {
            set
            {
                this.maximum = value;

                Value = 0;

            }
            get
            {
                return maximum;
            }
        }

        public int StartPoint
        {
            set
            {
                startPoint = value;
                
                Invalidate();
            }
            get
            {
                return startPoint;
            }
        }

        public Color CircleColor
        {
            set
            {
                circleColor = value;
                Invalidate();
            }
            get
            {
                return circleColor;
            }
        }
        public Color ProgressBarBackColor
        {
            set
            {
                progressBarBackColor = value;
                Invalidate();
            }
            get
            {
                return progressBarBackColor;
            }
        }

        public Color ProgressBarColor
        {
            set
            {
                progressBarColor = value;
                Invalidate();
            }
            get
            {
                return progressBarColor;
            }
        }

        public ProgressBarU()
        {
            InitializeComponent();
            Resize += ProgressBarUResize;
            MouseMove += ProgressBarUMouseMove;
            MouseUp += ProgressBarUMouseUp;
            MouseDown += ProgressBarUMouseDown;
            MouseClick += ProgressBarUMouseClick;
            Load += ProgressBarULoad;
            ProgressBarUResize(this, new EventArgs());
            DoubleBuffered = true;
            Invalidate();
        }

        private void ProgressBarULoad(object? sender, EventArgs e)
        {
            circleRadius = Height / 2;
            startPoint = circleRadius;
            value = Maximum/2;
            Invalidate();
        }

        private Point prevPoint;
        private bool isUpBar;
        private void ProgressBarUMouseClick(object? sender, MouseEventArgs e)
        {
            Point point = this.PointToClient(Cursor.Position);
            if (circleRadius <= point.X && Width - circleRadius >= point.X)
            {
                startPoint = point.X;
                value = (int)((float)(startPoint - circleRadius) / (float)(Width - Height) * (float)maximum);
               
               
            }
            else if(circleRadius > point.X)
            {
                startPoint = circleRadius;
                value = 0;
            }
            else
            {
                startPoint = Width-circleRadius;
                value = 255;
            }
            ValueChanged?.Invoke(this, this.value);
            Invalidate();
        }
        private void ProgressBarUMouseDown(object? sender, MouseEventArgs e)
        {
            prevPoint = new Point(e.X, e.Y);
            isUpBar = true;
        }

        private void ProgressBarUMouseUp(object? sender, MouseEventArgs e)
        {

            isUpBar = false;
            Invalidate();

        }

        private void ProgressBarUMouseMove(object? sender, MouseEventArgs e)
        {
            
            Point point = this.PointToClient(Cursor.Position);
            if ((startPoint - circleRadius) <= point.X && point.X <= (startPoint + circleRadius))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
            if(isUpBar)
            {
                if (startPoint - (prevPoint.X - e.X) >= circleRadius && startPoint - (prevPoint.X - e.X) <= (Width - circleRadius))
                {
                    startPoint = startPoint - (prevPoint.X - e.X);
                    this.value = (int)((float)(startPoint - circleRadius) / (float)(Width - Height) * (float)maximum);
                   prevPoint = new Point(e.X, e.Y);
                    ValueChanged?.Invoke(this, this.value);
                    Invalidate();
                }
                //else if (circleRadius > startPoint - (prevPoint.X - e.X))
                //{
                //    startPoint = circleRadius;
                //    value = 0;
                //}
                //else
                //{
                //    startPoint = Width - circleRadius;
                //    value = 255;
                //}                       
                //Invalidate();
            }
           

        }

        private void ProgressBarUResize(object? sender, EventArgs e)
        {
            circleRadius = Height / 2;
            startPoint = circleRadius;
            Value = 0;
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 3, Height - 5, Height - 5, 90, 180);
            path.AddArc(startPoint - circleRadius - 1, 3, Height - 5, Height - 5, 270, 180);
            path.CloseFigure();
            GraphicsPath pathWhite = new GraphicsPath();
            pathWhite.StartFigure();
            pathWhite.AddArc(0, 3, Height - 5, Height - 5, 90, 180);
            pathWhite.AddArc(Width - Height, 3, Height - 5, Height - 5, 270, 180);
            pathWhite.CloseFigure();
            // this.Region=new Region(path);
            using (SolidBrush progressBarBrush = new SolidBrush(progressBarColor))
            {
                using (SolidBrush circleBrush = new SolidBrush(circleColor))
                {
                    g.FillPath(new SolidBrush(progressBarBackColor), pathWhite);
                    // g.DrawPath(new Pen(Color.Black,1), path);
                    g.FillPath(progressBarBrush, path);
                    // g.FillRectangle(progressBarBrush, 0, 0, startPoint, Height);
                    g.FillEllipse(circleBrush, startPoint - circleRadius, 0, circleRadius * 2, circleRadius * 2);
                    //  g.DrawEllipse(new Pen(Color.Black,2), startPoint - circleRadius+2, 2, circleRadius * 2-2, circleRadius * 2 -2);
                }
            }

        }
    }
}
