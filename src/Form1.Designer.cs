
namespace Figures_project
{
    partial class Form_main
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
            this.picbox = new System.Windows.Forms.PictureBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Cursor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_picbox_size = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabC_main = new System.Windows.Forms.TabControl();
            this.tp_Figures = new System.Windows.Forms.TabPage();
            this.gb_Size = new System.Windows.Forms.GroupBox();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            this.nudW = new System.Windows.Forms.NumericUpDown();
            this.lblH = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.gb_Coord = new System.Windows.Forms.GroupBox();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.lbl_fig = new System.Windows.Forms.Label();
            this.cb_figures = new System.Windows.Forms.ComboBox();
            this.tp_Functions = new System.Windows.Forms.TabPage();
            this.bt_loadcoord = new System.Windows.Forms.Button();
            this.bt_savecoord = new System.Windows.Forms.Button();
            this.bt_CleanTB = new System.Windows.Forms.Button();
            this.bt_FillCoord = new System.Windows.Forms.Button();
            this.lblFunc = new System.Windows.Forms.Label();
            this.cb_functions = new System.Windows.Forms.ComboBox();
            this.tb_points = new System.Windows.Forms.TextBox();
            this.bt_clean = new System.Windows.Forms.Button();
            this.bt_undo = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_draw = new System.Windows.Forms.Button();
            this.gb_Brush = new System.Windows.Forms.GroupBox();
            this.chb_Brush = new System.Windows.Forms.CheckBox();
            this.bt_Brush = new System.Windows.Forms.Button();
            this.gb_Pen = new System.Windows.Forms.GroupBox();
            this.lbl_th_pen = new System.Windows.Forms.Label();
            this.nud_pen = new System.Windows.Forms.NumericUpDown();
            this.chb_Pen = new System.Windows.Forms.CheckBox();
            this.bt_Pen = new System.Windows.Forms.Button();
            this.cldl_Brush = new System.Windows.Forms.ColorDialog();
            this.cldl_Pen = new System.Windows.Forms.ColorDialog();
            this.ofd_points = new System.Windows.Forms.OpenFileDialog();
            this.sfd_points = new System.Windows.Forms.SaveFileDialog();
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveXML = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenXML = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.sfd_pic = new System.Windows.Forms.SaveFileDialog();
            this.sfd_XML = new System.Windows.Forms.SaveFileDialog();
            this.ofd_XML = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabC_main.SuspendLayout();
            this.tp_Figures.SuspendLayout();
            this.gb_Size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).BeginInit();
            this.gb_Coord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.tp_Functions.SuspendLayout();
            this.gb_Brush.SuspendLayout();
            this.gb_Pen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pen)).BeginInit();
            this.menu_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbox.Location = new System.Drawing.Point(0, 28);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(870, 645);
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            this.picbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseClick);
            this.picbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseDoubleClick);
            this.picbox.MouseLeave += new System.EventHandler(this.picbox_MouseLeave);
            this.picbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseMove);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_main.Controls.Add(this.statusStrip1);
            this.pnl_main.Controls.Add(this.tabC_main);
            this.pnl_main.Controls.Add(this.bt_clean);
            this.pnl_main.Controls.Add(this.bt_undo);
            this.pnl_main.Controls.Add(this.bt_refresh);
            this.pnl_main.Controls.Add(this.bt_draw);
            this.pnl_main.Controls.Add(this.gb_Brush);
            this.pnl_main.Controls.Add(this.gb_Pen);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_main.Location = new System.Drawing.Point(870, 28);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(392, 645);
            this.pnl_main.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Cursor,
            this.tssl_picbox_size});
            this.statusStrip1.Location = new System.Drawing.Point(0, 617);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(390, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Cursor
            // 
            this.tssl_Cursor.BackColor = System.Drawing.Color.Azure;
            this.tssl_Cursor.Name = "tssl_Cursor";
            this.tssl_Cursor.Size = new System.Drawing.Size(59, 20);
            this.tssl_Cursor.Text = "Курсор";
            // 
            // tssl_picbox_size
            // 
            this.tssl_picbox_size.BackColor = System.Drawing.Color.Azure;
            this.tssl_picbox_size.Name = "tssl_picbox_size";
            this.tssl_picbox_size.Size = new System.Drawing.Size(122, 20);
            this.tssl_picbox_size.Text = "Размер полотна";
            // 
            // tabC_main
            // 
            this.tabC_main.Controls.Add(this.tp_Figures);
            this.tabC_main.Controls.Add(this.tp_Functions);
            this.tabC_main.Location = new System.Drawing.Point(9, 184);
            this.tabC_main.Name = "tabC_main";
            this.tabC_main.SelectedIndex = 0;
            this.tabC_main.Size = new System.Drawing.Size(370, 307);
            this.tabC_main.TabIndex = 8;
            // 
            // tp_Figures
            // 
            this.tp_Figures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tp_Figures.Controls.Add(this.gb_Size);
            this.tp_Figures.Controls.Add(this.gb_Coord);
            this.tp_Figures.Controls.Add(this.lbl_fig);
            this.tp_Figures.Controls.Add(this.cb_figures);
            this.tp_Figures.Location = new System.Drawing.Point(4, 29);
            this.tp_Figures.Name = "tp_Figures";
            this.tp_Figures.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Figures.Size = new System.Drawing.Size(362, 274);
            this.tp_Figures.TabIndex = 0;
            this.tp_Figures.Text = "Фигуры";
            // 
            // gb_Size
            // 
            this.gb_Size.Controls.Add(this.nudH);
            this.gb_Size.Controls.Add(this.nudW);
            this.gb_Size.Controls.Add(this.lblH);
            this.gb_Size.Controls.Add(this.lblW);
            this.gb_Size.Location = new System.Drawing.Point(182, 83);
            this.gb_Size.Name = "gb_Size";
            this.gb_Size.Size = new System.Drawing.Size(170, 109);
            this.gb_Size.TabIndex = 3;
            this.gb_Size.TabStop = false;
            this.gb_Size.Text = "Размеры";
            // 
            // nudH
            // 
            this.nudH.Location = new System.Drawing.Point(82, 68);
            this.nudH.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(82, 27);
            this.nudH.TabIndex = 3;
            this.nudH.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudW
            // 
            this.nudW.Location = new System.Drawing.Point(82, 28);
            this.nudW.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudW.Name = "nudW";
            this.nudW.Size = new System.Drawing.Size(82, 27);
            this.nudW.TabIndex = 2;
            this.nudW.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(6, 70);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(62, 20);
            this.lblH.TabIndex = 1;
            this.lblH.Text = "Высота:";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(6, 28);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(70, 20);
            this.lblW.TabIndex = 0;
            this.lblW.Text = "Ширина:";
            // 
            // gb_Coord
            // 
            this.gb_Coord.Controls.Add(this.nudY);
            this.gb_Coord.Controls.Add(this.lblY);
            this.gb_Coord.Controls.Add(this.lblX);
            this.gb_Coord.Controls.Add(this.nudX);
            this.gb_Coord.Location = new System.Drawing.Point(6, 83);
            this.gb_Coord.Name = "gb_Coord";
            this.gb_Coord.Size = new System.Drawing.Size(170, 109);
            this.gb_Coord.TabIndex = 2;
            this.gb_Coord.TabStop = false;
            this.gb_Coord.Text = "Левая верхняя точка";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(33, 68);
            this.nudY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(105, 27);
            this.nudY.TabIndex = 3;
            this.nudY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(6, 70);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 20);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 28);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 20);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X:";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(33, 26);
            this.nudX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(104, 27);
            this.nudX.TabIndex = 0;
            this.nudX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbl_fig
            // 
            this.lbl_fig.AutoSize = true;
            this.lbl_fig.Location = new System.Drawing.Point(6, 17);
            this.lbl_fig.Name = "lbl_fig";
            this.lbl_fig.Size = new System.Drawing.Size(133, 20);
            this.lbl_fig.TabIndex = 0;
            this.lbl_fig.Text = "Выберите фигуру:";
            // 
            // cb_figures
            // 
            this.cb_figures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_figures.FormattingEnabled = true;
            this.cb_figures.Items.AddRange(new object[] {
            "Эллипс",
            "Прямоугольник",
            "Многоугольник",
            "Ломаная ",
            "Кривая",
            "Замкнутая кривая",
            "Кривая Бизе"});
            this.cb_figures.Location = new System.Drawing.Point(6, 40);
            this.cb_figures.Name = "cb_figures";
            this.cb_figures.Size = new System.Drawing.Size(198, 28);
            this.cb_figures.TabIndex = 1;
            this.cb_figures.SelectedIndexChanged += new System.EventHandler(this.cb_figures_SelectedIndexChanged);
            // 
            // tp_Functions
            // 
            this.tp_Functions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tp_Functions.Controls.Add(this.bt_loadcoord);
            this.tp_Functions.Controls.Add(this.bt_savecoord);
            this.tp_Functions.Controls.Add(this.bt_CleanTB);
            this.tp_Functions.Controls.Add(this.bt_FillCoord);
            this.tp_Functions.Controls.Add(this.lblFunc);
            this.tp_Functions.Controls.Add(this.cb_functions);
            this.tp_Functions.Controls.Add(this.tb_points);
            this.tp_Functions.Location = new System.Drawing.Point(4, 29);
            this.tp_Functions.Name = "tp_Functions";
            this.tp_Functions.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Functions.Size = new System.Drawing.Size(362, 274);
            this.tp_Functions.TabIndex = 1;
            this.tp_Functions.Text = "Функции";
            // 
            // bt_loadcoord
            // 
            this.bt_loadcoord.Location = new System.Drawing.Point(136, 222);
            this.bt_loadcoord.Name = "bt_loadcoord";
            this.bt_loadcoord.Size = new System.Drawing.Size(191, 29);
            this.bt_loadcoord.TabIndex = 6;
            this.bt_loadcoord.Text = "Загрузить координаты";
            this.bt_loadcoord.UseVisualStyleBackColor = true;
            this.bt_loadcoord.Click += new System.EventHandler(this.bt_loadcoord_Click);
            // 
            // bt_savecoord
            // 
            this.bt_savecoord.Location = new System.Drawing.Point(136, 187);
            this.bt_savecoord.Name = "bt_savecoord";
            this.bt_savecoord.Size = new System.Drawing.Size(191, 29);
            this.bt_savecoord.TabIndex = 5;
            this.bt_savecoord.Text = "Сохранить координаты";
            this.bt_savecoord.UseVisualStyleBackColor = true;
            this.bt_savecoord.Click += new System.EventHandler(this.bt_savecoord_Click);
            // 
            // bt_CleanTB
            // 
            this.bt_CleanTB.Location = new System.Drawing.Point(136, 119);
            this.bt_CleanTB.Name = "bt_CleanTB";
            this.bt_CleanTB.Size = new System.Drawing.Size(151, 29);
            this.bt_CleanTB.TabIndex = 4;
            this.bt_CleanTB.Text = "<<< Очистить";
            this.bt_CleanTB.UseVisualStyleBackColor = true;
            this.bt_CleanTB.Click += new System.EventHandler(this.bt_CleanTB_Click);
            // 
            // bt_FillCoord
            // 
            this.bt_FillCoord.Location = new System.Drawing.Point(136, 84);
            this.bt_FillCoord.Name = "bt_FillCoord";
            this.bt_FillCoord.Size = new System.Drawing.Size(151, 29);
            this.bt_FillCoord.TabIndex = 3;
            this.bt_FillCoord.Text = "<<< Заполнить";
            this.bt_FillCoord.UseVisualStyleBackColor = true;
            this.bt_FillCoord.Click += new System.EventHandler(this.bt_FillCoord_Click);
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Location = new System.Drawing.Point(136, 13);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(148, 20);
            this.lblFunc.TabIndex = 2;
            this.lblFunc.Text = "Выберите функцию:";
            // 
            // cb_functions
            // 
            this.cb_functions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_functions.FormattingEnabled = true;
            this.cb_functions.Items.AddRange(new object[] {
            "Синус",
            "Косинус",
            "Парабола",
            "Экспонента",
            "Гипербола",
            "Полукруг"});
            this.cb_functions.Location = new System.Drawing.Point(136, 36);
            this.cb_functions.Name = "cb_functions";
            this.cb_functions.Size = new System.Drawing.Size(151, 28);
            this.cb_functions.TabIndex = 1;
            // 
            // tb_points
            // 
            this.tb_points.Location = new System.Drawing.Point(6, 6);
            this.tb_points.Multiline = true;
            this.tb_points.Name = "tb_points";
            this.tb_points.Size = new System.Drawing.Size(124, 262);
            this.tb_points.TabIndex = 0;
            // 
            // bt_clean
            // 
            this.bt_clean.Location = new System.Drawing.Point(9, 497);
            this.bt_clean.Name = "bt_clean";
            this.bt_clean.Size = new System.Drawing.Size(94, 52);
            this.bt_clean.TabIndex = 7;
            this.bt_clean.Text = "Очистить полотно";
            this.bt_clean.UseVisualStyleBackColor = true;
            this.bt_clean.Click += new System.EventHandler(this.bt_clean_Click);
            // 
            // bt_undo
            // 
            this.bt_undo.Location = new System.Drawing.Point(123, 555);
            this.bt_undo.Name = "bt_undo";
            this.bt_undo.Size = new System.Drawing.Size(94, 29);
            this.bt_undo.TabIndex = 6;
            this.bt_undo.Text = "Отменить";
            this.bt_undo.UseVisualStyleBackColor = true;
            this.bt_undo.Click += new System.EventHandler(this.bt_undo_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(123, 509);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(94, 29);
            this.bt_refresh.TabIndex = 5;
            this.bt_refresh.Text = "Обновить";
            this.bt_refresh.UseVisualStyleBackColor = true;
            // 
            // bt_draw
            // 
            this.bt_draw.Location = new System.Drawing.Point(9, 555);
            this.bt_draw.Name = "bt_draw";
            this.bt_draw.Size = new System.Drawing.Size(94, 29);
            this.bt_draw.TabIndex = 4;
            this.bt_draw.Text = "Рисовать";
            this.bt_draw.UseVisualStyleBackColor = true;
            this.bt_draw.Click += new System.EventHandler(this.bt_draw_Click);
            // 
            // gb_Brush
            // 
            this.gb_Brush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gb_Brush.Controls.Add(this.chb_Brush);
            this.gb_Brush.Controls.Add(this.bt_Brush);
            this.gb_Brush.Location = new System.Drawing.Point(3, 11);
            this.gb_Brush.Name = "gb_Brush";
            this.gb_Brush.Size = new System.Drawing.Size(140, 161);
            this.gb_Brush.TabIndex = 3;
            this.gb_Brush.TabStop = false;
            this.gb_Brush.Text = "Заливка";
            // 
            // chb_Brush
            // 
            this.chb_Brush.AutoSize = true;
            this.chb_Brush.Location = new System.Drawing.Point(6, 75);
            this.chb_Brush.Name = "chb_Brush";
            this.chb_Brush.Size = new System.Drawing.Size(117, 24);
            this.chb_Brush.TabIndex = 1;
            this.chb_Brush.Text = "Прозрачная";
            this.chb_Brush.UseVisualStyleBackColor = true;
            this.chb_Brush.CheckStateChanged += new System.EventHandler(this.chb_Brush_CheckStateChanged);
            // 
            // bt_Brush
            // 
            this.bt_Brush.Location = new System.Drawing.Point(6, 26);
            this.bt_Brush.Name = "bt_Brush";
            this.bt_Brush.Size = new System.Drawing.Size(94, 29);
            this.bt_Brush.TabIndex = 0;
            this.bt_Brush.UseVisualStyleBackColor = true;
            this.bt_Brush.Click += new System.EventHandler(this.bt_Brush_Click);
            // 
            // gb_Pen
            // 
            this.gb_Pen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gb_Pen.Controls.Add(this.lbl_th_pen);
            this.gb_Pen.Controls.Add(this.nud_pen);
            this.gb_Pen.Controls.Add(this.chb_Pen);
            this.gb_Pen.Controls.Add(this.bt_Pen);
            this.gb_Pen.Location = new System.Drawing.Point(185, 11);
            this.gb_Pen.Name = "gb_Pen";
            this.gb_Pen.Size = new System.Drawing.Size(140, 167);
            this.gb_Pen.TabIndex = 2;
            this.gb_Pen.TabStop = false;
            this.gb_Pen.Text = "Обводка";
            // 
            // lbl_th_pen
            // 
            this.lbl_th_pen.AutoSize = true;
            this.lbl_th_pen.Location = new System.Drawing.Point(6, 111);
            this.lbl_th_pen.Name = "lbl_th_pen";
            this.lbl_th_pen.Size = new System.Drawing.Size(75, 20);
            this.lbl_th_pen.TabIndex = 3;
            this.lbl_th_pen.Text = "Толщина:";
            // 
            // nud_pen
            // 
            this.nud_pen.Location = new System.Drawing.Point(6, 134);
            this.nud_pen.Name = "nud_pen";
            this.nud_pen.Size = new System.Drawing.Size(117, 27);
            this.nud_pen.TabIndex = 2;
            this.nud_pen.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // chb_Pen
            // 
            this.chb_Pen.AutoSize = true;
            this.chb_Pen.Location = new System.Drawing.Point(6, 75);
            this.chb_Pen.Name = "chb_Pen";
            this.chb_Pen.Size = new System.Drawing.Size(117, 24);
            this.chb_Pen.TabIndex = 1;
            this.chb_Pen.Text = "Прозрачная";
            this.chb_Pen.UseVisualStyleBackColor = true;
            this.chb_Pen.CheckStateChanged += new System.EventHandler(this.chb_Pen_CheckStateChanged);
            // 
            // bt_Pen
            // 
            this.bt_Pen.Location = new System.Drawing.Point(6, 26);
            this.bt_Pen.Name = "bt_Pen";
            this.bt_Pen.Size = new System.Drawing.Size(94, 29);
            this.bt_Pen.TabIndex = 0;
            this.bt_Pen.UseVisualStyleBackColor = true;
            this.bt_Pen.Click += new System.EventHandler(this.bt_Pen_Click);
            // 
            // ofd_points
            // 
            this.ofd_points.DefaultExt = "txt";
            this.ofd_points.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            // 
            // sfd_points
            // 
            this.sfd_points.FileName = "Figures_points.txt";
            this.sfd_points.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            // 
            // menu_main
            // 
            this.menu_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.SaveImage});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(1262, 28);
            this.menu_main.TabIndex = 2;
            this.menu_main.Text = "menuStrip1";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveXML,
            this.jSONToolStripMenuItem});
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // SaveXML
            // 
            this.SaveXML.Name = "SaveXML";
            this.SaveXML.Size = new System.Drawing.Size(127, 26);
            this.SaveXML.Text = "XML";
            this.SaveXML.Click += new System.EventHandler(this.SaveXML_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenXML,
            this.jSONToolStripMenuItem1});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.загрузитьToolStripMenuItem.Text = "Загрузить...";
            // 
            // OpenXML
            // 
            this.OpenXML.Name = "OpenXML";
            this.OpenXML.Size = new System.Drawing.Size(127, 26);
            this.OpenXML.Text = "XML";
            this.OpenXML.Click += new System.EventHandler(this.OpenXML_Click);
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem1.Text = "JSON";
            // 
            // SaveImage
            // 
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(163, 24);
            this.SaveImage.Text = "Сохранить картинку";
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // sfd_pic
            // 
            this.sfd_pic.Filter = "Image files (*.bmp)|*.bmp|All files(*.*)|*.*";
            // 
            // sfd_XML
            // 
            this.sfd_XML.FileName = "Figures.XML";
            this.sfd_XML.Filter = "XML|*.XML|Все файлы|*.*";
            // 
            // ofd_XML
            // 
            this.ofd_XML.Filter = "XML|*.XML|Все файлы|*.*";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.menu_main);
            this.MainMenuStrip = this.menu_main;
            this.Name = "Form_main";
            this.Text = "Фигуры и функции (Листратов 4811)";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.picbox_Paint);
            this.Resize += new System.EventHandler(this.Form_main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabC_main.ResumeLayout(false);
            this.tp_Figures.ResumeLayout(false);
            this.tp_Figures.PerformLayout();
            this.gb_Size.ResumeLayout(false);
            this.gb_Size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).EndInit();
            this.gb_Coord.ResumeLayout(false);
            this.gb_Coord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.tp_Functions.ResumeLayout(false);
            this.tp_Functions.PerformLayout();
            this.gb_Brush.ResumeLayout(false);
            this.gb_Brush.PerformLayout();
            this.gb_Pen.ResumeLayout(false);
            this.gb_Pen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pen)).EndInit();
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.TabControl tabC_main;
        private System.Windows.Forms.TabPage tp_Figures;
        private System.Windows.Forms.TabPage tp_Functions;
        private System.Windows.Forms.Button bt_clean;
        private System.Windows.Forms.Button bt_undo;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_draw;
        private System.Windows.Forms.GroupBox gb_Brush;
        private System.Windows.Forms.CheckBox chb_Brush;
        private System.Windows.Forms.Button bt_Brush;
        private System.Windows.Forms.GroupBox gb_Pen;
        private System.Windows.Forms.Label lbl_th_pen;
        private System.Windows.Forms.NumericUpDown nud_pen;
        private System.Windows.Forms.CheckBox chb_Pen;
        private System.Windows.Forms.Button bt_Pen;
        private System.Windows.Forms.ComboBox cb_figures;
        private System.Windows.Forms.Label lbl_fig;
        private System.Windows.Forms.GroupBox gb_Size;
        private System.Windows.Forms.GroupBox gb_Coord;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown nudH;
        private System.Windows.Forms.NumericUpDown nudW;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.TextBox tb_points;
        private System.Windows.Forms.Button bt_CleanTB;
        private System.Windows.Forms.Button bt_FillCoord;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.ComboBox cb_functions;
        private System.Windows.Forms.Button bt_loadcoord;
        private System.Windows.Forms.Button bt_savecoord;
        private System.Windows.Forms.ColorDialog cldl_Brush;
        private System.Windows.Forms.ColorDialog cldl_Pen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Cursor;
        private System.Windows.Forms.ToolStripStatusLabel tssl_picbox_size;
        private System.Windows.Forms.OpenFileDialog ofd_points;
        private System.Windows.Forms.SaveFileDialog sfd_points;
        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveXML;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenXML;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveImage;
        private System.Windows.Forms.SaveFileDialog sfd_pic;
        private System.Windows.Forms.SaveFileDialog sfd_XML;
        private System.Windows.Forms.OpenFileDialog ofd_XML;
    }
}

