using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Controle_de_Estoque.Controls
{
    public partial class TextBox1 : UserControl
    {
        private Color borderColor = Color.DimGray;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private int borderRadius = 0;

        public TextBox1()
        {
            InitializeComponent();
        }

        public Color BorderColor 
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize 
        {
            get 
            {
                return borderSize; 
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public bool UnderlineStyle 
        {
            get
            {
                return underlineStyle;
            }
            set
            {
                underlineStyle = value;
                this.Invalidate();
            }
         }

        [Category("TextBox Categoria")]
        public bool PassWordChar
        {
            get { return textBox2.UseSystemPasswordChar; }
            set { textBox2.UseSystemPasswordChar = value; }
        }

        [Category("TextBox Categoria")]
        public bool Multiline
        {
            get { return textBox2.Multiline; }
            set { textBox2.Multiline = value; }
        }

        [Category("TextBox Categoria")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox2.BackColor = value;
            }
        }

        [Category("TextBox Categoria")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor; 
            }
            set
            {
                base.ForeColor = value;
                textBox2.ForeColor = value;
            }
        }

        [Category("TextBox Categoria")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox2.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category ("TextBox Categoria")]
        public string Texts
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }

        }

        [Category("TextBox Categoria")]
        public int BorderRasdius 
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothsize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothsize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    if (underlineStyle)
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        graph.SmoothingMode = SmoothingMode.None;
                    }
                    else
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (underlineStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox2.ClientRectangle, borderRadius - borderSize);
                textBox2.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox2.ClientRectangle, borderSize*2);
                textBox2.Region = new Region(pathTxt);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox2.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox2.Multiline = true;
                textBox2.MinimumSize = new Size(0, txtHeight);
                textBox2.Multiline = false;

                this.Height = textBox2.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void TextBox1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
