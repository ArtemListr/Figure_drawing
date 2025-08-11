using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Figures_project
{
    public partial class Form_main : Form
    {
        private Figures_List FigList;
        public Form_main()
        {
            InitializeComponent();
            cb_figures.DataSource = Figures.Items.ToList();
            cb_figures.ValueMember = "Key";
            cb_figures.DisplayMember = "Value";
            cb_figures.SelectedIndex = 0;
            cb_functions.SelectedIndex = 0;
            bt_Pen.BackColor = Color.Black;
            bt_Brush.BackColor = Color.White;
            FigList = new Figures_List();
            tssl_picbox_size.Text = picbox.Width.ToString() + " x " + picbox.Height.ToString();
        }

        private void bt_draw_Click(object sender, EventArgs e)
        {
            FigList.Add_Figure((Figure_Types)cb_figures.SelectedIndex, tb_points.Lines, (int)nudX.Value, (int)nudY.Value, (int)nudW.Value, (int)nudH.Value, bt_Pen.BackColor, (int)nud_pen.Value, bt_Brush.BackColor);
            Invalidate();
        }

        private void bt_Brush_Click(object sender, EventArgs e)
        {
            if (cldl_Brush.ShowDialog() == DialogResult.OK)
            {
                bt_Brush.BackColor = cldl_Brush.Color;
            }
        }

        private void bt_Pen_Click(object sender, EventArgs e)
        {
            if (cldl_Pen.ShowDialog() == DialogResult.OK)
            {
                bt_Pen.BackColor = cldl_Pen.Color;
            }
        }

        private void chb_Brush_CheckStateChanged(object sender, EventArgs e)
        {
            if (chb_Brush.Checked == true)
            {
                bt_Brush.BackColor = Color.Transparent;
                bt_Brush.Enabled = false;
            }
            else
                bt_Brush.Enabled = true;
        }

        private void chb_Pen_CheckStateChanged(object sender, EventArgs e)
        {
            if (chb_Pen.Checked == true)
            {
                bt_Pen.BackColor = Color.Transparent;
                bt_Pen.Enabled = false;
            }
            else
                bt_Pen.Enabled = true;
        }

        private void cb_figures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_figures.SelectedIndex == 4 | cb_figures.SelectedIndex == 6)
            {
                bt_Brush.Enabled = false;
                chb_Brush.Enabled = false;
            }
            else
            {
                bt_Brush.Enabled = true;
                chb_Brush.Enabled = true;
            }
        }

        private void picbox_Paint(object sender, PaintEventArgs e)
        {
            FigList.Draw_Fig(picbox.CreateGraphics());
        }

        private void bt_clean_Click(object sender, EventArgs e)
        {
            picbox.Image = null;
            FigList.Clear();
            Invalidate();
        }

        private void Form_main_Resize(object sender, EventArgs e)
        {
           tssl_picbox_size.Text = picbox.Width.ToString() + " x " + picbox.Height.ToString();
        }

        private void picbox_MouseMove(object sender, MouseEventArgs e)
        {
            tssl_Cursor.Text = e.X.ToString() + "|" + e.Y.ToString();
                
        }

        private void bt_loadcoord_Click(object sender, EventArgs e)
        {
            if (ofd_points.ShowDialog() == DialogResult.OK)
                tb_points.Lines = File.ReadAllLines(ofd_points.FileName);
        }

        private void bt_savecoord_Click(object sender, EventArgs e)
        {
            if (sfd_points.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd_points.FileName, tb_points.Text);
        }

        private void bt_CleanTB_Click(object sender, EventArgs e)
        {
            tb_points.Clear();
        }
        private void bt_undo_Click(object sender, EventArgs e)
        {
            picbox.Refresh();
            FigList.RemoveAt(FigList.Count - 1);
        }

        private void picbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bt_draw_Click(null, null);
            Invalidate();
            bt_CleanTB_Click(null, null);
        }

        private void picbox_MouseClick(object sender, MouseEventArgs e)
        {
            nudX.Value = e.X;
            nudY.Value = e.Y;    
            if (ModifierKeys != Keys.Control)
            {
                Graphics g = (sender as Control).CreateGraphics();
                g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(e.X - 1, e.Y - 1, 5, 5));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            tb_points.AppendText(e.X.ToString() + "|" + e.Y.ToString() + Environment.NewLine);
            
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            if (sfd_pic.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(picbox.Width, picbox.Height);
                FigList.Draw_Fig(Graphics.FromImage(bmp));
                bmp.Save(sfd_pic.FileName, ImageFormat.Png);
            }
        }

        private void picbox_MouseLeave(object sender, EventArgs e)
        {
            tssl_Cursor.Text = null;
        }

        private void OpenXML_Click(object sender, EventArgs e)
        {
            if (ofd_XML.ShowDialog() == DialogResult.OK)
                FigList.Load_From_XML(ofd_XML.FileName);
            Invalidate();
        }

        private void SaveXML_Click(object sender, EventArgs e)
        {
            if (sfd_XML.ShowDialog() == DialogResult.OK)
                FigList.Save_To_XML(sfd_XML.FileName);
        }


        public void Draw_Func(Func<double, double> f)
        {
            double x = -2 * Math.PI; //нижняя граница 
            double X = 0;
            double y = f(x);
            double Y = picbox.Height / 2;
            double d = 4 * Math.PI / picbox.Width;
            for (int i = 0; i < picbox.Width; i++)
            {
                tb_points.AppendText(Convert.ToString(Convert.ToInt32(X)) + "|" + Convert.ToString(Convert.ToInt32(Y)) + Environment.NewLine);
                x += d;
                X++;
                y = f(x);
                Y = picbox.Height / 2 - picbox.Height / 2 * y;
            }
        }

        public void Draw_Func() //для полукружности
        {
            double R;
            if (picbox.Width >= picbox.Height)
                R = picbox.Height / 2;
            else
                R = picbox.Width / 2;
            double X = 0;
            double x = -R + X * (2 * R);
            double y = Math.Sqrt(R * R - x * x);
            double Y = picbox.Height * (1 - y / R);
            double d = 2 * R / picbox.Width;
            for (int i = 0; i < picbox.Width; i++)
            {
                tb_points.AppendText(Convert.ToString(Convert.ToInt32(X)) + "|" + Convert.ToString(Convert.ToInt32(Y)) + Environment.NewLine);
                x += d;
                X++;
                y = Math.Sqrt(R * R - x * x); //для того чтобы убрать отриц часть
                Y = picbox.Height * (1 - y / R);
            }
        }
        public double Parabola(double x) { return x * x; }
        public double Hyperbola(double x) { return 1 / x; }
        private void bt_FillCoord_Click(object sender, EventArgs e)
        {
            switch (cb_functions.SelectedIndex)
            {
                case 0: Draw_Func(Math.Sin); break;
                case 1: Draw_Func(Math.Cos); break;
                case 2: Draw_Func(Parabola); break;
                case 3: Draw_Func(Math.Exp); break;
                case 4: Draw_Func(Hyperbola); break;
                case 5: Draw_Func(); break;
            }
        }
    }
}
