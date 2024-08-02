using Microsoft.VisualBasic.CompilerServices;
using PICkitS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsApplication1
{
	[DesignerGenerated]
	public class AboutForm : Form
	{
		private IContainer components;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("DLLversion")]
		private Label _DLLversion;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("FirmwareVersion")]
		private Label _FirmwareVersion;

		internal virtual Label DLLversion
		{
			get
			{
				return this._DLLversion;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				AboutForm aboutForm = this;
				EventHandler eventHandler = new EventHandler(aboutForm.DLLversion_Click);
				if (this._DLLversion != null)
				{
					this._DLLversion.Click -= eventHandler;
				}
				this._DLLversion = value;
				if (this._DLLversion != null)
				{
					this._DLLversion.Click += eventHandler;
				}
			}
		}

		internal virtual Label FirmwareVersion
		{
			get
			{
				return this._FirmwareVersion;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				AboutForm aboutForm = this;
				EventHandler eventHandler = new EventHandler(aboutForm.FirmwareVersion_Click);
				if (this._FirmwareVersion != null)
				{
					this._FirmwareVersion.Click -= eventHandler;
				}
				this._FirmwareVersion = value;
				if (this._FirmwareVersion != null)
				{
					this._FirmwareVersion.Click += eventHandler;
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
				AboutForm aboutForm = this;
				EventHandler eventHandler = new EventHandler(aboutForm.Label5_Click);
				if (this._Label5 != null)
				{
					this._Label5.Click -= eventHandler;
				}
				this._Label5 = value;
				if (this._Label5 != null)
				{
					this._Label5.Click += eventHandler;
				}
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
				AboutForm aboutForm = this;
				EventHandler eventHandler = new EventHandler(aboutForm.Label6_Click);
				if (this._Label6 != null)
				{
					this._Label6.Click -= eventHandler;
				}
				this._Label6 = value;
				if (this._Label6 != null)
				{
					this._Label6.Click += eventHandler;
				}
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

		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		public AboutForm()
		{
			AboutForm aboutForm = this;
			base.Load += new EventHandler(aboutForm.AboutForm_Load);
			AboutForm aboutForm1 = this;
			base.Click += new EventHandler(aboutForm1.AboutForm_Click);
			this.InitializeComponent();
		}

		private void AboutForm_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			short num = 0;
			string str = "";
			string str1 = "";
			if (!Device.Get_PickitS_DLL_Version(ref str))
			{
				this.DLLversion.Text = "Can not find DLL";
			}
			else
			{
				this.DLLversion.Text = str;
			}
			ushort num1 = checked((ushort)num);
			bool pKSAFWVersion = Device.Get_PKSA_FW_Version(ref num1, ref str1);
			num = (void*)(checked((short)num1));
			if (!pKSAFWVersion)
			{
				this.FirmwareVersion.Text = "No Analyzer found";
			}
			else
			{
				this.FirmwareVersion.Text = str1;
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

		private void DLLversion_Click(object sender, EventArgs e)
		{
		}

		private void FirmwareVersion_Click(object sender, EventArgs e)
		{
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutForm));
			this.PictureBox1 = new PictureBox();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.Label3 = new Label();
			this.Label4 = new Label();
			this.Label5 = new Label();
			this.DLLversion = new Label();
			this.Label6 = new Label();
			this.Label7 = new Label();
			this.FirmwareVersion = new Label();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = this.PictureBox1;
			Point point = new Point(8, 16);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			System.Drawing.Size size = new System.Drawing.Size(240, 136);
			pictureBox.Size = size;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.Label1.Font = new System.Drawing.Font("Book Antiqua", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(256, 32);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			size = new System.Drawing.Size(309, 72);
			label.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "LIN Serial Analyzer Debug Tool";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			Label label2 = this.Label2;
			point = new Point(174, 244);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(222, 20);
			label21.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "For APG Internal Use Only";
			this.Label2.Visible = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label3 = this.Label3;
			point = new Point(192, 200);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(189, 16);
			label31.Size = size;
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Microchip Technology Inc.";
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label4 = this.Label4;
			point = new Point(176, 216);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(220, 15);
			label41.Size = size;
			this.Label4.TabIndex = 4;
			this.Label4.Text = "Copyright 2011 All Right reserved";
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label5 = this.Label5;
			point = new Point(272, 127);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(238, 25);
			label51.Size = size;
			this.Label5.TabIndex = 5;
			this.Label5.Text = "Release Version 2.05";
			this.DLLversion.AutoSize = true;
			this.DLLversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label dLLversion = this.DLLversion;
			point = new Point(409, 152);
			dLLversion.Location = point;
			this.DLLversion.Name = "DLLversion";
			Label dLLversion1 = this.DLLversion;
			size = new System.Drawing.Size(20, 16);
			dLLversion1.Size = size;
			this.DLLversion.TabIndex = 6;
			this.DLLversion.Text = "    ";
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label6 = this.Label6;
			point = new Point(259, 152);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(144, 16);
			label61.Size = size;
			this.Label6.TabIndex = 7;
			this.Label6.Text = "PICkitS.DLL version";
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label7 = this.Label7;
			point = new Point(259, 168);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label71 = this.Label7;
			size = new System.Drawing.Size(190, 16);
			label71.Size = size;
			this.Label7.TabIndex = 8;
			this.Label7.Text = "Analyzer Firmware version";
			this.FirmwareVersion.AutoSize = true;
			this.FirmwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label firmwareVersion = this.FirmwareVersion;
			point = new Point(450, 168);
			firmwareVersion.Location = point;
			this.FirmwareVersion.Name = "FirmwareVersion";
			Label firmwareVersion1 = this.FirmwareVersion;
			size = new System.Drawing.Size(20, 16);
			firmwareVersion1.Size = size;
			this.FirmwareVersion.TabIndex = 9;
			this.FirmwareVersion.Text = "    ";
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(577, 273);
			this.ClientSize = size;
			this.Controls.Add(this.FirmwareVersion);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.DLLversion);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.PictureBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.Text = "About USB to LIN";
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void Label5_Click(object sender, EventArgs e)
		{
		}

		private void Label6_Click(object sender, EventArgs e)
		{
		}
	}
}