namespace DBFinalProject
{
    partial class AidDistribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AidDistribution));
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.AidType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CampaignCycleID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.Location = new System.Drawing.Point(588, 644);
            this.date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(346, 26);
            this.date.TabIndex = 246;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(586, 619);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 21);
            this.label9.TabIndex = 245;
            this.label9.Text = "📅Distribution Date";
            // 
            // AidType
            // 
            this.AidType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AidType.FormattingEnabled = true;
            this.AidType.Items.AddRange(new object[] {
            "Medical",
            "Financial",
            "Food",
            "Education"});
            this.AidType.Location = new System.Drawing.Point(588, 518);
            this.AidType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AidType.Name = "AidType";
            this.AidType.Size = new System.Drawing.Size(346, 28);
            this.AidType.TabIndex = 242;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(585, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 241;
            this.label6.Text = "⚙️Aid Type";
            // 
            // CampaignCycleID
            // 
            this.CampaignCycleID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CampaignCycleID.FormattingEnabled = true;
            this.CampaignCycleID.Location = new System.Drawing.Point(586, 459);
            this.CampaignCycleID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CampaignCycleID.Name = "CampaignCycleID";
            this.CampaignCycleID.Size = new System.Drawing.Size(348, 28);
            this.CampaignCycleID.TabIndex = 240;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(587, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 239;
            this.label2.Text = "🔑Campaign Cycle ID";
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button8.Location = new System.Drawing.Point(644, 700);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 41);
            this.button8.TabIndex = 238;
            this.button8.Text = "Distribute";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button9.Location = new System.Drawing.Point(762, 700);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 41);
            this.button9.TabIndex = 233;
            this.button9.Text = "Back";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(586, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 231;
            this.label4.Text = "➗Amount of Items";
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button12.Location = new System.Drawing.Point(32, 551);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(224, 69);
            this.button12.TabIndex = 230;
            this.button12.Text = "Assign Tasks";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.BackColor = System.Drawing.Color.Thistle;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button11.Location = new System.Drawing.Point(32, 622);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(224, 62);
            this.button11.TabIndex = 229;
            this.button11.Text = "Aid Distribution";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(670, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 28);
            this.label3.TabIndex = 221;
            this.label3.Text = "Aid Distributions";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(579, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 53);
            this.label1.TabIndex = 219;
            this.label1.Text = "Lead Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "\"C:\\Users\\Imran Shaikh\\Downloads\\WhatsApp_Image_2023-10-16_at_4.43.13_PM-removebg" +
    "-preview (1).png\"";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 218;
            this.pictureBox1.TabStop = false;
            // 
            // Amount
            // 
            this.Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Amount.Location = new System.Drawing.Point(588, 586);
            this.Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amount.Multiline = true;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(348, 28);
            this.Amount.TabIndex = 260;
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button13.Location = new System.Drawing.Point(32, 469);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(224, 65);
            this.button13.TabIndex = 365;
            this.button13.Text = "Manage Beneficiaries";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button14.Location = new System.Drawing.Point(32, 696);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(224, 65);
            this.button14.TabIndex = 364;
            this.button14.Text = "Give Feedback";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button15.Location = new System.Drawing.Point(32, 769);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(224, 54);
            this.button15.TabIndex = 363;
            this.button15.Text = "Logout";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.BackColor = System.Drawing.Color.GhostWhite;
            this.button16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button16.Location = new System.Drawing.Point(32, 310);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(224, 71);
            this.button16.TabIndex = 362;
            this.button16.Text = "Manage Campaigns";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button25.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button25.Location = new System.Drawing.Point(32, 396);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(224, 65);
            this.button25.TabIndex = 361;
            this.button25.Text = "Manage Events";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // AidDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1281, 908);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AidType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CampaignCycleID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AidDistribution";
            this.Text = "AidDistribution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AidDistribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AidType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CampaignCycleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button25;
    }
}