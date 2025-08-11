using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;

namespace Figures_project
{
    public enum Figure_Types {Ellipse, Rectangle, Polygon, Line, Curve, ClosedCurve, BizeCurve, Unknown};
    public abstract class BaseFigure
    {
        protected Figure_Types ft;
        protected SolidBrush brush;
        protected Size size;
        protected Pen pen;
        protected Point lefttop;
        protected Point[] points;

        public BaseFigure()
        {
            Set_FigureType(Figure_Types.Ellipse);
            Set_Dimention(100, 100, 20, 20);
            Set_Pen(Color.Black, 1);
            Set_Brush(Color.White);
            points = new Point[0];
        }

        public BaseFigure(Figure_Types figtype, int x, int y, int w, int h, Color pc, int th, Color bc): this()
        {
            Set_FigureType(figtype);
            Set_Dimention(x, y, w, h);
            Set_Pen(pc, th);
            Set_Brush(bc);
        }

        public BaseFigure(int x, int y, int w, int h, Color pc, int th, Color bc) : this()
        {
            Set_Dimention(x, y, w, h);
            Set_Pen(pc, th);
            Set_Brush(bc);
        }

        public BaseFigure(string[] lines, Color pc, int th, Color bc) : this ()
        {
            Set_Points(lines);
            Set_Pen(pc, th);
            Set_Brush(bc);
        }

        public BaseFigure(Point[] pp, Color pc, int th, Color bc) : this()
        {
            Set_Points(pp);
            Set_Pen(pc, th);
            Set_Brush(bc);
        }

        public BaseFigure(Figure_Types figtype, Point[] pp, Color pc, int th, Color bc): this()
        {
            Set_Points(pp);
            Set_Pen(pc, th);
            Set_Brush(bc);
        }

        public BaseFigure(XmlNode node) : this()
        {
            Set_XML_Node(node);
        }


        //СЕТЕРЫ


        public void Set_Pos(int x, int y) { lefttop = new Point(x, y); }
        public void Set_Size(int w, int h) { size = new Size(w, h); }
        public void Set_Dimention(int x, int y, int w, int h) { lefttop = new Point(x, y); size = new Size(w, h); }
        public void Set_Pen(Color pc, int th) { pen = new Pen(pc, th); }
        public void Set_Brush(Color bc) { brush = new SolidBrush(bc); }
        public void Set_Points(Point[] pp) { points = new Point[0]; }
        public void Set_FigureType(Figure_Types figtype) { ft = figtype; }
        public void Set_Points(string[] lines)
        {
            int actual_i = 0;
            char[] sep = { '|' };
            points = new Point[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] coords = lines[i].Split(sep, 2, StringSplitOptions.RemoveEmptyEntries);
                if (coords.Length == 2)
                {
                    try
                    {
                        int x = Convert.ToInt32(coords[0]);
                        int y = Convert.ToInt32(coords[1]);
                        points[actual_i] = new Point(x, y);
                        actual_i++;
                    }
                    catch
                    {

                    }
                }
            }
            Array.Resize(ref points, actual_i);
        }

        public void Set_XML_Node(XmlNode node)
        {
            int x = 0;
            int y = 0;
            int w = 0;
            int h = 0;
            Color pen_color = Color.Empty;
            int pen_th = 1;
            Color brush_color = Color.Empty;
            List<Point> points_list = new List<Point>();

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.Name == "lefttop")
                {
                    x = Convert.ToInt32(child.Attributes.GetNamedItem("X").Value);
                    y = Convert.ToInt32(child.Attributes.GetNamedItem("Y").Value);
                    Set_Pos(x,y);
                }
                else if (child.Name == "Size")
                {
                    w = Convert.ToInt32(child.Attributes.GetNamedItem("Width").Value);
                    h = Convert.ToInt32(child.Attributes.GetNamedItem("Height").Value);
                    Set_Size(w, h);
                }

                else if (child.Name == "Pen")
                {
                    pen_color = Color.FromArgb(Convert.ToInt32(child.InnerText, 16));
                    pen_th = Convert.ToInt32(child.Attributes.GetNamedItem("Thickness").Value);
                    Set_Pen(pen_color, pen_th);
                }

