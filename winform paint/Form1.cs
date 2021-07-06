using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_paint
{
    public partial class Form1 : Form
    {
        IFactory FigureFactory { get; set; }
        public Form1()
        {
            InitializeComponent();
            List<string> figures = new List<string> { "TriAngle", "Circle", "Rectangle" };
            figureCombobox.Items.AddRange(figures.ToArray());
            figureCombobox.SelectedIndex = 2;
        }
        List<IFigure> Figures = new List<IFigure>();


        interface IFigure
        {
            Point Point { get; set; }
            Size Size { get; set; }
            Color Color { get; set; }
            bool isFilled { get; set; }
        }

        class Rectangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool isFilled { get; set; }
        }

        class TriAngle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool isFilled { get; set; }
        }


        class Circle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool isFilled { get; set; }
        }

        interface IFactory
        {
            IFigure GetFigure();
        }

        class CircleFactory : IFactory
        {
            public IFigure GetFigure()
            {
                return new Circle();
            }
        }

        class RectangleFactory : IFactory
        {
            public IFigure GetFigure()
            {
                return new Rectangle();
            }
        }

        class TriAngleFactory : IFactory
        {
            public IFigure GetFigure()
            {
                return new TriAngle();
            }
        }
        public Color FigureColor { get; set; }






        private void selectBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FigureColor = colorDialog.Color;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (FigureFactory.GetFigure() is Rectangle rect)
            {
                if (fillRadiobtn.Checked)
                {
                    rect.Color = FigureColor;
                    rect.Point = e.Location;
                    rect.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    rect.isFilled = true;
                    Figures.Add(rect);
                }
                else
                {
                    rect.Color = FigureColor;
                    rect.Point = e.Location;
                    rect.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    rect.isFilled = false;
                    Figures.Add(rect);
                }
            }

            else if (FigureFactory.GetFigure() is TriAngle triAngle)
            {
                if (fillRadiobtn.Checked)
                {
                    triAngle.Color = FigureColor;
                    triAngle.Point = e.Location;
                    triAngle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    triAngle.isFilled = true;
                    Figures.Add(triAngle);
                }
                else
                {
                    triAngle.Color = FigureColor;
                    triAngle.Point = e.Location;
                    triAngle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    triAngle.isFilled = false;
                    Figures.Add(triAngle);
                }
            }
            else if (FigureFactory.GetFigure() is Circle circle)
            {
                if (fillRadiobtn.Checked)
                {
                    circle.Color = FigureColor;
                    circle.Point = e.Location;
                    circle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    circle.isFilled = true;
                    Figures.Add(circle);
                }
                else
                {
                    circle.Color = FigureColor;
                    circle.Point = e.Location;
                    circle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    circle.isFilled = false;
                    Figures.Add(circle);
                }
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(FigureColor, 3);
            SolidBrush brush = new SolidBrush(FigureColor);

            using (var a = e.Graphics)
            {
                foreach (var item in Figures)
                {
                    if (item is Rectangle rect)
                    {
                        if (rect.isFilled)
                        {
                            a.FillRectangle(brush, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                        else
                        {
                            a.DrawRectangle(pen, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }

                    }
                    else if (item is Circle circle)
                    {
                        if (circle.isFilled)
                        {
                            a.FillEllipse(brush, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                        }
                        else
                        {
                            a.DrawEllipse(pen, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                        }
                    }
                    else if (item is TriAngle triAngle)
                    {
                        Point top = new Point(triAngle.Point.X + 100, triAngle.Point.Y);
                        Point right = new Point(triAngle.Point.X + 100, triAngle.Point.Y + 100);
                        Point left = new Point(triAngle.Point.X, triAngle.Point.Y + 100);

                        PointF[] Pointss =
                                 {
                                        top,
                                       right,
                                     left,
                                    };
                        if (triAngle.isFilled)
                        {
                            e.Graphics.FillPolygon(brush, Pointss);
                        }
                        else
                        {


                            e.Graphics.DrawPolygon(pen, Pointss);
                        }
                    }
                }

            }
        }

        private void figureCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = figureCombobox.SelectedItem.ToString();
            if (item == "TriAngle")
            {
                FigureFactory = new TriAngleFactory();
            }
            else if (item == "Rectangle")
            {
                FigureFactory = new RectangleFactory();
            }
            else if (item == "Circle")
            {
                FigureFactory = new CircleFactory();
            }
        }
    }
}
