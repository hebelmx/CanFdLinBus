using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsApplication1.My;

namespace WindowsApplication1
{
	[DesignerGenerated]
	public class Filters : Form
	{
		private IContainer components;

		[AccessedThroughProperty("RichTextBox1")]
		private RichTextBox _RichTextBox1;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("RichTextBox2")]
		private RichTextBox _RichTextBox2;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		private RichTextBox temp_textbox2;

		public const int WM_VSCROLL = 277;

		public const int SB_BOTTOM = 7;

		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Filters filter = this;
				EventHandler eventHandler = new EventHandler(filter.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		internal virtual Label Label8
		{
			get
			{
				return this._Label8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		internal virtual Label Label9
		{
			get
			{
				return this._Label9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		internal virtual RichTextBox RichTextBox1
		{
			get
			{
				return this._RichTextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RichTextBox1 = value;
			}
		}

		internal virtual RichTextBox RichTextBox2
		{
			get
			{
				return this._RichTextBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RichTextBox2 = value;
			}
		}

		public Filters()
		{
			Filters filter = this;
			base.Load += new EventHandler(filter.Filters_Load);
			this.temp_textbox2 = new RichTextBox();
			this.InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Filters_Load(object sender, EventArgs e)
		{
			byte num = 0;
			num = 0;
			string[] lines = this.RichTextBox1.Lines;
			this.RichTextBox1.Text = "";
			lines[num] = "";
			num = 0;
			do
			{
				this.RichTextBox1.Text = string.Concat(this.RichTextBox1.Text, "\r\n");
				num = (void*)(checked((byte)(num + 1)));
			}
			while (num <= 30);
			this.RichTextBox1.Text = this.RichTextBox1.Text;
			Filters.SendMessage(this.RichTextBox1.Handle, 277, (IntPtr)7, (IntPtr)0);
			num = 0;
			lines = this.RichTextBox2.Lines;
			this.RichTextBox2.Text = "";
			lines[num] = "";
			num = 0;
			do
			{
				this.RichTextBox2.Text = string.Concat(this.RichTextBox2.Text, "\r\n");
				num = (void*)(checked((byte)(num + 1)));
			}
			while (num <= 30);
			this.RichTextBox2.Text = this.RichTextBox2.Text;
			Filters.SendMessage(this.RichTextBox2.Handle, 277, (IntPtr)7, (IntPtr)0);
		}

		public bool FindMyText(string text)
		{
			bool flag = false;
			if (text.Length > 0 && this.RichTextBox1.Find(text) >= 0)
			{
				flag = true;
			}
			return flag;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.RichTextBox1 = new RichTextBox();
			this.Label4 = new Label();
			this.Label3 = new Label();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.Button1 = new Button();
			this.RichTextBox2 = new RichTextBox();
			this.Label5 = new Label();
			this.Label6 = new Label();
			this.Label7 = new Label();
			this.Label8 = new Label();
			this.Label9 = new Label();
			this.SuspendLayout();
			this.RichTextBox1.Font = new System.Drawing.Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.RichTextBox1.ForeColor = SystemColors.WindowText;
			RichTextBox richTextBox1 = this.RichTextBox1;
			Point point = new Point(3, 54);
			richTextBox1.Location = point;
			this.RichTextBox1.Name = "RichTextBox1";
			RichTextBox richTextBox = this.RichTextBox1;
			System.Drawing.Size size = new System.Drawing.Size(388, 456);
			richTextBox.Size = size;
			this.RichTextBox1.TabIndex = 0;
			this.RichTextBox1.Text = "0\n1\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30\n31";
			this.Label4.AutoSize = true;
			Label label4 = this.Label4;
			point = new Point(334, 38);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label = this.Label4;
			size = new System.Drawing.Size(57, 13);
			label.Size = size;
			this.Label4.TabIndex = 17;
			this.Label4.Text = "Checksum";
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(197, 38);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(30, 13);
			label31.Size = size;
			this.Label3.TabIndex = 16;
			this.Label3.Text = "Data";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(88, 38);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(18, 13);
			label21.Size = size;
			this.Label2.TabIndex = 15;
			this.Label2.Text = "ID";
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			point = new Point(12, 38);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(60, 13);
			label11.Size = size;
			this.Label1.TabIndex = 14;
			this.Label1.Text = "TimeStamp";
			Button button1 = this.Button1;
			point = new Point(702, 11);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new System.Drawing.Size(76, 24);
			button.Size = size;
			this.Button1.TabIndex = 21;
			this.Button1.Text = "Close";
			this.Button1.UseVisualStyleBackColor = true;
			this.RichTextBox2.Font = new System.Drawing.Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.RichTextBox2.ForeColor = SystemColors.WindowText;
			RichTextBox richTextBox2 = this.RichTextBox2;
			point = new Point(397, 54);
			richTextBox2.Location = point;
			this.RichTextBox2.Name = "RichTextBox2";
			RichTextBox richTextBox21 = this.RichTextBox2;
			size = new System.Drawing.Size(388, 456);
			richTextBox21.Size = size;
			this.RichTextBox2.TabIndex = 22;
			this.RichTextBox2.Text = "32\n33\n34\n35\n36\n37\n38\n39\n40\n41\n42\n43\n44\n45\n46\n47\n48\n48\n50\n51\n52\n53\n54\n55\n56\n57\n58\n59\n60\n61\n62\n63";
			this.Label5.AutoSize = true;
			Label label5 = this.Label5;
			point = new Point(729, 38);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(57, 13);
			label51.Size = size;
			this.Label5.TabIndex = 26;
			this.Label5.Text = "Checksum";
			this.Label6.AutoSize = true;
			Label label6 = this.Label6;
			point = new Point(592, 38);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(30, 13);
			label61.Size = size;
			this.Label6.TabIndex = 25;
			this.Label6.Text = "Data";
			this.Label7.AutoSize = true;
			Label label7 = this.Label7;
			point = new Point(483, 38);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label71 = this.Label7;
			size = new System.Drawing.Size(18, 13);
			label71.Size = size;
			this.Label7.TabIndex = 24;
			this.Label7.Text = "ID";
			this.Label8.AutoSize = true;
			Label label8 = this.Label8;
			point = new Point(407, 38);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label81 = this.Label8;
			size = new System.Drawing.Size(60, 13);
			label81.Size = size;
			this.Label8.TabIndex = 23;
			this.Label8.Text = "TimeStamp";
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label9 = this.Label9;
			point = new Point(41, 17);
			label9.Location = point;
			this.Label9.Name = "Label9";
			Label label91 = this.Label9;
			size = new System.Drawing.Size(162, 13);
			label91.Size = size;
			this.Label9.TabIndex = 27;
			this.Label9.Text = "Messages are sorted by ID ";
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(790, 520);
			this.ClientSize = size;
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.RichTextBox2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.RichTextBox1);
			this.Name = "Filters";
			this.Text = "Filtered Messages";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		[DllImport("user32.dll", CharSet=CharSet.Auto, ExactSpelling=false, SetLastError=true)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

		public void UpdateFilterBox(string pText, Color pColor)
		{
			string[] lines;
			if (this.InvokeRequired)
			{
				Filters filter = this;
				Filters.Threaded_Textbox_Update threadedTextboxUpdate = new Filters.Threaded_Textbox_Update(filter.UpdateFilterBox);
				object[] objArray = new object[] { pText, pColor };
				this.BeginInvoke(threadedTextboxUpdate, objArray);
				return;
			}
			int filterID = MyProject.Forms.Network.FilterID;
			filterID &= 63;
			if (filterID >= 32)
			{
				filterID = checked(filterID - 32);
				lines = this.RichTextBox2.Lines;
				this.RichTextBox2.Text = "";
				this.temp_textbox2.Rtf = pText;
				this.temp_textbox2.SelectAll();
				this.temp_textbox2.SelectionColor = Color.Black;
				this.temp_textbox2.SelectionFont = this.RichTextBox1.Font;
				lines[filterID] = this.temp_textbox2.SelectedText;
				lines[filterID] = Strings.Left(lines[filterID], 54);
				filterID = 0;
				do
				{
					this.RichTextBox2.Text = string.Concat(this.RichTextBox2.Text, lines[filterID], "\r\n");
					filterID = checked(filterID + 1);
				}
				while (filterID <= 30);
				this.RichTextBox2.Text = string.Concat(this.RichTextBox2.Text, lines[31]);
				Filters.SendMessage(this.RichTextBox2.Handle, 277, (IntPtr)7, (IntPtr)0);
			}
			else
			{
				lines = this.RichTextBox1.Lines;
				this.RichTextBox1.Text = "";
				this.temp_textbox2.Rtf = pText;
				this.temp_textbox2.SelectAll();
				this.temp_textbox2.SelectionColor = Color.Black;
				this.temp_textbox2.SelectionFont = this.RichTextBox1.Font;
				lines[filterID] = this.temp_textbox2.SelectedText;
				lines[filterID] = Strings.Left(lines[filterID], 54);
				filterID = 0;
				do
				{
					this.RichTextBox1.Text = string.Concat(this.RichTextBox1.Text, lines[filterID], "\r\n");
					filterID = checked(filterID + 1);
				}
				while (filterID <= 30);
				this.RichTextBox1.Text = string.Concat(this.RichTextBox1.Text, lines[31]);
				Filters.SendMessage(this.RichTextBox1.Handle, 277, (IntPtr)7, (IntPtr)0);
			}
		}

		public delegate void Threaded_Textbox_Update(string pText, Color pColor);
	}
}