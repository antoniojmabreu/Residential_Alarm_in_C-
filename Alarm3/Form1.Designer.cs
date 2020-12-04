namespace Alarm3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSetArm = new System.Windows.Forms.Button();
            this.timePickerArmar = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSetDisarm = new System.Windows.Forms.Button();
            this.timePickerDesarmar = new System.Windows.Forms.DateTimePicker();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.labelS2 = new System.Windows.Forms.Label();
            this.labelS1 = new System.Windows.Forms.Label();
            this.labelS3 = new System.Windows.Forms.Label();
            this.labelS4 = new System.Windows.Forms.Label();
            this.labelS5 = new System.Windows.Forms.Label();
            this.labelS5_text = new System.Windows.Forms.Label();
            this.labelS4_text = new System.Windows.Forms.Label();
            this.labelS3_text = new System.Windows.Forms.Label();
            this.labelS2_text = new System.Windows.Forms.Label();
            this.labelS1_text = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.labelOpenDevice = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSetArm);
            this.groupBox1.Controls.Add(this.timePickerArmar);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // buttonSetArm
            // 
            this.buttonSetArm.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.buttonSetArm, "buttonSetArm");
            this.buttonSetArm.Name = "buttonSetArm";
            this.buttonSetArm.UseVisualStyleBackColor = false;
            this.buttonSetArm.Click += new System.EventHandler(this.buttonSetArm_Click);
            // 
            // timePickerArmar
            // 
            this.timePickerArmar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.timePickerArmar, "timePickerArmar");
            this.timePickerArmar.Name = "timePickerArmar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSetDisarm);
            this.groupBox2.Controls.Add(this.timePickerDesarmar);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // buttonSetDisarm
            // 
            this.buttonSetDisarm.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.buttonSetDisarm, "buttonSetDisarm");
            this.buttonSetDisarm.Name = "buttonSetDisarm";
            this.buttonSetDisarm.UseVisualStyleBackColor = false;
            this.buttonSetDisarm.Click += new System.EventHandler(this.buttonSetDisarm_Click);
            // 
            // timePickerDesarmar
            // 
            this.timePickerDesarmar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.timePickerDesarmar, "timePickerDesarmar");
            this.timePickerDesarmar.Name = "timePickerDesarmar";
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.textBoxLogs, "textBoxLogs");
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ReadOnly = true;
            // 
            // labelS2
            // 
            this.labelS2.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.labelS2, "labelS2");
            this.labelS2.Name = "labelS2";
            // 
            // labelS1
            // 
            this.labelS1.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.labelS1, "labelS1");
            this.labelS1.Name = "labelS1";
            // 
            // labelS3
            // 
            this.labelS3.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.labelS3, "labelS3");
            this.labelS3.Name = "labelS3";
            // 
            // labelS4
            // 
            this.labelS4.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.labelS4, "labelS4");
            this.labelS4.Name = "labelS4";
            // 
            // labelS5
            // 
            this.labelS5.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.labelS5, "labelS5");
            this.labelS5.Name = "labelS5";
            // 
            // labelS5_text
            // 
            resources.ApplyResources(this.labelS5_text, "labelS5_text");
            this.labelS5_text.Name = "labelS5_text";
            // 
            // labelS4_text
            // 
            resources.ApplyResources(this.labelS4_text, "labelS4_text");
            this.labelS4_text.Name = "labelS4_text";
            // 
            // labelS3_text
            // 
            resources.ApplyResources(this.labelS3_text, "labelS3_text");
            this.labelS3_text.Name = "labelS3_text";
            // 
            // labelS2_text
            // 
            resources.ApplyResources(this.labelS2_text, "labelS2_text");
            this.labelS2_text.Name = "labelS2_text";
            // 
            // labelS1_text
            // 
            resources.ApplyResources(this.labelS1_text, "labelS1_text");
            this.labelS1_text.Name = "labelS1_text";
            // 
            // labelClock
            // 
            resources.ApplyResources(this.labelClock, "labelClock");
            this.labelClock.Name = "labelClock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alarm3.Properties.Resources.planta;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Click += new System.EventHandler(this.open_device);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.guna2Button2, "guna2Button2");
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Click += new System.EventHandler(this.close_device);
            // 
            // labelOpenDevice
            // 
            this.labelOpenDevice.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.labelOpenDevice, "labelOpenDevice");
            this.labelOpenDevice.Name = "labelOpenDevice";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.guna2Button3, "guna2Button3");
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Click += new System.EventHandler(this.ExternalMode);
            // 
            // labelTimeLeft
            // 
            resources.ApplyResources(this.labelTimeLeft, "labelTimeLeft");
            this.labelTimeLeft.Name = "labelTimeLeft";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.guna2Button4, "guna2Button4");
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Click += new System.EventHandler(this.buttonRandomIlumination_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 10;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.guna2Button5, "guna2Button5");
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Click += new System.EventHandler(this.buttonPanic_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 10;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            resources.ApplyResources(this.guna2Button6, "guna2Button6");
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderRadius = 10;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            resources.ApplyResources(this.guna2Button7, "guna2Button7");
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Click += new System.EventHandler(this.button3_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BorderRadius = 10;
            this.guna2Button8.CheckedState.Parent = this.guna2Button8;
            this.guna2Button8.CustomImages.Parent = this.guna2Button8;
            resources.ApplyResources(this.guna2Button8, "guna2Button8");
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.HoverState.Parent = this.guna2Button8;
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.ShadowDecoration.Parent = this.guna2Button8;
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // guna2CheckBox1
            // 
            resources.ApplyResources(this.guna2CheckBox1, "guna2CheckBox1");
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.labelOpenDevice);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxLogs);
            this.Controls.Add(this.labelS5);
            this.Controls.Add(this.labelS4);
            this.Controls.Add(this.labelS5_text);
            this.Controls.Add(this.labelS3);
            this.Controls.Add(this.labelS2);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.labelS4_text);
            this.Controls.Add(this.labelS1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelS3_text);
            this.Controls.Add(this.labelS1_text);
            this.Controls.Add(this.labelS2_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker timePickerArmar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker timePickerDesarmar;
        public System.Windows.Forms.TextBox textBoxLogs;
        private System.Windows.Forms.Button buttonSetArm;
        private System.Windows.Forms.Button buttonSetDisarm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelS5_text;
        private System.Windows.Forms.Label labelS4_text;
        private System.Windows.Forms.Label labelS3_text;
        private System.Windows.Forms.Label labelS2_text;
        private System.Windows.Forms.Label labelS1_text;
        private System.Windows.Forms.Label labelS5;
        private System.Windows.Forms.Label labelS4;
        private System.Windows.Forms.Label labelS3;
        private System.Windows.Forms.Label labelS1;
        private System.Windows.Forms.Label labelS2;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label labelOpenDevice;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label labelTimeLeft;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
    }
}

