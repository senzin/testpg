using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq1
{
    public partial class Form1 : Form
    {
        List<PointF[]> BezierPoints = new List<PointF[]>()
        {
            new PointF[]
            {
                new PointF(3.8056f,5.0588f),                                //開始点
                new PointF(3.0325f,9961f), new PointF(3.1565f, 12.832f),    //制御
                new PointF(3.1567f, 16.927f), },
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //描画に使う「Pen」を生成
            Pen pen = new Pen(Color.Blue, 1.5f);

            //すべてのペジエ曲線を描画(forループ)
            for (int i = 0; i < BezierPoints.Count; i++)
            {
                e.Graphics.DrawBeziers(pen, BezierPoints[i]);
            }
        }
    }
}
