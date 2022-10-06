/*
 * Created by SharpDevelop.
 * User: joedm
 * Date: 27/09/2022
 * Time: 1:00 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace windowsCalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnCLR;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Label equation;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Button btnDot;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btnSubtract;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnNum;
		private System.Windows.Forms.Button btnNum1;
		private practiceLogin.roundedPanel roundedPanel1;
		private System.Windows.Forms.Button btnBck;
		private System.Windows.Forms.Label equationMini;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnNum1 = new System.Windows.Forms.Button();
			this.btnNum = new System.Windows.Forms.Button();
			this.btnHide = new System.Windows.Forms.Button();
			this.equation = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEnter = new System.Windows.Forms.Button();
			this.btnDot = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btnSubtract = new System.Windows.Forms.Button();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.btnBck = new System.Windows.Forms.Button();
			this.btnCLR = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.roundedPanel1 = new practiceLogin.roundedPanel();
			this.equationMini = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.roundedPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnShow);
			this.panel1.Controls.Add(this.btnNum1);
			this.panel1.Controls.Add(this.btnNum);
			this.panel1.Controls.Add(this.btnHide);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(310, 78);
			this.panel1.TabIndex = 0;
			// 
			// btnShow
			// 
			this.btnShow.FlatAppearance.BorderSize = 0;
			this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShow.Location = new System.Drawing.Point(2, 31);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(32, 22);
			this.btnShow.TabIndex = 1;
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.BtnShowClick);
			// 
			// btnNum1
			// 
			this.btnNum1.FlatAppearance.BorderSize = 0;
			this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum1.Location = new System.Drawing.Point(40, 51);
			this.btnNum1.Name = "btnNum1";
			this.btnNum1.Size = new System.Drawing.Size(32, 22);
			this.btnNum1.TabIndex = 1;
			this.btnNum1.UseVisualStyleBackColor = true;
			this.btnNum1.Click += new System.EventHandler(this.BtnNum1Click);
			// 
			// btnNum
			// 
			this.btnNum.FlatAppearance.BorderSize = 0;
			this.btnNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum.Location = new System.Drawing.Point(3, 51);
			this.btnNum.Name = "btnNum";
			this.btnNum.Size = new System.Drawing.Size(32, 22);
			this.btnNum.TabIndex = 1;
			this.btnNum.UseVisualStyleBackColor = true;
			this.btnNum.Click += new System.EventHandler(this.BtnNumClick);
			// 
			// btnHide
			// 
			this.btnHide.FlatAppearance.BorderSize = 0;
			this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHide.Location = new System.Drawing.Point(3, 3);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(32, 22);
			this.btnHide.TabIndex = 1;
			this.btnHide.UseVisualStyleBackColor = true;
			this.btnHide.Click += new System.EventHandler(this.BtnHideClick);
			// 
			// equation
			// 
			this.equation.BackColor = System.Drawing.Color.Transparent;
			this.equation.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equation.Location = new System.Drawing.Point(0, 0);
			this.equation.MaximumSize = new System.Drawing.Size(302, 78);
			this.equation.MinimumSize = new System.Drawing.Size(302, 78);
			this.equation.Name = "equation";
			this.equation.Size = new System.Drawing.Size(302, 78);
			this.equation.TabIndex = 0;
			this.equation.Text = "0";
			this.equation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.equation.TextChanged += new System.EventHandler(this.EquationTextChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btn1);
			this.panel2.Controls.Add(this.btn4);
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Controls.Add(this.btnEnter);
			this.panel2.Controls.Add(this.btnDot);
			this.panel2.Controls.Add(this.btn3);
			this.panel2.Controls.Add(this.btn6);
			this.panel2.Controls.Add(this.btn2);
			this.panel2.Controls.Add(this.btn9);
			this.panel2.Controls.Add(this.btn5);
			this.panel2.Controls.Add(this.btn8);
			this.panel2.Controls.Add(this.btn7);
			this.panel2.Controls.Add(this.btnSubtract);
			this.panel2.Controls.Add(this.btnMultiply);
			this.panel2.Controls.Add(this.btnDivide);
			this.panel2.Controls.Add(this.btnBck);
			this.panel2.Controls.Add(this.btnCLR);
			this.panel2.Controls.Add(this.btn0);
			this.panel2.Location = new System.Drawing.Point(12, 96);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(310, 379);
			this.panel2.TabIndex = 1;
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(3, 231);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(70, 70);
			this.btn1.TabIndex = 1;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btn4
			// 
			this.btn4.Location = new System.Drawing.Point(3, 155);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(70, 70);
			this.btn4.TabIndex = 1;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.Btn4Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Location = new System.Drawing.Point(231, 155);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(70, 69);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnEnter
			// 
			this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
			this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
			this.btnEnter.FlatAppearance.BorderSize = 0;
			this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnter.Location = new System.Drawing.Point(231, 230);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(70, 146);
			this.btnEnter.TabIndex = 1;
			this.btnEnter.Text = "ENT";
			this.btnEnter.UseVisualStyleBackColor = false;
			this.btnEnter.Click += new System.EventHandler(this.BtnEnterClick);
			// 
			// btnDot
			// 
			this.btnDot.Location = new System.Drawing.Point(155, 307);
			this.btnDot.Name = "btnDot";
			this.btnDot.Size = new System.Drawing.Size(70, 70);
			this.btnDot.TabIndex = 1;
			this.btnDot.Text = ".";
			this.btnDot.UseVisualStyleBackColor = true;
			this.btnDot.Click += new System.EventHandler(this.BtnDotClick);
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(155, 231);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(70, 70);
			this.btn3.TabIndex = 1;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.Btn3Click);
			// 
			// btn6
			// 
			this.btn6.Location = new System.Drawing.Point(155, 155);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(70, 70);
			this.btn6.TabIndex = 1;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.Btn6Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(79, 231);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(70, 70);
			this.btn2.TabIndex = 1;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn9
			// 
			this.btn9.Location = new System.Drawing.Point(155, 79);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(70, 70);
			this.btn9.TabIndex = 1;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.Btn9Click);
			// 
			// btn5
			// 
			this.btn5.Location = new System.Drawing.Point(79, 155);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(70, 70);
			this.btn5.TabIndex = 1;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.Btn5Click);
			// 
			// btn8
			// 
			this.btn8.Location = new System.Drawing.Point(79, 79);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(70, 70);
			this.btn8.TabIndex = 1;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.Btn8Click);
			// 
			// btn7
			// 
			this.btn7.Location = new System.Drawing.Point(3, 79);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(70, 70);
			this.btn7.TabIndex = 1;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.Btn7Click);
			// 
			// btnSubtract
			// 
			this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
			this.btnSubtract.FlatAppearance.BorderSize = 0;
			this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubtract.Location = new System.Drawing.Point(230, 79);
			this.btnSubtract.Name = "btnSubtract";
			this.btnSubtract.Size = new System.Drawing.Size(70, 70);
			this.btnSubtract.TabIndex = 1;
			this.btnSubtract.Text = "-";
			this.btnSubtract.UseVisualStyleBackColor = false;
			this.btnSubtract.Click += new System.EventHandler(this.BtnSubtractClick);
			// 
			// btnMultiply
			// 
			this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
			this.btnMultiply.FlatAppearance.BorderSize = 0;
			this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMultiply.Location = new System.Drawing.Point(230, 3);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.Size = new System.Drawing.Size(70, 70);
			this.btnMultiply.TabIndex = 1;
			this.btnMultiply.Text = "x";
			this.btnMultiply.UseVisualStyleBackColor = false;
			this.btnMultiply.Click += new System.EventHandler(this.BtnMultiplyClick);
			// 
			// btnDivide
			// 
			this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
			this.btnDivide.FlatAppearance.BorderSize = 0;
			this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDivide.Location = new System.Drawing.Point(154, 3);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(70, 70);
			this.btnDivide.TabIndex = 1;
			this.btnDivide.Text = "/";
			this.btnDivide.UseVisualStyleBackColor = false;
			this.btnDivide.Click += new System.EventHandler(this.BtnDivideClick);
			// 
			// btnBck
			// 
			this.btnBck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
			this.btnBck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
			this.btnBck.FlatAppearance.BorderSize = 0;
			this.btnBck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btnBck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBck.Location = new System.Drawing.Point(78, 3);
			this.btnBck.Name = "btnBck";
			this.btnBck.Size = new System.Drawing.Size(70, 70);
			this.btnBck.TabIndex = 1;
			this.btnBck.Text = "←";
			this.btnBck.UseVisualStyleBackColor = false;
			this.btnBck.Click += new System.EventHandler(this.BtnBckClick);
			// 
			// btnCLR
			// 
			this.btnCLR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
			this.btnCLR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
			this.btnCLR.FlatAppearance.BorderSize = 0;
			this.btnCLR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btnCLR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCLR.Location = new System.Drawing.Point(3, 3);
			this.btnCLR.Name = "btnCLR";
			this.btnCLR.Size = new System.Drawing.Size(70, 70);
			this.btnCLR.TabIndex = 1;
			this.btnCLR.Text = "CLR";
			this.btnCLR.UseVisualStyleBackColor = false;
			this.btnCLR.Click += new System.EventHandler(this.BtnCLRClick);
			// 
			// btn0
			// 
			this.btn0.Location = new System.Drawing.Point(3, 307);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(146, 70);
			this.btn0.TabIndex = 0;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.Btn0Click);
			// 
			// roundedPanel1
			// 
			this.roundedPanel1.BackColor = System.Drawing.Color.White;
			this.roundedPanel1.BorderColor = System.Drawing.Color.White;
			this.roundedPanel1.Controls.Add(this.equationMini);
			this.roundedPanel1.Controls.Add(this.equation);
			this.roundedPanel1.Edge = 20;
			this.roundedPanel1.Location = new System.Drawing.Point(12, 12);
			this.roundedPanel1.Name = "roundedPanel1";
			this.roundedPanel1.Size = new System.Drawing.Size(300, 78);
			this.roundedPanel1.TabIndex = 2;
			// 
			// equationMini
			// 
			this.equationMini.BackColor = System.Drawing.Color.Transparent;
			this.equationMini.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.equationMini.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.equationMini.Location = new System.Drawing.Point(194, 3);
			this.equationMini.Name = "equationMini";
			this.equationMini.Size = new System.Drawing.Size(100, 23);
			this.equationMini.TabIndex = 1;
			this.equationMini.Text = "0";
			this.equationMini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
			this.ClientSize = new System.Drawing.Size(324, 481);
			this.Controls.Add(this.roundedPanel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "windowsCalculator";
			this.TopMost = true;
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainFormHelpButtonClicked);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.roundedPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
