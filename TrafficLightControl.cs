using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace YourAppNamespace
{
    public enum SignalState
    {
        Off,
        Red,
        Yellow,
        Green
    }

    public class TrafficLightControl : Control
    {
        private SignalState _state = SignalState.Off;

        [Category("Appearance")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SignalState State
        {
            get => _state;
            set
            {
                if (_state != value)
                {
                    _state = value;
                    Invalidate();
                }
            }
        }

        public TrafficLightControl()
        {
            DoubleBuffered = true;
            Size = new Size(80, 220);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using var bodyBrush = new SolidBrush(Color.FromArgb(45, 45, 45));
            using var borderPen = new Pen(Color.Black, 2);

            var bodyRect = new Rectangle(5, 5, Width - 10, Height - 10);
            e.Graphics.FillRectangle(bodyBrush, bodyRect);
            e.Graphics.DrawRectangle(borderPen, bodyRect);

            int lampDiameter = Math.Min(Width - 24, (Height - 40) / 3);
            int x = (Width - lampDiameter) / 2;

            Rectangle redRect = new Rectangle(x, 12, lampDiameter, lampDiameter);
            Rectangle yellowRect = new Rectangle(x, 20 + lampDiameter, lampDiameter, lampDiameter);
            Rectangle greenRect = new Rectangle(x, 28 + lampDiameter * 2, lampDiameter, lampDiameter);

            DrawLamp(e.Graphics, redRect,
                _state == SignalState.Red ? Color.Red : Color.FromArgb(70, 20, 20));

            DrawLamp(e.Graphics, yellowRect,
                _state == SignalState.Yellow ? Color.Yellow : Color.FromArgb(90, 90, 20));

            DrawLamp(e.Graphics, greenRect,
                _state == SignalState.Green ? Color.Lime : Color.FromArgb(20, 70, 20));
        }

        private static void DrawLamp(Graphics g, Rectangle rect, Color color)
        {
            using var brush = new SolidBrush(color);
            using var pen = new Pen(Color.Black, 2);

            g.FillEllipse(brush, rect);
            g.DrawEllipse(pen, rect);

            var highlight = new Rectangle(
                rect.X + rect.Width / 5,
                rect.Y + rect.Height / 5,
                rect.Width / 4,
                rect.Height / 4);

            using var highlightBrush = new SolidBrush(Color.FromArgb(100, Color.White));
            g.FillEllipse(highlightBrush, highlight);
        }
    }
}