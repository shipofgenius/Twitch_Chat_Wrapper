namespace Twitch_Chat_Wrapper
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
            this.webTwitch = new System.Windows.Forms.WebBrowser();
            this.txtStreamer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetBits = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBitAmount = new System.Windows.Forms.TextBox();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetStreamer = new System.Windows.Forms.Button();
            this.btnThrowBits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webTwitch
            // 
            this.webTwitch.Location = new System.Drawing.Point(62, 117);
            this.webTwitch.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTwitch.Name = "webTwitch";
            this.webTwitch.ScrollBarsEnabled = false;
            this.webTwitch.Size = new System.Drawing.Size(951, 603);
            this.webTwitch.TabIndex = 0;
            this.webTwitch.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // txtStreamer
            // 
            this.txtStreamer.Location = new System.Drawing.Point(62, 36);
            this.txtStreamer.Name = "txtStreamer";
            this.txtStreamer.Size = new System.Drawing.Size(246, 26);
            this.txtStreamer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Streamer";
            // 
            // btnSetBits
            // 
            this.btnSetBits.Location = new System.Drawing.Point(1126, 100);
            this.btnSetBits.Name = "btnSetBits";
            this.btnSetBits.Size = new System.Drawing.Size(131, 52);
            this.btnSetBits.TabIndex = 3;
            this.btnSetBits.Text = "Set Bit Amount";
            this.btnSetBits.UseVisualStyleBackColor = true;
            this.btnSetBits.Click += new System.EventHandler(this.btnSetBits_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1126, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Set Timer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtBitAmount
            // 
            this.txtBitAmount.Location = new System.Drawing.Point(1056, 126);
            this.txtBitAmount.Name = "txtBitAmount";
            this.txtBitAmount.Size = new System.Drawing.Size(56, 26);
            this.txtBitAmount.TabIndex = 5;
            this.txtBitAmount.WordWrap = false;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(1056, 193);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(60, 26);
            this.txtFrequency.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1051, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "minutes";
            // 
            // btnGetStreamer
            // 
            this.btnGetStreamer.Location = new System.Drawing.Point(330, 32);
            this.btnGetStreamer.Name = "btnGetStreamer";
            this.btnGetStreamer.Size = new System.Drawing.Size(109, 34);
            this.btnGetStreamer.TabIndex = 8;
            this.btnGetStreamer.Text = "Open Chat";
            this.btnGetStreamer.UseVisualStyleBackColor = true;
            this.btnGetStreamer.Click += new System.EventHandler(this.btnGetStreamer_Click);
            // 
            // btnThrowBits
            // 
            this.btnThrowBits.Location = new System.Drawing.Point(440, 751);
            this.btnThrowBits.Name = "btnThrowBits";
            this.btnThrowBits.Size = new System.Drawing.Size(143, 41);
            this.btnThrowBits.TabIndex = 9;
            this.btnThrowBits.Text = "Throw Bits";
            this.btnThrowBits.UseVisualStyleBackColor = true;
            this.btnThrowBits.Click += new System.EventHandler(this.btnThrowBits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 826);
            this.Controls.Add(this.btnThrowBits);
            this.Controls.Add(this.btnGetStreamer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.txtBitAmount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSetBits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStreamer);
            this.Controls.Add(this.webTwitch);
            this.Name = "Form1";
            this.Text = "Twitch Chat Wrapper";
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            //timer
            //
            this.timer = new System.Timers.Timer();
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Tick);


        }

        #endregion

        private System.Windows.Forms.WebBrowser webTwitch;
        private System.Windows.Forms.TextBox txtStreamer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetBits;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBitAmount;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetStreamer;
        private System.Windows.Forms.HtmlElementCollection elements;
        // private System.Windows.Forms.HtmlDocument document;
        private System.Timers.Timer timer;
        private System.Windows.Forms.Button btnThrowBits;
    }
}

