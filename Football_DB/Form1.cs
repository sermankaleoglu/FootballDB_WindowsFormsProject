using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.teamTableAdapter.InsertQuery(textBox1.Text, textBox2.Text);
            this.teamTableAdapter.Fill(this.footballDataSET.Team);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int PL_Age, T_ID;
            int.TryParse(textBox5.Text, out PL_Age);
            int.TryParse(comboBox1.SelectedValue.ToString(), out T_ID);
            this.playerTableAdapter.InsertQuery(textBox3.Text, textBox4.Text, PL_Age, T_ID);
            this.playerTableAdapter.Fill(this.footballDataSET.Player);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int C_Phone, T_ID;
            int.TryParse(textBox8.Text, out C_Phone);
            int.TryParse(comboBox2.SelectedValue.ToString(), out T_ID);
            this.coachTableAdapter.InsertQuery(textBox6.Text, textBox7.Text, C_Phone, T_ID);
            this.coachTableAdapter.Fill(this.footballDataSET.Coach);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int PR_Phone;
            int.TryParse(textBox11.Text, out PR_Phone);
            this.parentTableAdapter.InsertQuery(textBox9.Text, textBox10.Text, PR_Phone, textBox12.Text);
            this.parentTableAdapter.Fill(this.footballDataSET.Parent);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int PL_ID, PR_ID;
            int.TryParse(comboBox3.SelectedValue.ToString(), out PL_ID);
            int.TryParse(comboBox4.SelectedValue.ToString(), out PR_ID);
            this.enrollTableAdapter.InsertQuery(PL_ID, PR_ID);
            this.enrollTableAdapter.Fill(this.footballDataSET.Enroll);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int T_ID;
            int.TryParse(textBox13.Text, out T_ID);
            textBox15.Text = this.teamTableAdapter.ScalarQuery1(T_ID);
            textBox14.Text = this.teamTableAdapter.ScalarQuery2(T_ID);
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            int T_ID;
            int.TryParse(textBox13.Text, out T_ID);
            this.teamTableAdapter.DeleteQuery(T_ID);
            this.teamTableAdapter.Fill(this.footballDataSET.Team);
            this.playerTableAdapter.UpdateQuery_Delete_Team(T_ID);
            this.coachTableAdapter.UpdateQuery_Delete_Team(T_ID);
            this.teamTableAdapter.Fill(this.footballDataSET.Team);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int T_ID;
            int.TryParse(textBox13.Text, out T_ID);
            this.teamTableAdapter.UpdateQuery(textBox15.Text, textBox14.Text, T_ID);
            this.teamTableAdapter.Fill(this.footballDataSET.Team);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int PL_ID;
            int.TryParse(textBox16.Text, out PL_ID);
            textBox17.Text = this.playerTableAdapter.ScalarQuery3(PL_ID);
            textBox18.Text = this.playerTableAdapter.ScalarQuery4(PL_ID);
            textBox19.Text = this.playerTableAdapter.ScalarQuery5(PL_ID).ToString();
            comboBox5.SelectedValue= this.playerTableAdapter.ScalarQuery6(PL_ID);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int PL_ID, PL_Age, T_ID;
            int.TryParse(textBox16.Text, out PL_ID);
            int.TryParse(textBox19.Text, out PL_Age);
            int.TryParse(comboBox5.SelectedValue.ToString(), out T_ID) ;
            this.playerTableAdapter.UpdateQuery(textBox17.Text, textBox18.Text, PL_Age, T_ID,PL_ID);
            this.playerTableAdapter.Fill(this.footballDataSET.Player);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int PL_ID;
            int.TryParse(textBox16.Text, out PL_ID);
            this.playerTableAdapter.DeleteQuery(PL_ID);
            this.enrollTableAdapter.UpdateQuery_Delete_Player(PL_ID);
            this.playerTableAdapter.Fill(this.footballDataSET.Player);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            int C_ID;
            int.TryParse(textBox20.Text, out C_ID);
            textBox21.Text = this.coachTableAdapter.ScalarQuery7(C_ID);
            textBox22.Text = this.coachTableAdapter.ScalarQuery8(C_ID);
            textBox23.Text = this.coachTableAdapter.ScalarQuery9(C_ID).ToString();
            comboBox6.SelectedValue = this.coachTableAdapter.ScalarQuery10(C_ID);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            int C_ID, C_Phone, T_ID;
            int.TryParse(textBox20.Text, out C_ID);
            int.TryParse(textBox23.Text, out C_Phone);
            int.TryParse(comboBox6.SelectedValue.ToString(), out T_ID);
            this.coachTableAdapter.UpdateQuery(textBox21.Text, textBox22.Text, C_Phone, T_ID,C_ID);
            this.coachTableAdapter.Fill(this.footballDataSET.Coach);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            int C_ID;
            int.TryParse(textBox20.Text, out C_ID);
            this.coachTableAdapter.DeleteQuery(C_ID);
            this.coachTableAdapter.Fill(this.footballDataSET.Coach);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            int PR_ID;
            int.TryParse(textBox24.Text, out PR_ID);
            textBox25.Text = this.parentTableAdapter.ScalarQuery11(PR_ID);
            textBox26.Text = this.parentTableAdapter.ScalarQuery12(PR_ID);
            textBox27.Text = this.parentTableAdapter.ScalarQuery13(PR_ID).ToString();
            textBox28.Text = this.parentTableAdapter.ScalarQuery14(PR_ID);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            int PR_ID, PR_Phone;
            int.TryParse(textBox24.Text, out PR_ID);
            int.TryParse(textBox27.Text, out PR_Phone);
            this.parentTableAdapter.UpdateQuery(textBox25.Text, textBox26.Text,PR_Phone,textBox28.Text,PR_ID);
            this.parentTableAdapter.Fill(this.footballDataSET.Parent);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            int PR_ID;
            int.TryParse(textBox24.Text, out PR_ID);
            this.parentTableAdapter.DeleteQuery(PR_ID);
            this.enrollTableAdapter.UpdateQuery_Delete_Player(PR_ID);
            this.parentTableAdapter.Fill(this.footballDataSET.Parent);
        }        
    }
}
