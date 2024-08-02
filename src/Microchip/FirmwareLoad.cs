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
	public class FirmwareLoad : Form
	{
		private IContainer components;

		[AccessedThroughProperty("FilenameLabel")]
		private Label _FilenameLabel;

		[AccessedThroughProperty("ProgramButton")]
		private Button _ProgramButton;

		[AccessedThroughProperty("LINARadioButton")]
		private RadioButton _LINARadioButton;

		[AccessedThroughProperty("PKSARadioButton")]
		private RadioButton _PKSARadioButton;

		[AccessedThroughProperty("FileNameTextBox")]
		private TextBox _FileNameTextBox;

		internal virtual Label FilenameLabel
		{
			get
			{
				return this._FilenameLabel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FilenameLabel = value;
			}
		}

		internal virtual TextBox FileNameTextBox
		{
			get
			{
				return this._FileNameTextBox;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FileNameTextBox = value;
			}
		}

		internal virtual RadioButton LINARadioButton
		{
			get
			{
				return this._LINARadioButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				FirmwareLoad firmwareLoad = this;
				EventHandler eventHandler = new EventHandler(firmwareLoad.RadioButton1_CheckedChanged);
				if (this._LINARadioButton != null)
				{
					this._LINARadioButton.CheckedChanged -= eventHandler;
				}
				this._LINARadioButton = value;
				if (this._LINARadioButton != null)
				{
					this._LINARadioButton.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual RadioButton PKSARadioButton
		{
			get
			{
				return this._PKSARadioButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				FirmwareLoad firmwareLoad = this;
				EventHandler eventHandler = new EventHandler(firmwareLoad.PKSARadioButton_CheckedChanged);
				if (this._PKSARadioButton != null)
				{
					this._PKSARadioButton.CheckedChanged -= eventHandler;
				}
				this._PKSARadioButton = value;
				if (this._PKSARadioButton != null)
				{
					this._PKSARadioButton.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual Button ProgramButton
		{
			get
			{
				return this._ProgramButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				FirmwareLoad firmwareLoad = this;
				EventHandler eventHandler = new EventHandler(firmwareLoad.ProgramButton_Click);
				if (this._ProgramButton != null)
				{
					this._ProgramButton.Click -= eventHandler;
				}
				this._ProgramButton = value;
				if (this._ProgramButton != null)
				{
					this._ProgramButton.Click += eventHandler;
				}
			}
		}

		public FirmwareLoad()
		{
			FirmwareLoad firmwareLoad = this;
			base.Load += new EventHandler(firmwareLoad.FirmwareLoad_Load);
			this.InitializeComponent();
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

		private void FirmwareLoad_Load(object sender, EventArgs e)
		{
			this.FileNameTextBox.Text = MyProject.Forms.Network.firmwarehex;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.FilenameLabel = new Label();
			this.ProgramButton = new Button();
			this.LINARadioButton = new RadioButton();
			this.PKSARadioButton = new RadioButton();
			this.FileNameTextBox = new TextBox();
			this.SuspendLayout();
			this.FilenameLabel.AutoSize = true;
			Label filenameLabel = this.FilenameLabel;
			Point point = new Point(12, 19);
			filenameLabel.Location = point;
			this.FilenameLabel.Name = "FilenameLabel";
			Label label = this.FilenameLabel;
			System.Drawing.Size size = new System.Drawing.Size(106, 13);
			label.Size = size;
			this.FilenameLabel.TabIndex = 0;
			this.FilenameLabel.Text = "HEX file to download";
			Button programButton = this.ProgramButton;
			point = new Point(68, 102);
			programButton.Location = point;
			this.ProgramButton.Name = "ProgramButton";
			Button button = this.ProgramButton;
			size = new System.Drawing.Size(161, 23);
			button.Size = size;
			this.ProgramButton.TabIndex = 1;
			this.ProgramButton.Text = "Select Device Type";
			this.ProgramButton.UseVisualStyleBackColor = true;
			this.LINARadioButton.AutoSize = true;
			RadioButton lINARadioButton = this.LINARadioButton;
			point = new Point(51, 70);
			lINARadioButton.Location = point;
			this.LINARadioButton.Name = "LINARadioButton";
			RadioButton radioButton = this.LINARadioButton;
			size = new System.Drawing.Size(85, 17);
			radioButton.Size = size;
			this.LINARadioButton.TabIndex = 2;
			this.LINARadioButton.TabStop = true;
			this.LINARadioButton.Text = "LIN Analyser";
			this.LINARadioButton.UseVisualStyleBackColor = true;
			this.PKSARadioButton.AutoSize = true;
			RadioButton pKSARadioButton = this.PKSARadioButton;
			point = new Point(160, 70);
			pKSARadioButton.Location = point;
			this.PKSARadioButton.Name = "PKSARadioButton";
			RadioButton pKSARadioButton1 = this.PKSARadioButton;
			size = new System.Drawing.Size(53, 17);
			pKSARadioButton1.Size = size;
			this.PKSARadioButton.TabIndex = 3;
			this.PKSARadioButton.TabStop = true;
			this.PKSARadioButton.Text = "PKSA";
			this.PKSARadioButton.UseVisualStyleBackColor = true;
			TextBox fileNameTextBox = this.FileNameTextBox;
			point = new Point(15, 35);
			fileNameTextBox.Location = point;
			this.FileNameTextBox.Name = "FileNameTextBox";
			TextBox textBox = this.FileNameTextBox;
			size = new System.Drawing.Size(275, 20);
			textBox.Size = size;
			this.FileNameTextBox.TabIndex = 4;
			this.FileNameTextBox.Text = "No File Selected";
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(306, 148);
			this.ClientSize = size;
			this.Controls.Add(this.FileNameTextBox);
			this.Controls.Add(this.PKSARadioButton);
			this.Controls.Add(this.LINARadioButton);
			this.Controls.Add(this.ProgramButton);
			this.Controls.Add(this.FilenameLabel);
			this.Name = "FirmwareLoad";
			this.Text = "Download Firmware";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void PKSARadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.PKSARadioButton.Checked)
			{
				this.ProgramButton.Text = "Program";
			}
		}

		private void ProgramButton_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num1 = 0;
			string str = "";
			if (Operators.CompareString(this.ProgramButton.Text, "PROGRAM ERROR", false) == 0)
			{
				this.LINARadioButton.Checked = false;
				this.PKSARadioButton.Checked = false;
				this.ProgramButton.Text = "Select Device Type";
				this.FileNameTextBox.Text = "No File Selected";
				this.Close();
			}
			if (!this.LINARadioButton.Checked)
			{
				if (!this.PKSARadioButton.Checked)
				{
					this.ProgramButton.Text = "Select Type";
					return;
				}
				num1 = 1;
			}
			else
			{
				num1 = 2;
			}
			this.ProgramButton.Text = "Please Wait";
			Application.DoEvents();
			if (!Firmware.Load_Firmware(MyProject.Forms.Network.firmwarehex, num1, ref str, ref num))
			{
				MyProject.Forms.Network.StatusError.Text = str;
				this.ProgramButton.Text = "PROGRAM ERROR";
			}
			else
			{
				MyProject.Forms.Network.StatusError.Text = "Firmware Updated";
				this.ProgramButton.Text = "Program";
				if (num1 == 2)
				{
					if (!LIN.Configure_PICkitSerial_For_LIN())
					{
						MyProject.Forms.Network.StatusError.Text = "Error configuring APG Analyser for LIN";
						MyProject.Forms.Network.SelectedCOMport = -1;
					}
					else
					{
						Device.Set_Buffer_Flush_Parameters(true, true, 10, 10);
						MyProject.Forms.Network.StatusError.Text = "APG LIN Analyser correctly configured for LIN";
						MyProject.Forms.Network.SelectedCOMport = 0;
					}
				}
				else if (num1 != 1)
				{
					MyProject.Forms.Network.StatusError.Text = "Error initializing tool";
				}
				else if (!LIN.Configure_PICkitSerial_For_LIN())
				{
					MyProject.Forms.Network.StatusError.Text = "Error configuring PICkit Serial for LIN";
					MyProject.Forms.Network.SelectedCOMport = -1;
				}
				else
				{
					Device.Set_Buffer_Flush_Parameters(true, true, 10, 10);
					MyProject.Forms.Network.StatusError.Text = "PICkit Serial correctly configured for LIN";
					MyProject.Forms.Network.SelectedCOMport = 0;
				}
				this.Close();
			}
		}

		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.LINARadioButton.Checked)
			{
				this.ProgramButton.Text = "Program";
			}
		}
	}
}