                else if (child.Name == "Brush")
                {
                    brush_color = Color.FromArgb(Convert.ToInt32(child.InnerText, 16));
                    Set_Brush(brush_color);
                }

                else if (child.Name == "Points")
                {
                    foreach (XmlNode points in child.ChildNodes)
                    {
                        if (points.Name == "Point")
                        {
                            foreach (XmlNode point_node in points.ChildNodes)
                            {
                                if (point_node.Name == "X")
                                { x = Convert.ToInt32(point_node.InnerText); }
                                if (point_node.Name == "Y")
                                { y = Convert.ToInt32(point_node.InnerText); }
                            }
                            points_list.Add(new Point(x, y));
                        }
                    }
                    Set_Points(points_list.ToArray());
                }
            }
        }


        //ГЕТЕРЫ


        public XmlNode Get_XML_Node(XmlDocument xml)
        {
            XmlNode node = xml.CreateElement("Figure");
            XmlAttribute attr = xml.CreateAttribute("Type");
            attr.Value = Get_Figure_Type().ToString();
            node.Attributes.Append(attr);
            XmlNode childnode;

            if (attr.Value == "Ellipse" || attr.Value == "Rectangle")
            {
                childnode = xml.CreateElement("lefttop");
                attr = xml.CreateAttribute("X");
                attr.Value = lefttop.X.ToString();
                childnode.Attributes.Append(attr);
                attr = xml.CreateAttribute("Y");
                attr.Value = lefttop.Y.ToString();
                childnode.Attributes.Append(attr);
                node.AppendChild(childnode);

                childnode = xml.CreateElement("Size");
                attr = xml.CreateAttribute("Width");
                attr.Value = size.Width.ToString();
                childnode.Attributes.Append(attr);

                attr = xml.CreateAttribute("Height");
                attr.Value = size.Height.ToString();
                childnode.Attributes.Append(attr);
                node.AppendChild(childnode);
            }

            childnode = xml.CreateElement("Pen");
            childnode.InnerText = pen.Color.ToArgb().ToString("x8");
            attr = xml.CreateAttribute("Thickness");
            attr.Value = pen.Width.ToString();
            childnode.Attributes.Append(attr);
            node.AppendChild(childnode);

            childnode = xml.CreateElement("Brush");
            childnode.InnerText = brush.Color.ToArgb().ToString("x8");
            node.AppendChild(childnode);

            XmlNode points_node = xml.CreateElement("Points");
            if (points != null)
            {
                foreach (Point p in points)
                {
                    XmlNode point_node = xml.CreateElement("Point");
                    XmlAttribute attrib = xml.CreateAttribute("X");
                    attrib.Value = p.X.ToString();
                    point_node.Attributes.Append(attrib);
                    attrib = xml.CreateAttribute("Y");
                    attrib.Value = p.Y.ToString();
                    point_node.Attributes.Append(attrib);

                    points_node.AppendChild(point_node);
                }
            }
            node.AppendChild(points_node);

            return node;
        }

        public Point[] Get_Points() { return points;}
        public Point Get_Lefttop() { return lefttop; }
        public Size Get_Size() { return size; }
        public Pen Get_Pen() { return pen; }
        public SolidBrush Get_Brush() { return brush; }
        public Figure_Types Get_Figure_Type() {return Figures.Get_Figure_Type(GetType());}


        // РИСОВАНИЕ    
        protected abstract void Draw_Figure(Graphics g);
        public void Draw(Graphics g)
        {
            Draw_Figure(g);
        }

        ~BaseFigure() {}
    }



        //КЛАССЫ ФИГУР  

    public class Figure_Ellipse : BaseFigure
    {
        public Figure_Ellipse(int x, int y, int w, int h, Color pc, int th, Color bc) : base(x, y, w, h, pc, th, bc){ }
        public Figure_Ellipse(XmlNode node) : base(node){ }

        protected override void Draw_Figure(Graphics g)
        {
            g.FillEllipse(brush, new Rectangle(lefttop, size));
            g.DrawEllipse(pen, new Rectangle(lefttop, size));
        }
    }

    public class Figure_Rectangle : BaseFigure
    {
        public Figure_Rectangle(int x, int y, int w, int h, Color pc, int th, Color bc) : base(x, y, w, h, pc, th, bc){ }
        public Figure_Rectangle(XmlNode node) : base(node) { }
        protected override void Draw_Figure(Graphics g)
        {
            g.FillRectangle(brush, new Rectangle(lefttop, size));
            g.DrawRectangle(pen, new Rectangle(lefttop, size));
        }
    }

    public class Figure_Polygon : BaseFigure
    {
        public Figure_Polygon(string[] lines, Color pc, int th, Color bc) : base(lines, pc, th, bc) { }
        public Figure_Polygon(Point[] pp, Color pc, int th, Color bc) : base(pp, pc, th, bc) { }
        public Figure_Polygon(XmlNode node) : base(node) { }
        protected override void Draw_Figure(Graphics g)
        {
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }
    }

    public class Figure_Lines : BaseFigure
    {
        public Figure_Lines(string[] lines, Color pc, int th, Color bc) : base(lines, pc, th, bc) { }
        public Figure_Lines(Point[] pp, Color pc, int th, Color bc) : base(pp, pc, th, bc) { }
        public Figure_Lines(XmlNode node) : base(node) { }
        protected override void Draw_Figure(Graphics g)
        {
            g.DrawLines(pen, points);
        }
    }

    public class Figure_Curve : BaseFigure
    {
        public Figure_Curve(string[] lines, Color pc, int th, Color bc) : base(lines, pc, th, bc) { }
        public Figure_Curve(Point[] pp, Color pc, int th, Color bc) : base(pp, pc, th, bc) { }
        public Figure_Curve(XmlNode node) : base(node) { }
        protected override void Draw_Figure(Graphics g)
        {
            g.DrawCurve(pen, points);
        }
    }

    public class Figure_ClosedCurve : BaseFigure
    {
        public Figure_ClosedCurve(string[] lines, Color pc, int th, Color bc) : base(lines, pc, th, bc) { }
        public Figure_ClosedCurve(Point[] pp, Color pc, int th, Color bc) : base(pp, pc, th, bc) { }
        public Figure_ClosedCurve(XmlNode node) : base(node) { }
        protected override void Draw_Figure(Graphics g)
        {
            g.FillClosedCurve(brush, points);
            g.DrawClosedCurve(pen, points);
        }
    }

    public class Figure_BizeCurve : BaseFigure
    {
        public Figure_BizeCurve(string[] lines, Color pc, int th, Color bc) : base(lines, pc, th, bc) { }
        public Figure_BizeCurve(Point[] pp, Color pc, int th, Color bc) : base(pp, pc, th, bc) { }
        public Figure_BizeCurve(XmlNode node) : base(node) { }
        protected override void Draw_Figure(Graphics g)
        {
            g.DrawBeziers(pen, points);
        }
    }



    public static class Figures
    {
        public static readonly Dictionary<Figure_Types, string> Items;

        static Figures()
        {
            Items = new Dictionary<Figure_Types, string>
            {
                { Figure_Types.Ellipse, "Эллипс" },
                { Figure_Types.Rectangle, "Прямоугольник" },
                { Figure_Types.Polygon, "Многоугольник" },
                { Figure_Types.Line, "Ломаная" },
                { Figure_Types.Curve, "Кривая" },
                { Figure_Types.ClosedCurve, "Замкнутая кривая" },
                { Figure_Types.BizeCurve, "Кривая Безье" }
            };
        }

        public static Figure_Types Get_Figure_Type(string s)
        {
            Figure_Types res_figtyp;
            if (Enum.IsDefined(typeof(Figure_Types), s))
                res_figtyp = (Figure_Types)Enum.Parse(typeof(Figure_Types), s);
            else
                res_figtyp = Figure_Types.Unknown;

            return res_figtyp;
        }

        public static Figure_Types Get_Figure_Type(Type t)
        {
            Figure_Types result = Figure_Types.Unknown;
            switch (t.Name)
            {
                case "Figure_Ellipse": result = Figure_Types.Ellipse; break;
                case "Figure_Rectangle": result = Figure_Types.Rectangle; break;
                case "Figure_Polygon": result = Figure_Types.Polygon; break;
                case "Figure_Line": result = Figure_Types.Line; break;
                case "Figure_Curve": result = Figure_Types.Curve; break;
                case "Figure_ClosedCurve": result = Figure_Types.ClosedCurve; break;
                case "Figure_BizeCurve": result = Figure_Types.BizeCurve; break;
                default: result = Figure_Types.Unknown; break;
            }
            return result;
        }
    }



    public class Figures_List : List<BaseFigure>
    {
        /*public void Add_Figure(Figure_Types fig_type, Point[] pp, int x, int y, int w, int h, Color pc, int th, Color bc)
        {
            BaseFigure fig = null;
            switch (fig_type)
            {
                case Figure_Types.Ellipse: fig = new Figure_Ellipse(fig_type, x, y, w, h, pc, th, bc); break;
                case Figure_Types.Rectangle: fig = new Figure_Rectangle(fig_type, x, y, w, h, pc, th, bc); break;
                case Figure_Types.Polygon:fig = new Figure_Polygon(fig_type, pp, pc, th, bc); break;
                case Figure_Types.Line: fig = new Figure_Lines(fig_type, pp, pc, th, bc); break;
                case Figure_Types.Curve:fig = new Figure_Curve(fig_type, pp, pc, th, bc);  break;
                case Figure_Types.ClosedCurve: fig = new Figure_ClosedCurve(fig_type, pp, pc, th, bc); break;
                case Figure_Types.BizeCurve: fig = new Figure_BizeCurve(fig_type, pp, pc, th, bc); break;
            }
            if (fig != null)
                Add(fig);
        }*/

        public void Add_Figure(Figure_Types fig_type, string[] line, int x, int y, int w, int h, Color pc, int th, Color bc)
        {
            BaseFigure fig = null;
            switch (fig_type)
            {
                case Figure_Types.Ellipse: fig = new Figure_Ellipse(x, y, w, h, pc, th, bc); break;
                case Figure_Types.Rectangle: fig = new Figure_Rectangle(x, y, w, h, pc, th, bc); break;
                case Figure_Types.Polygon: fig = new Figure_Polygon(line, pc, th, bc); break;
                case Figure_Types.Line: fig = new Figure_Lines(line, pc, th, bc); break;
                case Figure_Types.Curve: fig = new Figure_Curve(line, pc, th, bc); break;
                case Figure_Types.ClosedCurve: fig = new Figure_ClosedCurve(line, pc, th, bc); break;
                case Figure_Types.BizeCurve: fig = new Figure_BizeCurve(line, pc, th, bc); break;
            }
            if (fig != null)
                Add(fig);
        }

        public void Add_Figure(XmlNode node)
        {
            BaseFigure fig = null;
            switch (Figures.Get_Figure_Type(node.Attributes.GetNamedItem("Type").Value))
            {
                case Figure_Types.Ellipse: fig = new Figure_Ellipse(node); break;
                case Figure_Types.Rectangle: fig = new Figure_Rectangle(node); break;
                case Figure_Types.Polygon: fig = new Figure_Polygon(node); break;
                case Figure_Types.Line: fig = new Figure_Lines(node); break;
                case Figure_Types.Curve: fig = new Figure_Curve(node); break;
                case Figure_Types.ClosedCurve: fig = new Figure_ClosedCurve(node); break;
                case Figure_Types.BizeCurve: fig = new Figure_BizeCurve(node); break;
            }
            if (fig != null)
                Add(fig);
        }

        public void Draw_Fig(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (BaseFigure f in this)
            {
                if (f != null)
                    f.Draw(g);
            }
        }

        public void Save_To_XML(string filename)
        {
            XmlDocument xml = new XmlDocument();
            XmlDeclaration decl = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
            xml.AppendChild(decl);
            XmlElement root = xml.CreateElement("Figures");
            xml.AppendChild(root);
            foreach (BaseFigure f in this)
            {
                root.AppendChild(f.Get_XML_Node(xml));
            }
            xml.Save(filename);
        }

        public void Load_From_XML(string filename)
        {
            Clear();
            XmlDocument xml = new XmlDocument();
            xml.Load(filename);
            foreach (XmlNode node in xml.DocumentElement)
            {
                Add_Figure(node);
            }
        }
    }

}
