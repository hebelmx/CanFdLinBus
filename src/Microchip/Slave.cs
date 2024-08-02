using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PICkitS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WindowsApplication1.My;

namespace WindowsApplication1
{
	[DesignerGenerated]
	public class Slave : Form
	{
		private IContainer components;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("forcedRadioButton")]
		private RadioButton _forcedRadioButton;

		[AccessedThroughProperty("enhancedRadioButton")]
		private RadioButton _enhancedRadioButton;

		[AccessedThroughProperty("classicRadioButton")]
		private RadioButton _classicRadioButton;

		[AccessedThroughProperty("MessageLstBox")]
		private ListBox _MessageLstBox;

		[AccessedThroughProperty("DeleteBtn")]
		private Button _DeleteBtn;

		[AccessedThroughProperty("Savebtn")]
		private Button _Savebtn;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[AccessedThroughProperty("EditBtn")]
		private Button _EditBtn;

		[AccessedThroughProperty("AddBtn")]
		private Button _AddBtn;

		[AccessedThroughProperty("CloseBtn")]
		private Button _CloseBtn;

		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		[AccessedThroughProperty("StatusError")]
		private ToolStripLabel _StatusError;

		[AccessedThroughProperty("BufferLabel")]
		private Label _BufferLabel;

		[AccessedThroughProperty("ClearBtn")]
		private Button _ClearBtn;

		public int selectedmessagepointer;

		internal virtual Button AddBtn
		{
			get
			{
				return this._AddBtn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Slave slave = this;
				EventHandler eventHandler = new EventHandler(slave.AddBtn_Click);
				if (this._AddBtn != null)
				{
					this._AddBtn.Click -= eventHandler;
				}
				this._AddBtn = value;
				if (this._AddBtn != null)
				{
					this._AddBtn.Click += eventHandler;
				}
			}
		}

		internal virtual Label BufferLabel
		{
			get
			{
				return this._BufferLabel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BufferLabel = value;
			}
		}

		internal virtual RadioButton classicRadioButton
		{
			get
			{
				return this._classicRadioButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._classicRadioButton = value;
			}
		}

		internal virtual Button ClearBtn
		{
			get
			{
				return this._ClearBtn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Slave slave = this;
				EventHandler eventHandler = new EventHandler(slave.ClearBtn_Click);
				if (this._ClearBtn != null)
				{
					this._ClearBtn.Click -= eventHandler;
				}
				this._ClearBtn = value;
				if (this._ClearBtn != null)
				{
					this._ClearBtn.Click += eventHandler;
				}
			}
		}

		internal virtual Button CloseBtn
		{
			get
			{
				return this._CloseBtn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Slave slave = this;
				EventHandler eventHandler = new EventHandler(slave.CloseBtn_Click);
				if (this._CloseBtn != null)
				{
					this._CloseBtn.Click -= eventHandler;
				}
				this._CloseBtn = value;
				if (this._CloseBtn != null)
				{
					this._CloseBtn.Click += eventHandler;
				}
			}
		}

		internal virtual Button DeleteBtn
		{
			get
			{
				return this._DeleteBtn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Slave slave = this;
				EventHandler eventHandler = new EventHandler(slave.DeleteBtn_Click);
				if (this._DeleteBtn != null)
				{
					this._DeleteBtn.Click -= eventHandler;
				}
				this._DeleteBtn = value;
				if (this._DeleteBtn != null)
				{
					this._DeleteBtn.Click += eventHandler;
				}
			}
		}

		internal virtual Button EditBtn
		{
			get
			{
				return this._EditBtn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Slave slave = this;
				EventHandler eventHandler = new EventHandler(slave.EditBtn_Click);
				if (this._EditBtn != null)
				{
					this._EditBtn.Click -= eventHandler;
				}
				this._EditBtn = value;
				if (this._EditBtn != null)
				{
					this._EditBtn.Click += eventHandler;
				}
			}
		}

		internal virtual RadioButton enhancedRadioButton
		{
			get
			{
				return this._enhancedRadioButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._enhancedRadioButton = value;
			}
		}

		internal virtual RadioButton forcedRadioButton
		{
			get
			{
				return this._forcedRadioButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._forcedRadioButton = value;
			}
		}

		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
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

		internal virtual ListBox MessageLstBox
		{
			get
			{
				return this._MessageLstBox;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Slave slave = this;
				EventHandler eventHandler = new EventHandler(slave.MessageLstBox_Click);
				if (this._MessageLstBox != null)
				{
					this._MessageLstBox.Click -= eventHandler;
				}
				this._MessageLstBox = value;
				if (this._MessageLstBox != null)
				{
					this._MessageLstBox.Click += eventHandler;
				}
			}
		}

