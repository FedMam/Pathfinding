using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pathfinding
{
    public partial class Form1 : Form
    {
        int[,] field = new int[63, 45];
        MouseHeldType mouseHeld = MouseHeldType.None;
        int startX = 0, startY = 0, endX = 19, endY = 19;
        bool running = false;
        Algorithm algorithm = Algorithm.BFS;
        List<Cell> path = new List<Cell>();
        PriorityQueue<Cell> OpenSet = new PriorityQueue<Cell>();
        Dictionary<Cell, Cell> Previous = new Dictionary<Cell, Cell>();
        Dictionary<Cell, int> TotalCost = new Dictionary<Cell, int>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 63; i++)
            {
                for (int j = 0; j < 45; j++)
                {
                    field[i, j] = 0;
                }
            }
            Invalidate();
        }

        public int XSize { get { return (int)xSize.Value; } }
        public int YSize { get { return (int)ySize.Value; } }
        public bool HigherCost { get { return costCB.Checked; } }
        public int Cost { get { return (int)cost.Value; } }

        void Search()
        {
            Cell current = new Cell();
            switch (algorithm)
            {
                case Algorithm.DFS: current = OpenSet.GetLast(); break;
                case Algorithm.BFS: current = OpenSet.GetFirst(); break;
                default: current = OpenSet.Get(); break;
            }
            if (current.X == endX && current.Y == endY)
            {
                path.Clear();
                path.Add(current);
                Cell cell = current;
                while (cell.X != startX || cell.Y != startY)
                {
                    path.Add(Previous[cell]);
                    cell = Previous[cell];
                }
                path.Add(new Cell(startX, startY));
                return;
            }
            foreach (Cell next in Neighbours(current))
            {
                if (next.X == endX && next.Y == endY)
                {
                    path.Clear();
                    path.Add(current);
                    Cell cell = current;
                    while (cell.X != startX || cell.Y != startY)
                    {
                        path.Add(Previous[cell]);
                        cell = Previous[cell];
                    }
                    path.Add(new Cell(startX, startY));
                    return;
                }
                int new_cost = TotalCost[current] + ((Graph(next) == 2) ? (int)cost.Value : 1);
                if ((!Previous.ContainsKey(next) || ((algorithm == Algorithm.Dijkstra || algorithm == Algorithm.AStar) && new_cost < TotalCost[next])) && !(field[next.X, next.Y] == 1))
                {
                    if (!Previous.ContainsKey(next))
                    {
                        TotalCost.Add(next, new_cost);
                        Previous.Add(next, current);
                    }
                    else
                    {
                        TotalCost[next] = new_cost;
                        Previous[next] = current;
                    }
                    switch (algorithm)
                    {
                        case Algorithm.BFS:
                        case Algorithm.DFS:
                            OpenSet.Add(next, 0);
                            break;
                        case Algorithm.Dijkstra:
                            OpenSet.Add(next, new_cost);
                            break;
                        case Algorithm.BestFirst:
                            OpenSet.Add(next, Heuristic(next));
                            break;
                        case Algorithm.AStar:
                            OpenSet.Add(next, new_cost + Heuristic(next));
                            break;
                    }
                }
            }
        }

        int Heuristic(Cell cell)
        {
            if (!diagCB.Checked) return Math.Abs(cell.X - endX) + Math.Abs(cell.Y - endY);
            return Math.Max(Math.Abs(cell.X - endX), Math.Abs(cell.Y - endY));
        }

        int Graph(Cell cell) => field[cell.X, cell.Y];

        Cell[] Neighbours(Cell cell)
        {
            List<Cell> res = new List<Cell>();
            if (Math.Abs(cell.X - endX) > Math.Abs(cell.Y - endY))
            {
                if (cell.Y > 0) res.Add(new Cell(cell.X, cell.Y - 1));
                if (cell.Y < YSize - 1) res.Add(new Cell(cell.X, cell.Y + 1));
                if (diagCB.Checked)
                {
                    if (cell.X > 0 && cell.Y > 0) res.Add(new Cell(cell.X - 1, cell.Y - 1));
                    if (cell.X > 0 && cell.Y < YSize - 1) res.Add(new Cell(cell.X - 1, cell.Y + 1));
                    if (cell.X < XSize - 1 && cell.Y > 0) res.Add(new Cell(cell.X + 1, cell.Y - 1));
                    if (cell.X < XSize - 1 && cell.Y < YSize - 1) res.Add(new Cell(cell.X + 1, cell.Y + 1));
                }
                if (cell.X < XSize - 1) res.Add(new Cell(cell.X + 1, cell.Y));
                if (cell.X > 0) res.Add(new Cell(cell.X - 1, cell.Y));
            }
            else
            {
                if (cell.X < XSize - 1) res.Add(new Cell(cell.X + 1, cell.Y));
                if (cell.X > 0) res.Add(new Cell(cell.X - 1, cell.Y));
                if (diagCB.Checked)
                {
                    if (cell.X > 0 && cell.Y > 0) res.Add(new Cell(cell.X - 1, cell.Y - 1));
                    if (cell.X > 0 && cell.Y < YSize - 1) res.Add(new Cell(cell.X - 1, cell.Y + 1));
                    if (cell.X < XSize - 1 && cell.Y > 0) res.Add(new Cell(cell.X + 1, cell.Y - 1));
                    if (cell.X < XSize - 1 && cell.Y < YSize - 1) res.Add(new Cell(cell.X + 1, cell.Y + 1));
                }
                if (cell.Y > 0) res.Add(new Cell(cell.X, cell.Y - 1));
                if (cell.Y < YSize - 1) res.Add(new Cell(cell.X, cell.Y + 1));
            }
            return res.ToArray();
        }

        private void xSize_ValueChanged(object sender, EventArgs e)
        {
            Width = 150 + 16 * ((int)xSize.Value + 1) + 100;
            for (int i = 0; i < 63; i++)
            {
                for (int j = 0; j < 45; j++)
                {
                    if (i >= XSize || j >= YSize) field[i, j] = 0;
                }
            }
            if (startX >= XSize) startX = XSize - 1;
            if (endX >= XSize) endX = XSize - 1;
            path.Clear();
            OpenSet = new PriorityQueue<Cell>();
            Previous.Clear();
            TotalCost.Clear();
            Invalidate();
        }

        private void ySize_ValueChanged(object sender, EventArgs e)
        {
            Height = 39 + 16 * ((int)ySize.Value);
            for (int i = 0; i < 63; i++)
            {
                for (int j = 0; j < 45; j++)
                {
                    if (i >= XSize || j >= YSize) field[i, j] = 0;
                }
            }
            if (startY >= YSize) startY = YSize - 1;
            if (endY >= YSize) endY = YSize - 1;
            path.Clear();
            OpenSet = new PriorityQueue<Cell>();
            Previous.Clear();
            TotalCost.Clear();
            Invalidate();
        }

        private void costCB_CheckedChanged(object sender, EventArgs e)
        {
            cost.Enabled = costCB.Checked;
            if (!costCB.Checked)
            {
                for (int i = 0; i < 63; i++)
                {
                    for (int j = 0; j < 45; j++)
                    {
                        if (field[i, j] == 2)
                            field[i, j] = 0;
                    }
                }
            }
            path.Clear();
            OpenSet = new PriorityQueue<Cell>();
            Previous.Clear();
            TotalCost.Clear();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < XSize; i++)
            {
                for (int j = 0; j < YSize; j++)
                {
                    Color color = Color.White;
                    if (field[i, j] == 1)
                    {
                        color = Color.DarkGray;
                    }
                    if (field[i, j] == 2 && HigherCost)
                        color = Color.LightGreen;
                    e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle(new Point(150 + i * 16, j * 16), new Size(16, 16)));
                }
            }
            e.Graphics.FillEllipse(Brushes.Blue, new Rectangle(new Point(150 + endX * 16, endY * 16), new Size(16, 16)));
            e.Graphics.FillEllipse(Brushes.Red, new Rectangle(new Point(150 + startX * 16 + 2, startY * 16 + 2), new Size(12, 12)));
            foreach (Cell cell in path)
            {
                e.Graphics.FillEllipse(Brushes.LightBlue, new Rectangle(new Point(150 + cell.X * 16 + 4, cell.Y * 16 + 4), new Size(8, 8)));
            }
            if (showCB.Checked)
            {
                foreach (Cell cell in Previous.Keys)
                {
                    e.Graphics.DrawRectangle(Pens.Yellow, new Rectangle(new Point(150 + cell.X * 16, cell.Y * 16), new Size(16, 16)));
                }
                foreach (Cell cell in OpenSet.GetItems())
                {
                    e.Graphics.DrawRectangle(Pens.Red, new Rectangle(new Point(150 + cell.X * 16, cell.Y * 16), new Size(16, 16)));
                }
            }
        }

        private void dfsRB_CheckedChanged(object sender, EventArgs e)
        {
            if (dfsRB.Checked)
                algorithm = Algorithm.DFS;
        }

        private void bfsRB_CheckedChanged(object sender, EventArgs e)
        {
            if (bfsRB.Checked)
                algorithm = Algorithm.BFS;
        }

        private void dijktraRB_CheckedChanged(object sender, EventArgs e)
        {
            if (dijkstraRB.Checked)
                algorithm = Algorithm.Dijkstra;
        }

        private void bestfirstRB_CheckedChanged(object sender, EventArgs e)
        {
            if (bestfirstRB.Checked)
                algorithm = Algorithm.BestFirst;
        }

        private void astarRB_CheckedChanged(object sender, EventArgs e)
        {
            if (astarRB.Checked)
                algorithm = Algorithm.AStar;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (running) { Reenable(); timer.Stop(); return; }
            running = true;
            runButton.Text = "Stop";
            sizeLabel.Enabled = false;
            xL.Enabled = false;
            yL.Enabled = false;
            xSize.Enabled = false;
            ySize.Enabled = false;
            cost.Enabled = false;
            costCB.Enabled = false;
            dfsRB.Enabled = false;
            dijkstraRB.Enabled = false;
            bfsRB.Enabled = false;
            astarRB.Enabled = false;
            bestfirstRB.Enabled = false;
            showCB.Enabled = false;
            diagCB.Enabled = false;
            path.Clear();
            OpenSet = new PriorityQueue<Cell>();
            Previous.Clear();
            OpenSet.Add(new Cell(startX, startY), 0);
            Previous.Add(new Cell(startX, startY), new Cell());
            TotalCost.Clear();
            TotalCost.Add(new Cell(startX, startY), 0);
            if (!showCB.Checked)
            {
                while (OpenSet.Count > 0 && path.Count == 0)
                {
                    Search();
                }
                Reenable();
            }
            else
            {
                timer.Start();
            }
            Invalidate();
        }

        void Reenable()
        {
            running = false;
            runButton.Text = "Run";
            sizeLabel.Enabled = true;
            xL.Enabled = true;
            yL.Enabled = true;
            xSize.Enabled = true;
            ySize.Enabled = true;
            cost.Enabled = costCB.Checked;
            costCB.Enabled = true;
            dfsRB.Enabled = true;
            dijkstraRB.Enabled = true;
            bfsRB.Enabled = true;
            astarRB.Enabled = true;
            bestfirstRB.Enabled = true;
            showCB.Enabled = true;
            diagCB.Enabled = true;
            switch (algorithm)
            {
                case Algorithm.DFS: labelA.Text = "DFS"; break;
                case Algorithm.BFS: labelA.Text = "BFS"; break;
                case Algorithm.BestFirst: labelA.Text = "Best-First"; break;
                case Algorithm.Dijkstra: labelA.Text = "Dijkstra"; break;
                case Algorithm.AStar: labelA.Text = "A*"; break;
            }
            if (path.Count > 0)
            {
                int dist = 0;
                foreach (Cell cell in path)
                {
                    if (cell != new Cell(startX, startY))
                    {
                        if (Graph(cell) == 2) dist += (int)cost.Value;
                        else dist += 1;
                    }
                }
                labelD.Text = "Distance: " + dist;
            }
            else labelD.Text = "Distance: -";
            labelV.Text = "Visited: " + Previous.Keys.Count;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Search();
            if (path.Count > 0 || OpenSet.Count == 0)
            {
                Reenable();
                timer.Stop();
            }
            Invalidate();
        }

        private void intervalBar_Scroll(object sender, EventArgs e)
        {
            timer.Interval = intervalBar.Value;
            intervalLbl.Text = "Animation (ms): " + intervalBar.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < XSize; i++)
                for (int j = 0; j < YSize; j++)
                    field[i, j] = 0;
            path.Clear();
            OpenSet = new PriorityQueue<Cell>();
            Previous.Clear();
            TotalCost.Clear();
            Invalidate();
        }

        private void showCB_CheckedChanged(object sender, EventArgs e)
        {
            path.Clear();
            OpenSet = new PriorityQueue<Cell>();
            Previous.Clear();
            TotalCost.Clear();
            Invalidate();
        }

        private void diagCB_CheckedChanged(object sender, EventArgs e)
        {
            path.Clear();
            OpenSet = new PriorityQueue<Cell>();
            Previous.Clear();
            TotalCost.Clear();
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (running) return;
            if (mouseHeld == MouseHeldType.None) return;
            int x = (e.X - 150) / 16;
            int y = e.Y / 16;
            if (x >= XSize || y >= YSize || x < 0 || y < 0) return;
            if (mouseHeld == MouseHeldType.Start)
            {
                startX = x;
                startY = y;
                Invalidate();
                return;
            }
            if (mouseHeld == MouseHeldType.End)
            {
                endX = x;
                endY = y;
                Invalidate();
                return;
            }
            field[x, y] = (int)mouseHeld;
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (running) return;
            mouseHeld = MouseHeldType.None;
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (running) return;
            int x = (e.X - 150) / 16;
            int y = e.Y / 16;
            if (x >= XSize || y >= YSize || x < 0 || y < 0) return;
            if (x == startX && y == startY)
            {
                mouseHeld = MouseHeldType.Start;
                return;
            }
            if (x == endX && y == endY)
            {
                mouseHeld = MouseHeldType.End;
                return;
            }
            if (x >= XSize || y >= YSize || x < 0 || y < 0) return;
            if (!HigherCost)
            {
                if (field[x, y] == 1) mouseHeld = MouseHeldType.Empty;
                else mouseHeld = MouseHeldType.Wall;
            }
            else
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (field[x, y] == 2) mouseHeld = MouseHeldType.Empty;
                    else mouseHeld = MouseHeldType.Cost;
                }
                else
                {
                    if (field[x, y] == 1) mouseHeld = MouseHeldType.Empty;
                    else mouseHeld = MouseHeldType.Wall;
                }
            }
            field[x, y] = (int)mouseHeld;
            path.Clear();
            OpenSet = new PriorityQueue<Cell>();
            Previous.Clear();
            TotalCost.Clear();
            Invalidate();
        }
    }

    class PriorityQueue<T>
    {
        private List<T> Items;
        public List<T> GetItems() { return Items; }
        private List<int> Priorities;
        public int Count { get { return Items.Count; } }
        public PriorityQueue()
        {
            Items = new List<T>();
            Priorities = new List<int>();
        }
        public void Add(T item, int prior)
        {
            Items.Add(item);
            Priorities.Add(prior);
        }
        public T Get()
        {
            if (Items.Count == 0) return default(T);
            int min = Priorities[0], minId = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                if (Priorities[i] <= min)
                {
                    min = Priorities[i];
                    minId = i;
                }
            }
            T item = Items[minId];
            Items.RemoveAt(minId);
            Priorities.RemoveAt(minId);
            return item;
        }
        public T GetLast() { T item = Items[Count - 1]; Items.RemoveAt(Count - 1); return item; }
        public T GetFirst() { T item = Items[0]; Items.RemoveAt(0); return item; }
    }

    struct Cell
    {
        public int X;
        public int Y;
        public Cell(int x, int y)
        {
            X = x; Y = y;
        }
        public override bool Equals(object obj)
        {
            if (obj is Cell && ((Cell)obj).X == X && ((Cell)obj).Y == Y) return true;
            return false;
        }
        public static bool operator == (Cell c1, Cell c2) => c1.Equals(c2);
        public static bool operator != (Cell c1, Cell c2) => !c1.Equals(c2);
    }

    enum MouseHeldType
    {
        None = -1,
        Empty = 0,
        Wall = 1,
        Cost = 2,
        Start = 3,
        End = 4
    }

    enum Algorithm
    {
        DFS, BFS, Dijkstra, BestFirst, AStar
    }
}
