using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tarea005.Class;

namespace Tarea005
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            DataGridViewColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Visible = false;

            dataGridView1.Columns.Add(idCol);
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());

            Random color = new Random();

            for (int i = 0; i < 5; i++)
            {
                DataGridViewCell id = new DataGridViewTextBoxCell();
                id.Value = 1;

                DataGridViewTextBoxCell signature = new DataGridViewTextBoxCell();
                signature.Style.BackColor = Color.FromArgb(color.Next(0, 128), color.Next(0, 128), color.Next(0, 128));
                signature.Style.SelectionBackColor = Color.FromArgb(color.Next(0, 150), color.Next(0, 150), color.Next(0, 150));
                signature.Style.ForeColor = Color.Black;
                signature.Style.SelectionForeColor = Color.White;
                signature.Value = "Label";
                signature.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                signature.Style.Font = new Font("Microsoft Tai Le", 18);
               

                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(id, signature);
                dataGridView1.Rows.Add(row);
            }
        }

        private int questionNumber = 1;
        private List<Question> storedData = new List<Question>();
        private void addQuestion()
        {
            if(questionNumber < 21)
            {
                DataGridViewCell qn = new DataGridViewTextBoxCell();
                qn.Style.ForeColor = Color.DarkGray;
                qn.Style.SelectionForeColor = Color.White;
                qn.Style.BackColor = Color.NavajoWhite;
                qn.Style.SelectionBackColor = Color.NavajoWhite;
                qn.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                qn.Style.Font = new Font("Microsoft Tai Le", 18);

                qn.Value = questionNumber;

                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(qn);
                dgvQuestions.Rows.Add(row);
                setData();
                questionNumber++;
            }
        }

        private void setPannel(Form fObj)
        {
            pnlBase.Controls.Clear();
            
            fObj.TopLevel = false;
            fObj.FormBorderStyle = FormBorderStyle.None;
            fObj.Dock = DockStyle.Fill;
            pnlBase.Controls.Add(fObj);
            
            fObj.Show();
        }

        private void setData()
        {
            Question qObj = new Question(questionNumber);
            Form fObj = new NewQuestion(qObj);
            storedData.Add(qObj);
            setPannel(fObj);
        }

        private void dgvQuestions_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvQuestions.Rows.Count > 1)
            {
                setPannel(new NewQuestion(storedData[e.RowIndex]));
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlSignatures.Visible = false;
            pnlNew.Visible = true;

            addQuestion();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string msg = "Los datos actuales del Quiz se perderán";
            DialogResult res = MessageBox.Show(msg, "Ir atrás", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                pnlSignatures.Visible = true;
                pnlNew.Visible = false;
                questionNumber = 1;
                pnlBase.Controls.Clear();
                dgvQuestions.Rows.Clear();
            }
            
        }

        private void btnNewQ_Click(object sender, EventArgs e)
        {
            addQuestion();
        }

        private void btnDelQ_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
