namespace VisualSortingAlgorithm
{
    public partial class Form1 : Form
    {
        int[] arrNum; // create array to store all the graphics
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            g = panel1.CreateGraphics(); // Create graphics on the form
            int numEntries = panel1.Width;
            int maxVal = panel1.Height;

            arrNum = new int[numEntries]; // set length of array to number of entries
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numEntries, maxVal);
            Random rand = new Random();

            for (int i = 0; i < numEntries; i++)
            {
                arrNum[i] = rand.Next(0, maxVal); // populate array with randomly generated values between 0 and height of panel
            }
            ;
            for (int i = 0; i < numEntries; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, maxVal - arrNum[i], 1, maxVal);
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ISortEngine se = new SortEngineBubble();
            se.DoWork(arrNum, g, panel1.Height); // Envoke the sort engines methods and pass required variables
        }
    }
}
