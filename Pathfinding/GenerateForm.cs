using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinding
{
    public partial class GenerateForm : Form
    {
        public GenerateForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Field = new int[150, 120];
            for (int i = 0; i < 150; i++)
                for (int j = 0; j < 120; j++)
                    Field[i, j] = 0;
            comboBox1.SelectedIndex = 0;
            xS.Maximum = Math.Min((Screen.PrimaryScreen.Bounds.Width - 250) / 16 / 10 * 10, 150);
            yS.Maximum = Math.Min((Screen.PrimaryScreen.Bounds.Height - 30) / 16 / 10 * 10, 120);
        }

        public void SetSize(int x, int y)
        {
            xS.Value = x;
            yS.Value = y;
            Generate();
        }

        public int XS { get { return (int)xS.Value; } }
        public int YS { get { return (int)yS.Value; } }
        public bool Cost { get { return cost.Checked; } }

        public int[,] Field { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }

        private void GenerateForm_Paint(object sender, PaintEventArgs e)
        {
            // 12, 39, 8x8
            for (int i = 0; i < xS.Value; i++)
                for (int j = 0; j < yS.Value; j++)
                {
                    Brush brush = Brushes.Gray;
                    if (Field[i, j] == 0) brush = Brushes.White;
                    if (Field[i, j] == 2) brush = Brushes.LightGreen;
                    e.Graphics.FillRectangle(brush, 12 + i * 8, 39 + j * 8, 8, 8);
                }
            e.Graphics.FillRectangle(Brushes.Red, 12 + StartX * 8, 39 + StartY * 8, 8, 8);
            e.Graphics.FillRectangle(Brushes.Blue, 12 + EndX * 8, 39 + EndY * 8, 8, 8);
        }

        private void cancB_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void okB_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void genB_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void Generate()
        {
            for (int i = 0; i < 150; i++)
                for (int j = 0; j < 120; j++)
                    Field[i, j] = 0;
            Random rand = new Random();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < Math.Max(xS.Value, yS.Value) * (cost.Checked ? 10 : 5); i++)
                    {
                        int x = rand.Next((int)xS.Value);
                        int y = rand.Next((int)yS.Value);
                        bool hc = rand.Next(2) == 1;
                        if (cost.Checked && hc) Field[x, y] = 2;
                        else Field[x, y] = 1;
                    }
                    int sx = rand.Next(XS), sy = rand.Next(YS), ex = rand.Next(XS), ey = rand.Next(YS);
                    while (Field[sx, sy] != 0 || Field[ex, ey] != 0 || (sx == ex && sy == ey))
                    {
                        sx = rand.Next(XS);
                        sy = rand.Next(YS);
                        ex = rand.Next(XS);
                        ey = rand.Next(YS);
                    }
                    StartX = sx;
                    StartY = sy;
                    EndX = ex;
                    EndY = ey;
                    break;
                case 1:
                    int num = rand.Next(Math.Max(XS, YS), Math.Max(XS, YS));
                    if (Cost)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            int size = rand.Next(Math.Min(XS, YS) / 3, Math.Max(XS, YS) / 3);
                            int x = rand.Next((int)xS.Value - size + 1) / 2 * 2;
                            int y = rand.Next((int)yS.Value - size + 1) / 2 * 2;
                            bool vertical = rand.Next(2) == 1;
                            for (int j = 0; j < size; j++)
                            {
                                if (vertical && y + j < YS && y + j >= 0) Field[x, y + j] = 2;
                                if (!vertical && x + j < XS && x + j >= 0) Field[x + j, y] = 2;
                            }
                        }
                    }
                    for (int i = 0; i < num; i++)
                    {
                        int size = rand.Next(Math.Min(XS, YS) / 3, Math.Max(XS, YS) / 3);
                        int x = rand.Next((int)xS.Value - size) / 2 * 2 + 1;
                        int y = rand.Next((int)yS.Value - size) / 2 * 2 + 1;
                        bool vertical = rand.Next(2) == 1;
                        for (int j = 0; j < size; j++)
                        {
                            if (vertical && y + j < YS && y + j >= 0) Field[x, y + j] = 1;
                            if (!vertical && x + j < XS && x + j >= 0) Field[x + j, y] = 1;
                        }
                    }
                    sx = rand.Next(XS); sy = rand.Next(YS); ex = rand.Next(XS); ey = rand.Next(YS);
                    while (Field[sx, sy] != 0 || Field[ex, ey] != 0 || (sx == ex && sy == ey))
                    {
                        sx = rand.Next(XS);
                        sy = rand.Next(YS);
                        ex = rand.Next(XS);
                        ey = rand.Next(YS);
                    }
                    StartX = sx;
                    StartY = sy;
                    EndX = ex;
                    EndY = ey;
                    break;
                case 2:
                    for (int i = 0; i < 150; i++)
                        for (int j = 0; j < 120; j++)
                            Field[i, j] = 1;
                    num = Math.Max(XS, YS) / 4;
                    for (int i = 0; i < num * (Cost ? 1 : 2); i++)
                    {
                        int size = rand.Next(Math.Min(XS, YS) / 2);
                        int x = rand.Next(1, (int)xS.Value - size);
                        int y = rand.Next(1, (int)yS.Value - size);
                        for (int k = 0; k < size; k++)
                        {
                            for (int l = 0; l < size; l++)
                            {
                                Field[x + k, y + l] = 0;
                            }
                        }
                    }
                    if (Cost)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            int size = rand.Next(Math.Min(XS, YS) / 3);
                            int x = rand.Next(1, (int)xS.Value - size);
                            int y = rand.Next(1, (int)yS.Value - size);
                            for (int k = 0; k < size; k++)
                            {
                                for (int l = 0; l < size; l++)
                                {
                                    Field[x + k, y + l] = 2;
                                }
                            }
                        }
                    }
                    sx = rand.Next(XS); sy = rand.Next(YS); ex = rand.Next(XS); ey = rand.Next(YS);
                    while (Field[sx, sy] != 0 || Field[ex, ey] != 0 || (sx == ex && sy == ey))
                    {
                        sx = rand.Next(XS);
                        sy = rand.Next(YS);
                        ex = rand.Next(XS);
                        ey = rand.Next(YS);
                    }
                    StartX = sx;
                    StartY = sy;
                    EndX = ex;
                    EndY = ey;
                    break;
                case 3:
                    for (int i = 0; i < 150; i++)
                        for (int j = 0; j < 120; j++)
                            Field[i, j] = 1;
                    Field[0, 0] = Field[1, 0] = Field[0, 1] = Field[XS - 1, YS - 1] = Field[XS - 2, YS - 1] = Field[XS - 1, YS - 2] = Field[XS - 2, YS - 2] = 0;
                    int _X = (XS % 2 == 0) ? (XS / 2) : (XS / 2 + 1);
                    int _Y = (YS % 2 == 0) ? (YS / 2) : (YS / 2 + 1);
                    for (int i = 0; i < _X; i++)
                    {
                        for (int j = 0; j < _Y; j++)
                        {
                            int cost = (rand.Next(5) == 1 && Cost) ? 2 : 0;
                            bool[] directions =  new bool[] { i > 0, j > 0, i < XS / 2, j < YS / 2 }; // left, up, right, down
                            for (int _ = 0; _ < rand.Next(1, 3); _++)
                            {
                                int dir = rand.Next(4);
                                while (!directions[dir]) dir = rand.Next(4);
                                Field[i * 2, j * 2] = cost;
                                switch (dir)
                                {
                                    case 0:
                                        Field[i * 2 - 1, j * 2] = cost;
                                        break;
                                    case 1:
                                        Field[i * 2, j * 2 - 1] = cost;
                                        break;
                                    case 2:
                                        Field[i * 2 + 1, j * 2] = cost;
                                        break;
                                    case 3:
                                        Field[i * 2, j * 2 + 1] = cost;
                                        break;
                                }
                            }
                        }
                    }
                    StartX = 0;
                    StartY = 0;
                    EndX = XS - 1;
                    EndY = YS - 1;
                    break;
            }
            Invalidate();
        }

        private void xS_ValueChanged(object sender, EventArgs e)
        {
            Width = 127 + (int)xS.Value * 8;
            Height = 89 + (int)yS.Value * 8;
            for (int i = 0; i < 150; i++)
                for (int j = 0; j < 120; j++)
                    if (i > xS.Value || j > yS.Value)
                        Field[i, j] = 0;
            Invalidate();
        }

        private void yS_ValueChanged(object sender, EventArgs e) => xS_ValueChanged(sender, e);

        private void cost_CheckedChanged(object sender, EventArgs e)
        {
            if (!cost.Checked)
                for (int i = 0; i < 150; i++)
                    for (int j = 0; j < 120; j++)
                        if (Field[i, j] == 2)
                            Field[i, j] = 0;
            Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
