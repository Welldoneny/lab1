using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Library;

namespace Bank
{
    public partial class Form1 : Form
    {
        private Bank_Account[] bank_Account = new Bank_Account[1];


        public Form1()
        {
            InitializeComponent();
        }

        //delete
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bank_Account[0] = new Bank_Account(textBoxFirstName.Text, textBoxLastName.Text);
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                label4.Text = bank_Account[0].Name();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetListOfChecksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CreateBox.Visible = false;
                StatusBox.Visible = false;
                textBoxBig.Visible = true;
                GetMoneyBox.Visible = false;
                TopUpBox.Visible = false;
                textBoxBig.Text = bank_Account[0].ShowChecks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateCheckBtn_Click(object sender, EventArgs e)
        {
            StatusBox.Visible = false;
            textBoxBig.Visible = false;
            CreateBox.Visible = true;
            GetMoneyBox.Visible = false;
            TopUpBox.Visible = false;
        }


        private void GetStatysBtn_Click(object sender, EventArgs e)
        {
            CreateBox.Visible = false;
            textBoxBig.Visible=false;
            StatusBox.Visible = true;
            GetMoneyBox.Visible = false;
            TopUpBox.Visible = false;
        }


        //delete
        private void textBoxBig_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetMoneyBtn_Click(object sender, EventArgs e)
        {
            CreateBox.Visible = false;
            StatusBox.Visible = false;
            textBoxBig.Visible = false;
            GetMoneyBox.Visible = true;
            TopUpBox.Visible = false;
            CtrditBox.Visible = false;
        }

        private void BtnToCreate_Click(object sender, EventArgs e)
        {
            try
            {
                CreateBox.Visible = false;
                textBoxBig.Visible = true;
                TopUpBox.Visible = false;
                CtrditBox.Visible = false;
                GetMoneyBox.Visible = false;
                bank_Account[0].Create_Check(NameToCreate.Text, Convert.ToInt32(MoneyToCreate.Text));
                textBoxBig.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnToStatus_Click(object sender, EventArgs e)
        {
            try
            {   
                textBoxBig.Text = string.Empty;
                textBoxBig.Text = bank_Account[0].GetMoneyOnTheCheck(Convert.ToInt32(IdToStatus.Text));
                StatusBox.Visible = false;
                textBoxBig.Visible = true;
                TopUpBox.Visible = false;
                GetMoneyBox.Visible = false;
                CtrditBox.Visible = false;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnToGetMoney_Click(object sender, EventArgs e)
        {
            try
            {
                CreateBox.Visible = false;
                StatusBox.Visible = false;
                textBoxBig.Visible = true;
                GetMoneyBox.Visible = false;
                TopUpBox.Visible = false;
                CtrditBox.Visible = false;
                textBoxBig.Text = string.Empty;
                bank_Account[0].minys(Convert.ToInt32(IdToMinus.Text), Convert.ToInt32(MoneyToMinus.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TopUpBtn_Click(object sender, EventArgs e)
        {
            CreateBox.Visible = false;
            StatusBox.Visible = false;
            textBoxBig.Visible = false;
            GetMoneyBox.Visible = false;
            CtrditBox.Visible = false;
            TopUpBox.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CreateBox.Visible = false;
                StatusBox.Visible = false;
                textBoxBig.Visible = true;
                GetMoneyBox.Visible = false;
                TopUpBox.Visible = false;
                CtrditBox.Visible = false;
                textBoxBig.Text = string.Empty;
                bank_Account[0].TopUp(Convert.ToInt32(IdToUp.Text), Convert.ToInt32(MoneyToUp));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreditBtn_Click(object sender, EventArgs e)
        {
            CreateBox.Visible = false;
            StatusBox.Visible = false;
            textBoxBig.Visible = false;
            GetMoneyBox.Visible = true;
            TopUpBox.Visible = false;
           //CtrditBox.Visible = true;
            textBoxBig.Text = string.Empty;
        }

        private void BtnToCredit_Click(object sender, EventArgs e)
        {
            try
            {
                CreateBox.Visible = false;
                StatusBox.Visible = false;
                textBoxBig.Visible = true;
                GetMoneyBox.Visible = false;
                TopUpBox.Visible = false;
                CtrditBox.Visible = false;
                bank_Account[0].minys(Convert.ToInt32(IdToMinus.Text), Convert.ToInt32(MoneyToMinus.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
