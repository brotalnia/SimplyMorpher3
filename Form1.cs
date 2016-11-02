// Simply Morpher 3
// Original by NEM E5I5
// Improved and updated for Windows 10 by brotalnia
// Visit www.youtube.com/brotalnia for more stuff by me.
	
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GreyMagic;
using WoW.DirectX;
	
namespace SimplyMorpher
{
	public class Form1 : Form
	{
		private IContainer components;
		private Button button1;
		private Label label1;
		private Label label2;
		private TextBox textBox1;
		public TextBox textBox2;
		private Button button2;
		private ComboBox comboBox1;
		private Button button3;
		private RichTextBox rtxtLog;
		private Button button4;
		private Hook wowHook;
        private Button button5;
        private Button btnSearch;
        private int processid;
	
		public Form1()
		{
			this.InitializeComponent();
			Process[] processesByName = Process.GetProcessesByName("wow");
			this.comboBox1.Items.Clear();
			foreach (Process process in processesByName)
				this.comboBox1.Items.Add((object) Convert.ToString(process.Id));
			try
			{
				this.comboBox1.SelectedIndex = 0;
			}
			catch
			{
			}
			Log.Initialize(rtxtLog, this);
		}
	
		private void appli(object sender, EventArgs e)
		{
            if (comboBox1.Items.Count < 1 || textBox2.Text.Length < 1)
				return;
            if ((wowHook == null) || (processid < 1) || (processid != Convert.ToInt32(this.comboBox1.Items[this.comboBox1.SelectedIndex])))
            {
                processid = Convert.ToInt32(this.comboBox1.Items[this.comboBox1.SelectedIndex]);
                Process proc = System.Diagnostics.Process.GetProcessById(processid);
                Log.Write("Attaching to process with id " + processid.ToString() + ".");
                wowHook = new Hook(proc);
                wowHook.InstallHook();
            }
            Log.Write("Reading addresses.");
			uint num1 = wowHook.Memory.Read<uint>((IntPtr) 13469608U);
			uint num2 = wowHook.Memory.Read<uint>((IntPtr) (num1 + 52U));
			uint num3 = wowHook.Memory.Read<uint>((IntPtr) (num2 + 36U));
			uint num4 = num3;
			uint num5 = wowHook.Memory.Read<uint>((IntPtr) (num3 + 8U));
            Log.Write("Writing new size.");
			try
			{
				this.textBox1.Text = this.textBox1.Text.Replace(".", ",");
				if (this.button3.Text == "descriptor")
					wowHook.Memory.Write<float>((IntPtr) (num5 + 16U), float.Parse(this.textBox1.Text));
                if (this.button3.Text == "playerbase")
                    wowHook.Memory.Write<float>((IntPtr)(num4 + 156U), float.Parse(this.textBox1.Text));
                Log.Write("Writing new displayid.");
				wowHook.Memory.Write<uint>((IntPtr) (num5 + 268U), 621U);
				wowHook.InjectAndExecute(new string[8]
				{
					"mov eax, [0x0CD87A8]",
					"mov eax, [eax+0x034]",
					"mov eax, [eax+0x024]",
					"push 0",
					"mov ecx, eax",
					"mov esi, eax",
					"call 0x73E410",
					"retn"
				}, 0);
				wowHook.Memory.Write<uint>((IntPtr) (num5 + 268U), Convert.ToUInt32(this.textBox2.Text));
				wowHook.InjectAndExecute(new string[8]
				{
					"mov eax, [0x0CD87A8]",
					"mov eax, [eax+0x034]",
					"mov eax, [eax+0x024]",
					"push 0",
					"mov ecx, eax",
					"mov esi, eax",
					"call 0x73E410",
					"retn"
				}, 0);
                Log.Write(Color.Green, "Morphed to displayid " + this.textBox2.Text + ".");
			}
			catch
			{
				int num6 = (int) MessageBox.Show("Invalid values or process handle.", "Simply Morpher 3",MessageBoxButtons.OK ,MessageBoxIcon.Information);
			}
		}
		
