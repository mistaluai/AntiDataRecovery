namespace AntidataRecoveryApp
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LogicalDrives = new MetroFramework.Controls.MetroComboBox();
            this.SizeInteger = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Start = new MetroFramework.Controls.MetroButton();
            this.StopButton = new MetroFramework.Controls.MetroButton();
            this.Refresh = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BackgroundProgressWorker = new System.Windows.Forms.Timer(this.components);
            this.Loading = new CircularProgressBar.CircularProgressBar();
            this.ExitWaiter = new System.ComponentModel.BackgroundWorker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(12, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Choose Partition :";
            // 
            // LogicalDrives
            // 
            this.LogicalDrives.FormattingEnabled = true;
            this.LogicalDrives.ItemHeight = 23;
            this.LogicalDrives.Location = new System.Drawing.Point(164, 74);
            this.LogicalDrives.Name = "LogicalDrives";
            this.LogicalDrives.Size = new System.Drawing.Size(121, 29);
            this.LogicalDrives.TabIndex = 1;
            this.LogicalDrives.UseSelectable = true;
            // 
            // SizeInteger
            // 
            this.SizeInteger.FormattingEnabled = true;
            this.SizeInteger.ItemHeight = 23;
            this.SizeInteger.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400",
            "410",
            "420",
            "430",
            "440",
            "450",
            "460",
            "470",
            "480",
            "490",
            "500"});
            this.SizeInteger.Location = new System.Drawing.Point(164, 114);
            this.SizeInteger.Name = "SizeInteger";
            this.SizeInteger.Size = new System.Drawing.Size(121, 29);
            this.SizeInteger.TabIndex = 3;
            this.SizeInteger.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(12, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Choose File Size :";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.DarkCyan;
            this.Start.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Start.ForeColor = System.Drawing.Color.MintCream;
            this.Start.Location = new System.Drawing.Point(12, 163);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(113, 23);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseCustomBackColor = true;
            this.Start.UseCustomForeColor = true;
            this.Start.UseSelectable = true;
            this.Start.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.DarkCyan;
            this.StopButton.Enabled = false;
            this.StopButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.StopButton.ForeColor = System.Drawing.Color.MintCream;
            this.StopButton.Location = new System.Drawing.Point(146, 163);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(113, 23);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Cancel Process";
            this.StopButton.UseCustomBackColor = true;
            this.StopButton.UseCustomForeColor = true;
            this.StopButton.UseSelectable = true;
            this.StopButton.UseStyleColors = true;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.White;
            this.Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh.BackgroundImage")));
            this.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Location = new System.Drawing.Point(288, 75);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(25, 24);
            this.Refresh.TabIndex = 7;
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(288, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 15);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Gb";
            // 
            // Loading
            // 
            this.Loading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.QuarticEaseOut;
            this.Loading.AnimationSpeed = 1000;
            this.Loading.BackColor = System.Drawing.Color.Transparent;
            this.Loading.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold);
            this.Loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loading.InnerColor = System.Drawing.Color.White;
            this.Loading.InnerMargin = 0;
            this.Loading.InnerWidth = 8;
            this.Loading.Location = new System.Drawing.Point(265, 163);
            this.Loading.MarqueeAnimationSpeed = 2000;
            this.Loading.Name = "Loading";
            this.Loading.OuterColor = System.Drawing.Color.White;
            this.Loading.OuterMargin = -25;
            this.Loading.OuterWidth = 26;
            this.Loading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(166)))));
            this.Loading.ProgressWidth = 25;
            this.Loading.SecondaryFont = new System.Drawing.Font("Tahoma", 6F);
            this.Loading.Size = new System.Drawing.Size(48, 41);
            this.Loading.StartAngle = 270;
            this.Loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Loading.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Loading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Loading.SubscriptText = ".23";
            this.Loading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Loading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Loading.SuperscriptText = "°C";
            this.Loading.TabIndex = 9;
            this.Loading.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Loading.Value = 30;
            this.Loading.Visible = false;
            this.Loading.Click += new System.EventHandler(this.Loading_Click);
            // 
            // ExitWaiter
            // 
            this.ExitWaiter.WorkerSupportsCancellation = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(23, 189);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(217, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Loai Waleed | NanosX Developmets";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 213);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.SizeInteger);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.LogicalDrives);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Data Recovery Disabler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton Start;
        private MetroFramework.Controls.MetroButton StopButton;
        private System.Windows.Forms.Button Refresh;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroComboBox LogicalDrives;
        public MetroFramework.Controls.MetroComboBox SizeInteger;
        private System.Windows.Forms.Timer BackgroundProgressWorker;
        private CircularProgressBar.CircularProgressBar Loading;
        public System.ComponentModel.BackgroundWorker ExitWaiter;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

