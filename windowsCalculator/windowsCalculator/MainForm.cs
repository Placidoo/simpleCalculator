using System;
using System.Windows.Forms;

namespace windowsCalculator
{
	public partial class MainForm : Form
	{
			decimal number1,number2,answer;
			string operation;
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			btnHide.Hide();
			btnShow.Hide();
			btnNum.Hide();
			btnNum1.Hide();
			equationMini.Hide();
		}
		void Btn0Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("0");
			}
			else{
				equation.Text=(equation.Text+"0");
			}
		}
		void BtnCLRClick(object sender, EventArgs e)
		{
			btnEnter.Enabled=true;
			equation.Text=equation.Text.Remove(0);
			equation.Text=("0");
			btnDot.Enabled=true;
			btnShow.Show();
			btnShow.PerformClick();
			btnShow.Hide();
			btnNum1.Show();
			btnNum1.PerformClick();
			btnNum1.Hide();
			equationMini.Hide();
			operation=("NONE");
		}
		void Btn1Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("1");
			}
			else{
				equation.Text=(equation.Text+"1");
			}
		}
		void Btn2Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("2");
			}
			else{
				equation.Text=(equation.Text+"2");
			}
		}
		void Btn3Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("3");
			}
			else{
				equation.Text=(equation.Text+"3");
			}
		}
		void Btn4Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("4");
			}
			else{
				equation.Text=(equation.Text+"4");
			}
		}
		void Btn5Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("5");
			}
			else{
				equation.Text=(equation.Text+"5");
			}
		}
		void Btn6Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("6");
			}
			else{
				equation.Text=(equation.Text+"6");
			}
		}
		void Btn7Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("7");
			}
			else{
				equation.Text=(equation.Text+"7");
			}
		}
		void Btn8Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("8");
			}
			else{
				equation.Text=(equation.Text+"8");
			}
		}
		void Btn9Click(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("9");
			}
			else{
				equation.Text=(equation.Text+"9");
			}
		}
		void BtnDotClick(object sender, EventArgs e)
		{
			if (equation.Text=="0") {
				equation.Text=("0.");
			}
			else{
				equation.Text=(equation.Text+".");
			}
			btnDot.Enabled=false;
		}
		void BtnAddClick(object sender, EventArgs e)
		{
			number1=Decimal.Parse(equation.Text);
			equation.Text=("0");
			operation="Add";
			btnDot.Enabled=true;
			btnHide.Show();
			btnHide.PerformClick();
			btnHide.Hide();
			btnNum1.Show();
			btnNum1.PerformClick();
			btnNum1.Hide();
			equationMini.Hide();
			
		}
		void BtnEnterClick(object sender, EventArgs e)
		{
			btnShow.Show();
			btnShow.PerformClick();
			btnShow.Hide();
			btnNum.Show();
			btnNum.PerformClick();
			btnNum.Hide();
			number2=Decimal.Parse(equation.Text);
			if (operation=="Add") {
				answer=number1+number2;
			equation.Text=Convert.ToString(answer);
			equationMini.Show();
			equationMini.Text=(number1+"+"+number2);
			}
			if (operation=="Subtract") {
				answer=number1-number2;
			equation.Text=Convert.ToString(answer);
			equationMini.Show();
			equationMini.Text=(number1+"-"+number2);
			}
			if (operation=="Multiply") {
				answer=number1*number2;
			equation.Text=Convert.ToString(answer);
			equationMini.Show();
			equationMini.Text=(number1+"x"+number2);
			}
			if (operation=="Division" && number2!=0) {
				answer=number1/number2;
			equation.Text=Convert.ToString(answer);
			equationMini.Show();
			equationMini.Text=(number1+"/"+number2);
			}
			if (operation=="Division" && number2==0){
				equation.Text=("Error");
				btnHide.Show();
				btnHide.PerformClick();
				btnHide.Hide();
				btnEnter.Enabled=false;
			}
			if (equation.Text=="0") {
				btnNum1.Show();
				btnNum1.PerformClick();
				btnNum1.Hide();
			}
			}
		void BtnHideClick(object sender, EventArgs e)
		{
			btnAdd.Enabled=false;
			btnSubtract.Enabled=false;
			btnMultiply.Enabled=false;
			btnDivide.Enabled=false;
		}
		void BtnShowClick(object sender, EventArgs e)
		{
			btnAdd.Enabled=true;
			btnSubtract.Enabled=true;
			btnMultiply.Enabled=true;
			btnDivide.Enabled=true;
		}
		void BtnSubtractClick(object sender, EventArgs e)
		{
			number1=Decimal.Parse(equation.Text);
			equation.Text=("0");
			operation="Subtract";
			btnDot.Enabled=true;
			btnHide.Show();
			btnHide.PerformClick();
			btnHide.Hide();
			btnNum1.Show();
			btnNum1.PerformClick();
			btnNum1.Hide();
			equationMini.Hide();
			
		}
		void BtnMultiplyClick(object sender, EventArgs e)
		{
			number1=Decimal.Parse(equation.Text);
			equation.Text=("0");
			operation="Multiply";
			btnDot.Enabled=true;
			btnHide.Show();
			btnHide.PerformClick();
			btnHide.Hide();
			btnNum1.Show();
			btnNum1.PerformClick();
			btnNum1.Hide();
			equationMini.Hide();
		}
		void BtnDivideClick(object sender, EventArgs e)
		{
			number1=Decimal.Parse(equation.Text);
			equation.Text=("0");
			operation="Division";
			btnDot.Enabled=true;
			btnHide.Show();
			btnHide.PerformClick();
			btnHide.Hide();
			btnNum1.Show();
			btnNum1.PerformClick();
			btnNum1.Hide();
			equationMini.Hide();
		}
		void BtnNumClick(object sender, EventArgs e)
		{
			btn0.Enabled=false;
			btn1.Enabled=false;
			btn2.Enabled=false;
			btn3.Enabled=false;
			btn4.Enabled=false;
			btn5.Enabled=false;
			btn6.Enabled=false;
			btn7.Enabled=false;
			btn8.Enabled=false;
			btn9.Enabled=false;
			btnDot.Enabled=false;
		}
		void BtnNum1Click(object sender, EventArgs e)
		{
			btn0.Enabled=true;
			btn1.Enabled=true;
			btn2.Enabled=true;
			btn3.Enabled=true;
			btn4.Enabled=true;
			btn5.Enabled=true;
			btn6.Enabled=true;
			btn7.Enabled=true;
			btn8.Enabled=true;
			btn9.Enabled=true;
			btnDot.Enabled=true;
		}
		void BtnBckClick(object sender, EventArgs e)
		{
			btnEnter.Enabled=true;
			equationMini.Hide();
			if (equation.Text=="Error") {
				btnCLR.PerformClick();
			}
			if (equation.Text.Length>0) {
				equation.Text=equation.Text.Remove(equation.Text.Length-1,1);
			}
			if (equation.Text=="") {
				equation.Text=("0");
				btnNum1.Show();
				btnNum1.PerformClick();
				btnNum1.Hide();
			}
			if (equation.Text.Contains(".")) {
				btnDot.Enabled=false;
				}
			else if (!equation.Text.Contains(".")) {
				btnDot.Enabled=true;
			}
			}
		void EquationTextChanged(object sender, EventArgs e)
		{
			if (equation.Text.Length>14) {
				equation.Text=equation.Text.Remove(equation.Text.Length-1,1);
			}
		}
		void MainFormHelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
		{
			MessageBox.Show("Simple C# Calculator\nMade by Joed Michael");
		}
		}
	}