		private void set(object sender, EventArgs e)
		{
            if (comboBox1.Items.Count < 1)
                return;
            if ((wowHook == null) || (processid < 1) || (processid != Convert.ToInt32(this.comboBox1.Items[this.comboBox1.SelectedIndex])))
            {
                processid = Convert.ToInt32(this.comboBox1.Items[this.comboBox1.SelectedIndex]);
                Process proc = System.Diagnostics.Process.GetProcessById(processid);
                Log.Write("Attaching to process with id " + processid.ToString() + ".");
                wowHook = new Hook(proc);
                wowHook.InstallHook();
            }
            Log.Write("Reading addresses.");
			uint num1 = wowHook.Memory.Read<uint> ((IntPtr) 13081824U);
			uint num2 = wowHook.Memory.Read<uint>((IntPtr) (num1 + 11984U));
			int num3 = wowHook.Memory.Read<int>((IntPtr) (num2 + 172U));
			uint num4 = 0U;
			int num5;
			for (; num3 != 0; num3 = num5)
			{
				if ((num3 & 1) == 0)
				{
					num5 = wowHook.Memory.Read<int> ((IntPtr) Convert.ToUInt32(num3 + 60));
					if ((long)wowHook.Memory.Read<UInt64>((IntPtr)Convert.ToUInt32(num3 + 48)) == (long)wowHook.Memory.Read<UInt64>((IntPtr) 12388272U))
						num4 = Convert.ToUInt32(num3);
					if (num5 == num3)
						break;
				}
				else
					break;
			}
			try
			{
				uint num6 = num4;
				uint num7 = wowHook.Memory.Read<uint>((IntPtr) (num4 + 8U));
				this.textBox2.Text = Convert.ToString(wowHook.Memory.Read<uint>((IntPtr) (num7 + 268U)));
                Log.Write(Color.Green, "Found value " + this.textBox2.Text + " at address " + (num7 + 268U).ToString("X4") + ".");
				if (this.button3.Text == "descriptor")
                {
					this.textBox1.Text = Convert.ToString(wowHook.Memory.Read<float>((IntPtr) (num7 + 16U)));
                    Log.Write(Color.Green, "Found value " + this.textBox1.Text + " at address " + (num7 + 16U).ToString("X4") + ".");
                }
				if (!(this.button3.Text == "playerbase"))
					return;
				this.textBox1.Text = Convert.ToString(wowHook.Memory.Read<float>((IntPtr) (num6 + 156U)));
                Log.Write(Color.Green, "Found value " + this.textBox1.Text + " at address " + (num6 + 156U).ToString("X4") + ".");
			}
			catch
			{
                int num6 = (int)MessageBox.Show("You have no target!", "Simply Morpher 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	
		private void hook(object sender, EventArgs e)
		{
			if (this.button3.Text == "descriptor")
			{
				this.button3.Text = "playerbase";
			}
			else
			{
				if (!(this.button3.Text == "playerbase"))
					return;
				this.button3.Text = "descriptor";
			}
		}
	
		private void load(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("wow");
			this.comboBox1.Items.Clear();
			foreach (Process process in processesByName)
				this.comboBox1.Items.Add((object) Convert.ToString(process.Id));
			try
			{
				this.comboBox1.SelectedIndex = 0;
			}
			catch
			{
			}
		}
	
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			if ((wowHook != null) && wowHook.Installed)
				wowHook.DisposeHooking();
			base.Dispose(disposing);
		}
	
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(5, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.appli);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "display id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(191, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "copy target";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.set);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "descriptor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.hook);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(125, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "reload";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.load);
            // 
            // rtxtLog
            // 
            this.rtxtLog.Location = new System.Drawing.Point(2, 94);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(265, 102);
            this.rtxtLog.TabIndex = 9;
            this.rtxtLog.Text = "";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(191, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "presets";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(5, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(268, 197);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simply Morpher 3";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void button5_Click(object sender, EventArgs e)
        {
            Presets frm = new Presets(textBox2.Text);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox2.Text = frm.ReturnValue;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Search))
                {
                    form.Activate();
                    return;
                }
            }
            Search srch = new Search(this);
            srch.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                appli(sender, e);
            }
        }
	}
}
	