		internal virtual Button Savebtn
		{
			get
			{
				return this._Savebtn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Slave slave = this;
				EventHandler eventHandler = new EventHandler(slave.Savebtn_Click);
				if (this._Savebtn != null)
				{
					this._Savebtn.Click -= eventHandler;
				}
				this._Savebtn = value;
				if (this._Savebtn != null)
				{
					this._Savebtn.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripLabel StatusError
		{
			get
			{
				return this._StatusError;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StatusError = value;
			}
		}

		internal virtual ToolStrip ToolStrip1
		{
			get
			{
				return this._ToolStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		internal virtual ToolTip ToolTip1
		{
			get
			{
				return this._ToolTip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		public Slave()
		{
			Slave slave = this;
			base.Load += new EventHandler(slave.Slave_Load);
			this.InitializeComponent();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			string str = Interaction.InputBox("Enter LIN meesage, ID first, byte separated by spaces", "LIN Message", "", -1, -1);
			if (Operators.CompareString(str, "", false) != 0)
			{
				this.MessageLstBox.Items.Insert(this.MessageLstBox.Items.Count, str);
				this.MessageLstBox.SelectedIndex = -1;
				this.MessageLstBox.SelectedValue = null;
			}
		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			byte num = 0;
			byte num1 = 0;
			Basic.Configure_PICkitSerial_For_LIN();
			LIN.Number_Of_Bytes_In_CBUF3(ref num1, ref num);
			this.BufferLabel.Text = string.Concat("Buffer Bytes Used: ", num1.ToString(), " Left: ", num.ToString());
			this.MessageLstBox.Items.Clear();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			while (this.MessageLstBox.SelectedIndex != -1)
			{
				this.MessageLstBox.Items.Remove(RuntimeHelpers.GetObjectValue(this.MessageLstBox.SelectedItem));
			}
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

		private void EditBtn_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.MessageLstBox.SelectedIndex;
			string str = Interaction.InputBox("Edit LIN meesage, ID first, byte separated by spaces", "LIN Message", Conversions.ToString(this.MessageLstBox.SelectedItem), -1, -1);
			if (Operators.CompareString(str, "", false) != 0)
			{
				this.MessageLstBox.Items.Remove(RuntimeHelpers.GetObjectValue(this.MessageLstBox.SelectedItem));
				this.MessageLstBox.Items.Insert(selectedIndex, str);
			}
			this.MessageLstBox.SelectedIndex = -1;
			this.MessageLstBox.SelectedValue = null;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.GroupBox1 = new GroupBox();
			this.ClearBtn = new Button();
			this.EditBtn = new Button();
			this.AddBtn = new Button();
			this.forcedRadioButton = new RadioButton();
			this.enhancedRadioButton = new RadioButton();
			this.classicRadioButton = new RadioButton();
			this.MessageLstBox = new ListBox();
			this.DeleteBtn = new Button();
			this.Savebtn = new Button();
			this.Label9 = new Label();
			this.Label8 = new Label();
			this.GroupBox2 = new GroupBox();
			this.ToolTip1 = new ToolTip(this.components);
			this.CloseBtn = new Button();
			this.ToolStrip1 = new ToolStrip();
			this.StatusError = new ToolStripLabel();
			this.BufferLabel = new Label();
			this.GroupBox1.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			this.GroupBox1.BackColor = SystemColors.ControlLightLight;
			this.GroupBox1.Controls.Add(this.ClearBtn);
			this.GroupBox1.Controls.Add(this.EditBtn);
			this.GroupBox1.Controls.Add(this.AddBtn);
			this.GroupBox1.Controls.Add(this.forcedRadioButton);
			this.GroupBox1.Controls.Add(this.enhancedRadioButton);
			this.GroupBox1.Controls.Add(this.classicRadioButton);
			this.GroupBox1.Controls.Add(this.MessageLstBox);
			this.GroupBox1.Controls.Add(this.DeleteBtn);
			this.GroupBox1.Controls.Add(this.Savebtn);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.GroupBox2);
			GroupBox groupBox1 = this.GroupBox1;
			Point point = new Point(11, 42);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = this.GroupBox1;
			System.Drawing.Size size = new System.Drawing.Size(423, 163);
			groupBox.Size = size;
			this.GroupBox1.TabIndex = 28;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Slave Response  Frames";
			this.ClearBtn.BackColor = SystemColors.Control;
			Button clearBtn = this.ClearBtn;
			point = new Point(248, 131);
			clearBtn.Location = point;
			this.ClearBtn.Name = "ClearBtn";
			Button button = this.ClearBtn;
			size = new System.Drawing.Size(72, 23);
			button.Size = size;
			this.ClearBtn.TabIndex = 35;
			this.ClearBtn.Text = "Clear All";
			this.ToolTip1.SetToolTip(this.ClearBtn, "This removes all slave profiles");
			this.ClearBtn.UseVisualStyleBackColor = false;
			this.EditBtn.BackColor = SystemColors.Control;
			this.EditBtn.ForeColor = SystemColors.ControlText;
			Button editBtn = this.EditBtn;
			point = new Point(248, 78);
			editBtn.Location = point;
			this.EditBtn.Name = "EditBtn";
			Button editBtn1 = this.EditBtn;
			size = new System.Drawing.Size(72, 23);
			editBtn1.Size = size;
			this.EditBtn.TabIndex = 34;
			this.EditBtn.Text = "Edit";
			this.ToolTip1.SetToolTip(this.EditBtn, "Edit message frame");
			this.EditBtn.UseVisualStyleBackColor = false;
			this.AddBtn.BackColor = SystemColors.Control;
			this.AddBtn.ForeColor = SystemColors.ControlText;
			Button addBtn = this.AddBtn;
			point = new Point(248, 50);
			addBtn.Location = point;
			this.AddBtn.Name = "AddBtn";
			Button addBtn1 = this.AddBtn;
			size = new System.Drawing.Size(72, 23);
			addBtn1.Size = size;
			this.AddBtn.TabIndex = 33;
			this.AddBtn.Text = "Add";
			this.ToolTip1.SetToolTip(this.AddBtn, "Add a new frame");
			this.AddBtn.UseVisualStyleBackColor = false;
			this.forcedRadioButton.AutoSize = true;
			this.forcedRadioButton.Enabled = false;
			RadioButton radioButton = this.forcedRadioButton;
			point = new Point(333, 101);
			radioButton.Location = point;
			this.forcedRadioButton.Name = "forcedRadioButton";
			RadioButton radioButton1 = this.forcedRadioButton;
			size = new System.Drawing.Size(55, 17);
			radioButton1.Size = size;
			this.forcedRadioButton.TabIndex = 23;
			this.forcedRadioButton.TabStop = true;
			this.forcedRadioButton.Text = "forced";
			this.forcedRadioButton.UseVisualStyleBackColor = true;
			this.enhancedRadioButton.AutoSize = true;
			RadioButton radioButton2 = this.enhancedRadioButton;
			point = new Point(333, 78);
			radioButton2.Location = point;
			this.enhancedRadioButton.Name = "enhancedRadioButton";
			RadioButton radioButton3 = this.enhancedRadioButton;
			size = new System.Drawing.Size(73, 17);
			radioButton3.Size = size;
			this.enhancedRadioButton.TabIndex = 22;
			this.enhancedRadioButton.TabStop = true;
			this.enhancedRadioButton.Text = "enhanced";
			this.enhancedRadioButton.UseVisualStyleBackColor = true;
			this.classicRadioButton.AutoSize = true;
			this.classicRadioButton.Checked = true;
			RadioButton radioButton4 = this.classicRadioButton;
			point = new Point(333, 56);
			radioButton4.Location = point;
			this.classicRadioButton.Name = "classicRadioButton";
			RadioButton radioButton5 = this.classicRadioButton;
			size = new System.Drawing.Size(57, 17);
			radioButton5.Size = size;
			this.classicRadioButton.TabIndex = 21;
			this.classicRadioButton.TabStop = true;
			this.classicRadioButton.Text = "classic";
			this.classicRadioButton.UseVisualStyleBackColor = true;
			this.MessageLstBox.Font = new System.Drawing.Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.MessageLstBox.FormattingEnabled = true;
			this.MessageLstBox.ItemHeight = 14;
			ListBox messageLstBox = this.MessageLstBox;
			point = new Point(8, 40);
			messageLstBox.Location = point;
			this.MessageLstBox.Name = "MessageLstBox";
			this.MessageLstBox.ScrollAlwaysVisible = true;
			this.MessageLstBox.SelectionMode = SelectionMode.MultiExtended;
			ListBox listBox = this.MessageLstBox;
			size = new System.Drawing.Size(232, 102);
			listBox.Size = size;
			this.MessageLstBox.TabIndex = 14;
			this.ToolTip1.SetToolTip(this.MessageLstBox, "Click in blank area to add\r\nnew message frame\r\n");
			this.DeleteBtn.BackColor = SystemColors.Control;
			this.DeleteBtn.ForeColor = SystemColors.ControlText;
			Button deleteBtn = this.DeleteBtn;
			point = new Point(248, 104);
			deleteBtn.Location = point;
			this.DeleteBtn.Name = "DeleteBtn";
			Button deleteBtn1 = this.DeleteBtn;
			size = new System.Drawing.Size(72, 23);
			deleteBtn1.Size = size;
			this.DeleteBtn.TabIndex = 17;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = false;
			this.Savebtn.BackColor = SystemColors.Control;
			Button savebtn = this.Savebtn;
			point = new Point(248, 15);
			savebtn.Location = point;
			this.Savebtn.Name = "Savebtn";
			Button savebtn1 = this.Savebtn;
			size = new System.Drawing.Size(72, 23);
			savebtn1.Size = size;
			this.Savebtn.TabIndex = 5;
			this.Savebtn.Text = "Save";
			this.ToolTip1.SetToolTip(this.Savebtn, "Save slave frames to analyser");
			this.Savebtn.UseVisualStyleBackColor = false;
			this.Label9.AutoSize = true;
			Label label9 = this.Label9;
			point = new Point(89, 15);
			label9.Location = point;
			this.Label9.Name = "Label9";
			Label label = this.Label9;
			size = new System.Drawing.Size(30, 13);
			label.Size = size;
			this.Label9.TabIndex = 16;
			this.Label9.Text = "Data";
			this.Label8.AutoSize = true;
			Label label8 = this.Label8;
			point = new Point(15, 15);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label81 = this.Label8;
			size = new System.Drawing.Size(18, 13);
			label81.Size = size;
			this.Label8.TabIndex = 15;
			this.Label8.Text = "ID";
			GroupBox groupBox2 = this.GroupBox2;
			point = new Point(326, 40);
			groupBox2.Location = point;
			this.GroupBox2.Name = "GroupBox2";
			GroupBox groupBox21 = this.GroupBox2;
			size = new System.Drawing.Size(89, 85);
			groupBox21.Size = size;
			this.GroupBox2.TabIndex = 24;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Checksum";
			Button closeBtn = this.CloseBtn;
			point = new Point(368, 12);
			closeBtn.Location = point;
			this.CloseBtn.Name = "CloseBtn";
			Button closeBtn1 = this.CloseBtn;
			size = new System.Drawing.Size(76, 24);
			closeBtn1.Size = size;
			this.CloseBtn.TabIndex = 29;
			this.CloseBtn.Text = "Close";
			this.CloseBtn.UseVisualStyleBackColor = true;
			this.ToolStrip1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.ToolStrip1.Dock = DockStyle.None;
			this.ToolStrip1.Items.AddRange(new ToolStripItem[] { this.StatusError });
			ToolStrip toolStrip1 = this.ToolStrip1;
			point = new Point(11, 208);
			toolStrip1.Location = point;
			this.ToolStrip1.Name = "ToolStrip1";
			ToolStrip toolStrip = this.ToolStrip1;
			size = new System.Drawing.Size(47, 25);
			toolStrip.Size = size;
			this.ToolStrip1.TabIndex = 30;
			this.ToolStrip1.Text = "ToolStrip1";
			this.StatusError.Name = "StatusError";
			ToolStripLabel statusError = this.StatusError;
			size = new System.Drawing.Size(37, 22);
			statusError.Size = size;
			this.StatusError.Text = "Status";
			this.BufferLabel.AutoSize = true;
			Label bufferLabel = this.BufferLabel;
			point = new Point(8, 18);
			bufferLabel.Location = point;
			this.BufferLabel.Name = "BufferLabel";
			Label bufferLabel1 = this.BufferLabel;
			size = new System.Drawing.Size(35, 13);
			bufferLabel1.Size = size;
			this.BufferLabel.TabIndex = 35;
			this.BufferLabel.Text = "Buffer";
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(446, 238);
			this.ClientSize = size;
			this.Controls.Add(this.BufferLabel);
			this.Controls.Add(this.ToolStrip1);
			this.Controls.Add(this.CloseBtn);
			this.Controls.Add(this.GroupBox1);
			this.Name = "Slave";
			this.Text = "Slave Response";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void MessageLstBox_Click(object sender, EventArgs e)
		{
			ListBox.SelectedIndexCollection selectedIndices = this.MessageLstBox.SelectedIndices;
			if (this.MessageLstBox.SelectedIndex == this.MessageLstBox.Items.Count | this.MessageLstBox.SelectedIndex == -1)
			{
				string str = Interaction.InputBox("Enter LIN meesage, ID first, byte separated by spaces", "LIN Message", "", -1, -1);
				if (Operators.CompareString(str, "", false) != 0)
				{
					this.MessageLstBox.Items.Insert(this.MessageLstBox.Items.Count, str);
					selectedIndices.Clear();
					this.MessageLstBox.SelectedIndex = checked(this.MessageLstBox.Items.Count - 2);
				}
			}
		}

		private void Savebtn_Click(object sender, EventArgs e)
		{
			int num = 0;
			byte num1 = 0;
			byte num2 = 0;
			byte num3 = 0;
			byte[] numArray = new byte[256];
			string str = "";
			int num4 = 0;
			string str1 = "";
			ListBox.SelectedObjectCollection selectedItems = this.MessageLstBox.SelectedItems;
			if (selectedItems.Count <= 0)
			{
				this.StatusError.Text = "Error: No slave profile(s) selected";
			}
			else
			{
				int num5 = 0;
				while (this.MessageLstBox.SelectedIndex != -1 & num4 < selectedItems.Count)
				{
					int num6 = 0;
					int num7 = 0;
					str1 = Strings.Trim(Conversions.ToString(selectedItems[num4]));
					num4 = checked(num4 + 1);
					char[] charArray = str1.ToCharArray();
					int length = checked(checked((int)charArray.Length) - 1);
					int num8 = 0;
					while (num8 <= length)
					{
						str1 = "&H";
						while (Uri.IsHexDigit(charArray[num8]))
						{
							if (charArray[num8] != '\0')
							{
								str1 = string.Concat(str1, Conversions.ToString(charArray[num8]));
								if (num8 == checked(checked((int)charArray.Length) - 1))
								{
									break;
								}
								num8 = checked(num8 + 1);
							}
							else
							{
								break;
							}
						}
						if (num7 < 10)
						{
							if (num7 == 0)
							{
								num1 = checked((byte)Math.Round(Conversion.Val(str1)));
							}
							else
							{
								numArray[checked(checked(num7 + num5) + 1)] = checked((byte)Math.Round(Conversion.Val(str1)));
								num6 = checked(num6 + numArray[checked(checked(num7 + num5) + 1)]);
								if (num6 >= 256)
								{
									num6 = checked(num6 - 255);
								}
							}
							num7 = checked(num7 + 1);
						}
						if (charArray[num8] != '\0')
						{
							num8 = checked(num8 + 1);
						}
						else
						{
							break;
						}
					}
					int num9 = 144;
					num1 = MyProject.Forms.Network.GenParityBits(num1);
					if (this.enhancedRadioButton.Checked)
					{
						num9 = checked(num9 + 32);
					}
					if (this.forcedRadioButton.Checked)
					{
						num9 = checked(num9 + 64);
					}
					num9 = checked(num9 + (checked(num7 - 1)));
					numArray[num5] = checked((byte)num9);
					numArray[checked(num5 + 1)] = num1;
					num5 = checked(checked(num5 + num7) + 1);
				}
				this.StatusError.Text = "Slave Frame ";
				if (!LIN.Add_LIN_Slave_Profile_To_PKS(checked((byte)(checked(num5 + 1))), ref numArray, ref str, ref num))
				{
					if (num == 1)
					{
						this.StatusError.Text = "Error: Slave buffer full";
					}
					if (num == 2)
					{
						this.StatusError.Text = "Error: Write error";
					}
					if (num == 3)
					{
						this.StatusError.Text = "Error: Verification error";
					}
				}
				else
				{
					this.StatusError.Text = "Write successful";
				}
				LIN.Number_Of_Bytes_In_CBUF3(ref num3, ref num2);
				this.BufferLabel.Text = string.Concat("Buffer Bytes Used: ", num3.ToString(), " Left: ", num2.ToString());
			}
		}

		private void Slave_Load(object sender, EventArgs e)
		{
			byte num = 0;
			byte num1 = 0;
			LIN.Number_Of_Bytes_In_CBUF3(ref num1, ref num);
			this.BufferLabel.Text = string.Concat("Buffer Bytes Used: ", num1.ToString(), " Left: ", num.ToString());
		}
	}
}