using System;
using System.Collections.Generic;
using System.Drawing;
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
                    num = rand.Next(10, Math.Max(XS, YS));
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
                    while (Field[sx, sy] == 1 || Field[ex, ey] == 1 || (sx == ex && sy == ey))
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
                    Field[0, 0] = Field[1, 0] = Field[0, 1] = Field[XS - 1, YS - 1] = Field[XS - 2, YS - 1] = Field[XS - 1, YS - 2] = 0;
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
                    for (int i = 1; i < Math.Min(XS - 1, 148); i++)
                    {
                        for (int j = 1; j < Math.Min(YS - 1, 118); j++)
                        {
                            if (Field[i, j] == 1 && Field[i - 1, j] != 1 && Field[i + 1, j] != 1 && Field[i, j + 1] != 1 && Field[i, j - 1] != 1)
                            {
                                switch(rand.Next(4))
                                {
                                    case 0: Field[i - 1, j] = 1; break;
                                    case 1: Field[i + 1, j] = 1; break;
                                    case 2: Field[i, j - 1] = 1; break;
                                    case 3: Field[i, j + 1] = 1; break;
                                }
                            }
                        }
                    }
                    StartX = 0;
                    StartY = 0;
                    EndX = XS - 1;
                    EndY = YS - 1;
                    break;
                case 4:
                    for (int i = 0; i < 150; i++)
                        for (int j = 0; j < 120; j++)
                        {
                            if (i % 2 == 0 && j % 2 == 0)
                                Field[i, j] = 0;
                            else Field[i, j] = 1;
                        }
                    bool[,] closedSet = new bool[XS, YS];
                    for (int i = 0; i < XS; i++)
                        for (int j = 0; j < YS; j++)
                            closedSet[i, j] = false;
                    closedSet[0, 0] = true;
                    RandomDFS(new Cell(0, 0), ref closedSet, ref rand);
                    StartX = 0;
                    StartY = 0;
                    EndX = XS - ((XS % 2 == 0) ? 2 : 1);
                    EndY = YS - ((YS % 2 == 0) ? 2 : 1);
                    break;
            }
            Invalidate();
        }

        private void Rooms(int minX, int minY, int maxX, int maxY, int depth, int hole, bool vertical, ref Random rand)
        {
            if (depth < 1) return;
            if ((vertical && maxY - minY <= 1) || (!vertical && maxX - minX <= 1) || (maxX <= minX) || (maxY <= minY)) return;
            int pos = -1;
            int new_hole;
            int diff;
            if (vertical)
            {
                diff = (int)Math.Round((double)(maxY - minY) / 3);
                pos = rand.Next(minY + diff, maxY - diff);
                int ctr = 0;
                while (pos == hole && ctr < 10)
                {
                    pos = rand.Next(minY + diff, maxY - diff);
                    ctr++;
                }
                new_hole = rand.Next(minX, maxX);
                for (int i = minX; i <= maxX; i++)
                {
                    if (i == new_hole)
                    {
                        if (Cost) Field[new_hole, pos] = 2;
                    }
                    else Field[i, pos] = 1;
                }
                Rooms(minX, minY, maxX, pos - 1, depth - 1, new_hole, !vertical, ref rand);
                Rooms(minX, pos + 1, maxX, maxY, depth - 1, new_hole, !vertical, ref rand);
            }
            else
            {
                diff = (int)Math.Round((double)(maxX - minX) / 3);
                pos = rand.Next(minX + diff, maxX - diff);
                int ctr = 0;
                while (pos == hole && ctr < 10)
                {
                    pos = rand.Next(minX + diff, maxX - diff);
                    ctr++;
                }
                new_hole = rand.Next(minY, maxY);
                for (int i = minY; i <= maxY; i++)
                {
                    if (i == new_hole)
                    {
                        if (Cost) Field[pos, new_hole] = 2;
                    }
                    else Field[pos, i] = 1;
                }
                Rooms(minX, minY, pos - 1, maxY, depth - 1, new_hole, !vertical, ref rand);
                Rooms(pos + 1, minY, maxX, maxY, depth - 1, new_hole, !vertical, ref rand);
            }
        }

        private void RandomDFS(Cell current, ref bool[,] closedSet, ref Random rand)
        {
            closedSet[current.X, current.Y] = true;
            List<Cell> neighbours = new List<Cell>();
            do
            {
                neighbours = new List<Cell>();
                List<Cell> neighwalls = new List<Cell>();
                if (current.X > 1 && !closedSet[current.X - 2, current.Y])
                {
                    neighbours.Add(new Cell(current.X - 2, current.Y));
                    neighwalls.Add(new Cell(current.X - 1, current.Y));
                }
                if (current.Y > 1 && !closedSet[current.X, current.Y - 2])
                {
                    neighbours.Add(new Cell(current.X, current.Y - 2));
                    neighwalls.Add(new Cell(current.X, current.Y - 1));
                }
                if (current.X < XS - 2 && !closedSet[current.X + 2, current.Y])
                {
                    neighbours.Add(new Cell(current.X + 2, current.Y));
                    neighwalls.Add(new Cell(current.X + 1, current.Y));
                }
                if (current.Y < YS - 2 && !closedSet[current.X, current.Y + 2])
                {
                    neighbours.Add(new Cell(current.X, current.Y + 2));
                    neighwalls.Add(new Cell(current.X, current.Y + 1));
                }
                int nid = rand.Next(neighbours.Count);
                if (neighbours.Count == 0) break;
                Field[neighwalls[nid].X, neighwalls[nid].Y] = (Cost && rand.Next(2) == 0) ? 2 : 0;
                closedSet[neighbours[nid].X, neighbours[nid].Y] = true;
                RandomDFS(neighbours[nid], ref closedSet, ref rand);
                neighbours.RemoveAt(nid);
                neighwalls.RemoveAt(nid);
            }
            while (neighbours.Count > 0);
        }

        private void xS_ValueChanged(object sender, EventArgs e)
        {
            Width = 127 + (int)xS.Value * 8;
            Height = 89 + (int)yS.Value * 8;
            for (int i = 0; i < 150; i++)
                for (int j = 0; j < 120; j++)
                    if (i > xS.Value || j > yS.Value)
                        Field[i, j] = 0;
            if (StartX >= XS) StartX = XS - 1;
            if (StartY >= YS) StartY = YS - 1;
            if (EndX >= XS) EndX = XS - 1;
            if (EndY >= XS) EndY = XS - 1;
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
