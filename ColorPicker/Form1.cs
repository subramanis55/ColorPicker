using System.Text.RegularExpressions;
using Timer = System.Threading.Timer;
using System.Windows.Forms;
namespace ColorPicker
{
    public partial class Form1 : Form
    {
        private int redRGBValue;
        private int blueRGBValue;
        System.Windows.Forms.Timer timer;
        System.Windows.Forms.Timer startTimer;
        Bitmap colorPickCursor = Properties.Resources.icons8_circle_100;
        List<BookMarkU> BookMarkUList=new List<BookMarkU>();
        public int RedRGBValue
        {
            set
            {
                if (0 <= value && value <= 255)
                    redrgbTB.Text = "" + value;
                else
                {
                    redrgbTB.Text = "255";
                }

            }
            get
            {
                int temp = 0;
                if (int.TryParse(redrgbTB.Text, out temp))
                {
                    return int.Parse(redrgbTB.Text);
                }
                else
                {
                    redrgbTB.Text = "255";
                    return int.Parse(redrgbTB.Text);
                }
            }
        }
        public int GreenRGBValue
        {
            set
            {
                if (0 <= value && value <= 255)
                    greenrgbTB.Text = "" + value;
                else
                {
                    greenrgbTB.Text = "255";
                }
            }
            get
            {
                int temp = 0;
                if (int.TryParse(greenrgbTB.Text, out temp))
                {
                    return int.Parse(greenrgbTB.Text);
                }
                else
                {
                    redrgbTB.Text = "255";
                    return int.Parse(greenrgbTB.Text);
                }
            }
        }
        public int BlueRGBValue
        {
            set
            {
                if (0 <= value && value <= 255)
                    bluergbTB.Text = "" + value;
                else
                {
                    bluergbTB.Text = "255";
                }
            }
            get
            {
                int temp = 0;
                if (int.TryParse(bluergbTB.Text, out temp))
                {
                    return int.Parse(bluergbTB.Text);
                }
                else
                {
                    redrgbTB.Text = "255";
                    return int.Parse(bluergbTB.Text);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            //progressBaru1.MouseMove += ProgressBaru1_MouseMove;
            redrgbTB.TextChanged += TextBoxTextChanged;
            greenrgbTB.TextChanged += TextBoxTextChanged;
            bluergbTB.TextChanged += TextBoxTextChanged;
            colorHexValueTB.KeyPress += colorHexTextBoxTextChanged;
            redrgbTB.HideSelectionChanged += Selectionchanged;
            redrgbTB.KeyPress += RGBTBKeyPress;
            bluergbTB.KeyPress += RGBTBKeyPress;
            greenrgbTB.KeyPress += RGBTBKeyPress;
            colorPickBtn.Click += ColorPickBtnClicked;
            progressBaru1.ValueChanged += ValueChanged;
            progressBaru2.ValueChanged += ValueChanged;
            progressBaru3.ValueChanged += ValueChanged;
            ColorPickerTopPanel.MouseUp += ColorPickerTopPanelMouseUp;
            ColorPickerTopPanel.MouseMove += ColorPickerTopPanelMouseMove;
            ColorPickerTopPanel.MouseDown += ColorPickerTopPanelMouseDown;
            progressBaru1.Maximum = 255;
            progressBaru2.Maximum = 255;
            progressBaru3.Maximum = 255;
            //GlobleMouseClick filter = new GlobleMouseClick();
            //Application.AddMessageFilter(filter);
            //   filter.MouseClickE += ScreenMouseClick;
          //  Application.Idle += ApplicationIdle;
            closeBtn.Click += CloseBtnClick;
            closeBtn.MouseEnter += CloseBtnMouseEnter;
            closeBtn.MouseLeave += CloseBtnMouseLeave;
            minimizeBtn.Click += MinimizeBtnClick;
            maximizeBtn.Click += MaximizeBtnClick;
            bookMarkBtn.Click += BookMarkPageClick;
            settingPageBtn.Click += SettingPageClick;
            ColorPickingPageBtn.Click += ColorPickingPageBtnClick;
            colorMarkBtn.Click += colorMarkBtnClick;
            Load += ColorPickerOnLoad;
            this.Click += Form1_Click;
        }

        private void colorMarkBtnClick(object? sender, EventArgs e)
        {

            BookMarkU obj = new BookMarkU() { ColorValue = ColorPickingPage.BackColor, Dock = DockStyle.Top };
            obj.BringToFront();
            BookMarkUList.Add(obj);
            bookMarkPage.Controls.Add(obj);
        }

        private void ColorPickingPageBtnClick(object? sender, EventArgs e)
        {
            MainTabControl.SelectedTab = ColorPickingPage;
        }

        private void SettingPageClick(object? sender, EventArgs e)
        {
            MainTabControl.SelectedTab = settingPage;
        }

        private void BookMarkPageClick(object? sender, EventArgs e)
        {
            MainTabControl.SelectedTab = bookMarkPage;
        }

        private void ColorPickerOnLoad(object? sender, EventArgs e)
        {
            redrgbTB.Text = "" + progressBaru1.Value;
            greenrgbTB.Text = "" + progressBaru2.Value;
            bluergbTB.Text = "" + progressBaru3.Value;
            startTimer = new System.Windows.Forms.Timer();
            startTimer.Interval = 1000;
            startTimer.Tick += ApplicationStart;
            startTimer.Start();
        }

        private void ApplicationStart(object? sender, EventArgs e)
        {
            MainP.Visible = true;
            MainTabControl.SizeMode = TabSizeMode.Fixed;
            MainTabControl.ItemSize = new Size(0, 1);       
            MainTabControl.SelectedTab = ColorPickingPage;
            bluergbTB.Text = "" + 200;
            startTimer.Stop();
            startTimer.Dispose();
        }

        private void CloseBtnMouseLeave(object? sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.Transparent;
        }

        private void CloseBtnMouseEnter(object? sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.FromArgb(255,10,0);

        }

        private void MaximizeBtnClick(object? sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            
        }

        private void MinimizeBtnClick(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        static bool IsValidHexColor(string hexColor)
        {
            // Regular expression pattern for a valid hexadecimal color value
            string hexPattern = @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";

            // Check if the provided string matches the pattern
            return Regex.IsMatch(hexColor, hexPattern);
        }
        private void colorHexTextBoxTextChanged(object? sender, KeyPressEventArgs e)
        {

            if(e.KeyChar==(char)Keys.Enter)
            {
                
                TextBox control = (TextBox)sender;
                control.Text = control.Text.ToUpper();
                if (IsValidHexColor(control.Text))
                {
                    Color color = ColorTranslator.FromHtml(control.Text);
                    redrgbTB.Text = "" + color.R;
                    greenrgbTB.Text = "" + color.G;
                    bluergbTB.Text = "" + color.B;
                }
                else
                {
                    control.Text="#FFFFFF";
                }
            }
                   

        }

        private Point FormPrevLocation;
        private bool isFormUp;
        private void ColorPickerTopPanelMouseDown(object? sender, MouseEventArgs e)
        {
            isFormUp = true;
            FormPrevLocation =new Point(e.X, e.Y);
        }

        private void ColorPickerTopPanelMouseMove(object? sender, MouseEventArgs e)
        {
            if (isFormUp)
            {
               this. Location = new Point(Location.X -(FormPrevLocation.X-e.X ), Location.Y -( FormPrevLocation.Y-e.Y));
            //  FormPrevLocation =this.PointToClient( new Point(e.X, e.Y));
            }
        }

        private void ColorPickerTopPanelMouseUp(object? sender, MouseEventArgs e)
        {
            isFormUp = false;
        }

        private void ApplicationIdle(object? sender, EventArgs e)
        {
            Cursor.Current = new Cursor(colorPickCursor.GetHicon());
        }

        private void Form1_Click(object? sender, EventArgs e)
        {
            int a = 10;
        }

        private void ColorPickBtnClicked(object? sender, EventArgs e)
        {
            if (timer != null && timer.Enabled == true)
            {
                timer.Stop();
                timer.Dispose();
               // Cursor.Dispose();
                Cursor.Current = Cursors.Default;
            }
            else
            {
               
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 100;
                timer.Start();
               timer.Tick += colorPickingFromScreen;

            }         
        }

        private void colorPickingFromScreen(Color color)
        {
           MainP.BackColor = color;
        }
        private void colorPickingFromScreen(object? sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(1, 1);
           
            Point cursorPosition = Cursor.Position;
            using (var g = Graphics.FromImage(bit))
            {
                g.CopyFromScreen(cursorPosition, new Point(0, 0), new Size(1, 1));
            }  
            
            Color pixelColor = bit.GetPixel(0, 0);
            ColorPickingPage.BackColor = pixelColor;

        }
        private void CloseBtnClick(object? sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ScreenMouseClick(Point p)
        {
            if (timer!=null&&timer.Enabled)
            {
                timer.Stop();
                timer.Dispose();
                Bitmap bit = new Bitmap(1, 1);
                using (var g = Graphics.FromImage(bit))
                {
                    g.CopyFromScreen(p, new Point(0, 0), new Size(1, 1));
                }
                colorPickingFromScreen(bit.GetPixel(0, 0));

            }

        }
        private void RGBTBKeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Selectionchanged(object? sender, EventArgs e)
        {
            TextBox control = (TextBox)sender;
            control.SelectionStart = control.Text.Length;
        }

       

        private void TextBoxTextChanged(object? sender, EventArgs e)
        {
            if (isThroBar == false)
            {
                TextBox control = (TextBox)sender;
                if (control.Text == "")
                    control.Text = "" + 0;
                int result = 0;
                if (int.TryParse(control.Text, out result))
                {
                    if (result > 255)
                    {
                        control.Text = "255";
                    }
                    else if (result < 0)
                    {
                        control.Text = "0";
                    }
                    else
                    {
                        control.Text = "" + result;
                    }
                }
                else
                {
                    control.Text = "0";
                }
                control.SelectionStart = control.Text.Length;
                if (sender == redrgbTB)
                    progressBaru1.Value = int.Parse(control.Text);
                if (sender == greenrgbTB)
                    progressBaru2.Value = int.Parse(control.Text);
                if (sender == bluergbTB)
                    progressBaru3.Value = int.Parse(control.Text);
            }
            else
            {
                isThroBar = false;
            }
            FormColorChange();
        }
        public void FormColorChange()
        {
            ColorPickingPage.BackColor = Color.FromArgb(progressBaru1.Value, progressBaru2.Value, progressBaru3.Value);
            colorHexValueTB .Text= ColorTranslator.ToHtml(ColorPickingPage.BackColor);
            
        }
        bool isThroBar = false;
        public void ValueChanged(object? sender, int value)
        {
            isThroBar = true;

            if (sender == progressBaru1)
            {
                redrgbTB.Text = "" + value;
            }
            if (sender == progressBaru2)
            {
                greenrgbTB.Text = "" + value;
            }
            if (sender == progressBaru3)
            {
                bluergbTB.Text = "" + value;
            }
            
        }
        private void ProgressBaru1_MouseMove(object? sender, MouseEventArgs e)
        {
            //label1.Text = "" + progressBaru1.Value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //progressBaru1.Value = int.Parse(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ColorPickerTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class GlobleMouseClick : IMessageFilter
    {

        public delegate void GlobleEventHandler(Point p);
        public event GlobleEventHandler MouseClickE;
        public bool PreFilterMessage(ref Message m)
        {
            const int button = 0x0201;
            if (m.Msg == button)
            {
                Point point = Cursor.Position;
                MouseClickE?.Invoke(point);
            }
            return false;
        }
    }

}
