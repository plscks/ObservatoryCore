﻿using Observatory.Framework;

namespace Observatory.UI
{
    public partial class NotificationForm : Form
    {
        private Color _color;
        private readonly Guid _guid;
        private readonly System.Timers.Timer _timer;
        private bool _defaultPosition = true;
        private Point _originalLocation;
        private bool _transparent = true;

        protected override bool ShowWithoutActivation => true;
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_LAYERED = 0x80000;
                const int WS_EX_TRANSPARENT = 0x20;
                const int WS_EX_TOPMOST = 0x8;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_LAYERED;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                cp.ExStyle |= WS_EX_TOPMOST;
                return cp;
            }
        }
        protected override void WndProc(ref Message m)
        {

            switch (m.Msg)
            {
                case DwmHelper.WM_DWMCOMPOSITIONCHANGED:
                    if (System.Environment.OSVersion.Version.Major >= 6 && DwmHelper.IsCompositionEnabled())
                    {
                        var policy = DwmHelper.DWMNCRENDERINGPOLICY.Enabled;
                        DwmHelper.WindowSetAttribute(Handle, DwmHelper.DWMWINDOWATTRIBUTE.NCRenderingPolicy, (int)policy);
                        DwmHelper.WindowBorderlessDropShadow(Handle, 2);
                        m.Result = IntPtr.Zero;
                    }
                    break;
                case 0x0084:
                    m.Result = (IntPtr)(-1);
                    return;
                default:
                    break;
            }
            base.WndProc(ref m);
        }

        public NotificationForm(Guid guid, NotificationArgs args)
        {
            _guid = guid;
            _color = Color.FromArgb((int)Properties.Core.Default.NativeNotifyColour);
            _transparent = Properties.Core.Default.NativeNotifyTransparent;
            CreationTime = DateTime.Now;
            InitializeComponent();

            Title.Paint += DrawText;
            Body.Paint += DrawText;

            if (!Properties.Core.Default.NativeNotifyTransparent)
            {
                BackColor = Color.FromArgb(25, 30, 30);
                Title.BackColor = BackColor;
                Body.BackColor = BackColor;
            }

            if (System.Environment.OSVersion.Version.Major >= 6 && DwmHelper.IsCompositionEnabled())
            {
                if (Environment.OSVersion.Version.Major > 6)
                {
                    DwmHelper.Windows10EnableBlurBehind(Handle);
                }
                else
                {
                    DwmHelper.WindowEnableBlurBehind(Handle);
                }
            }

            var scale = Properties.Core.Default.NativeNotifyScale / 100.0f;
            Scale(new SizeF(scale, scale));

            var fontScale = Properties.Core.Default.NativeNotifyFontScale / 100.0f;

            Title.ForeColor = _color;
            Title.Text = args.Title;
            Title.Font = new Font(Properties.Core.Default.NativeNotifyFont, 18 * scale * fontScale);
            Body.ForeColor = _color;
            Body.Text = args.Detail;
            Body.Font = new Font(Properties.Core.Default.NativeNotifyFont, 14 * scale * fontScale);
            Body.Location = new Point(
                Body.Location.X, 
                (int)Math.Round(Body.Location.Y + (Title.Height * fontScale - Title.Height)));
            Paint += DrawBorder;

            AdjustPosition(args.XPos / 100, args.YPos / 100);

            _timer = new();
            _timer.Elapsed += CloseNotification;
            if (args.Timeout != 0)
            {
                _timer.Interval = args.Timeout == -1 ? Properties.Core.Default.NativeNotifyTimeout : args.Timeout;
                _timer.Start();
            }
        }

        private void NotificationForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public DateTime CreationTime { get; private init; }

        public void Update(NotificationArgs notificationArgs)
        {
            // Catch Cross-thread access and invoke
            try
            {
                Title.Text = notificationArgs.Title;
                Body.Text = notificationArgs.Detail;
            }
            catch
            {
                try
                {
                    Invoke(() =>
                    {
                        Title.Text = notificationArgs.Title;
                        Body.Text = notificationArgs.Detail;
                    });
                }
                catch (Exception ex)
                {
                    throw new Exception("Notification Update Failure, please inform Vithigar. Details: " + ex.Message);
                }
            }
        }

        private void AdjustPosition(double x = -1.0, double y = -1.0)
        {
            int screen = Properties.Core.Default.NativeNotifyScreen;
            int corner = Properties.Core.Default.NativeNotifyCorner;
            Rectangle screenBounds;

            if (screen == -1 || screen > Screen.AllScreens.Length)
                if (Screen.AllScreens.Length == 1)
                    screenBounds = Screen.GetBounds(this);
                else
                    screenBounds = Screen.PrimaryScreen.Bounds;
            else
                screenBounds = Screen.AllScreens[screen].Bounds;

            if (x >= 0 && y >= 0)
            {
                _defaultPosition = false;
                int xLocation = Convert.ToInt32(screenBounds.Width * x);
                int yLocation = Convert.ToInt32(screenBounds.Height * y);
                Location = Point.Add(screenBounds.Location, new Size(xLocation, yLocation));
            }
            else
            {
                _defaultPosition = true;
                switch (corner)
                {
                    default:
                    case 0: // Bottom Right
                        Location = Point.Add(
                            new Point(screenBounds.Right, screenBounds.Bottom),
                            new Size(-(Width + 50), -(Height + 50)));
                        break;
                    case 1: // Bottom Left
                        Location = Point.Add(
                            new Point(screenBounds.Left, screenBounds.Bottom),
                            new Size(50, -(Height + 50)));
                        break;
                    case 2: // Top Right
                        Location = Point.Add(
                            new Point(screenBounds.Right, screenBounds.Top),
                            new Size(-(Width + 50), 50));
                        break;
                    case 3: // Top Left
                        Location = Point.Add(
                            new Point(screenBounds.Left, screenBounds.Top),
                            new Size(50, 50));
                        break;
                    case 4: // Top
                        Location = Point.Add(
                            new Point(screenBounds.Right / 2, screenBounds.Top),
                            new Size(-Width / 2, 50));
                        break;
                    case 5: // Bottom
                        Location = Point.Add(
                            new Point(screenBounds.Right / 2, screenBounds.Bottom),
                            new Size(-Width / 2, -(Height + 50)));
                        break;
                    case 6: // Left
                        Location = Point.Add(
                            new Point(screenBounds.Left, screenBounds.Bottom / 2),
                            new Size(50, -(Height) / 2));
                        break;
                    case 7: // Right
                        Location = Point.Add(
                            new Point(screenBounds.Right, screenBounds.Bottom / 2),
                            new Size(-(Width + 50), -(Height) / 2));
                        break;
                }
                _originalLocation = new Point(Location.X, Location.Y);
            }
        }

        private void DrawBorder(object? sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(_color))
            {
                pen.Width = 6;
                e.Graphics.DrawLine(pen, 0, 0, Width, 0);
                e.Graphics.DrawLine(pen, 0, 0, 0, Height);
                e.Graphics.DrawLine(pen, 0, Height, Width, Height);
                e.Graphics.DrawLine(pen, Width, 0, Width, Height);
            }
        }



        private void DrawText(object? sender, PaintEventArgs e)
        {
            if (sender != null)
            {
                var label = (Label)sender;
                if (_transparent)
                    e.Graphics.Clear(Color.FromArgb(64, 64, 64));
                using (var sf = new StringFormat())
                using (var brush = new SolidBrush(label.ForeColor))
                {
                    sf.Alignment = sf.LineAlignment = StringAlignment.Near;
                    // Transparency breaks antialiasing :(
                    e.Graphics.TextRenderingHint = _transparent
                        ? System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
                        : System.Drawing.Text.TextRenderingHint.SystemDefault;
                    e.Graphics.DrawString(label.Text, label.Font, brush, label.ClientRectangle, sf);
                }
                
            }
        }

        public Guid Guid { get => _guid; }

        public void AdjustOffset(bool increase)
        {
            if (_defaultPosition)
            {
                if (increase || Location != _originalLocation)
                {
                    var corner = Properties.Core.Default.NativeNotifyCorner;

                    if ((corner >= 2 && increase) || (corner <= 1 && !increase))
                    {
                        Location = new Point(Location.X, Location.Y + Height);
                    }
                    else
                    {
                        Location = new Point(Location.X, Location.Y - Height);
                    }
                }
            }
        }

        private void CloseNotification(object? sender, System.Timers.ElapsedEventArgs e)
        {
            // Catch Cross-thread access and invoke
            try
            {
                Close();
            }
            catch
            {
                try
                {
                    Invoke(() => Close());
                }
                catch (Exception ex)
                {
                    throw new Exception("Notification Close Failure, please inform Vithigar. Details: " + ex.Message);
                }
            }

            _timer.Stop();
            _timer.Dispose();
        }
    }
}
