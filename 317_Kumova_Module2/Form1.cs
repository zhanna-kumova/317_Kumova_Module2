using _317_Kumova_Module2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _317_Kumova_Module2
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn assignedToColumn = new DataGridViewComboBoxColumn();
            assignedToColumn.Items.Add("unassigned");
            assignedToColumn.DefaultCellStyle.NullValue = "unassigned";

            breakfest.SizeMode = PictureBoxSizeMode.Zoom;
            dinner.SizeMode = PictureBoxSizeMode.Zoom;
            lunch.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            int rowId = menuGridView.Rows.Add();
            DataGridViewRow row = menuGridView.Rows[rowId];
            row.Cells["daytime"].Value = "завтрак";

            int rowId1 = menuGridView.Rows.Add();
            DataGridViewRow row1 = menuGridView.Rows[rowId1];
            row1.Cells["daytime"].Value = "обед";

            int rowId2 = menuGridView.Rows.Add();
            DataGridViewRow row2 = menuGridView.Rows[rowId2];
            row2.Cells["daytime"].Value = "ужин";

            describtion_label.Left = (Width - describtion_label.PreferredWidth) / 2;

            string[] menuItems = { "закуска", "основное", "десерт" };

            DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)menuGridView[1,0];
            comboCell.Items.Clear();
            comboCell.Items.AddRange(menuItems);
            
            DataGridViewComboBoxCell comboCell1 = (DataGridViewComboBoxCell)menuGridView[1,1];
            comboCell1.Items.Clear();
            comboCell1.Items.AddRange(menuItems);
            
            DataGridViewComboBoxCell comboCell2 = (DataGridViewComboBoxCell)menuGridView[1,2];
            comboCell2.Items.Clear();
            comboCell2.Items.AddRange(menuItems);
        }

        private void buttonget_result_btn_Click(object sender, EventArgs e)
        {
            /*Graphics graph = e.ChartGraphics.Graphics;

            PointF point1 = PointF.Empty;
            PointF point2 = PointF.Empty;

            point1 = e.ChartGraphics.GetAbsolutePoint(point1);
            point2 = e.ChartGraphics.GetAbsolutePoint(point2);

            var pen = new Pen(Color.Yellow, 3);
            pen.DashStyle = DashStyle.Dash;
            .DrawLine(pen, point1, point2);*/

            /*float[] dashValues = { 5, 2, 15, 4 };
            Pen pen = new Pen(Color.Yellow, 5);
            pen.DashStyle = DashStyle.Dash;
            buttonget_result_btn.CreateGraphics(DrawLine(pen, new Point(5, 5), new Point(405, 5)));
            describtion_label.Graphics.DrawLine(pen, new Point(5, 5), new Point(405, 5));*/

            DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)menuGridView[1, 0];

            if (comboCell.Value.Equals("закуска"))
            {
                breakfest.Image = Resources.br_zak;
            }
            else if (comboCell.Value.Equals("основное"))
            {
                breakfest.Image = Resources.br_osn;
            }
            else if (comboCell.Value.Equals("десерт"))
            {
                breakfest.Image = Resources.br_des;
            }

            DataGridViewComboBoxCell comboCell1 = (DataGridViewComboBoxCell)menuGridView[1, 1];

            if (comboCell1.Value.Equals("закуска"))
            {
                dinner.Image = Resources.din_zak;
            }
            else if (comboCell1.Value.Equals("основное"))
            {
                dinner.Image = Resources.din_osn;
            }
            else if (comboCell1.Value.Equals("десерт"))
            {
                dinner.Image = Resources.din_des;
            }            

            DataGridViewComboBoxCell comboCell2 = (DataGridViewComboBoxCell)menuGridView[1, 2];

            if (comboCell2.Value.Equals("закуска"))
            {
                lunch.Image = Resources.lan_zak;
            }
            else if (comboCell2.Value.Equals("основное"))
            {
                lunch.Image = Resources.lan_osn;
            }
            else if (comboCell2.Value.Equals("десерт"))
            {
                lunch.Image = Resources.lan_des;
            }
        }
        private void describtion_label_Paint(object sender, PaintEventArgs e)
        {
/*            var pen = new Pen(Color.Yellow, 3);
            pen.DashStyle = DashStyle.Dash;
            e.Graphics.DrawLine(pen, new Point(0, 0), new Point(5, 5));*/
        }

        private void MenuForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            float[] dashValues = { 4, 2};
            var pen = new Pen(Color.Blue, 5);
            pen.DashPattern = dashValues;
            pen.DashStyle = DashStyle.Dash;
            l.DrawLine(pen, new Point(0, 150), new Point(818, 150));
            l.Dispose();
        }
    }
}
