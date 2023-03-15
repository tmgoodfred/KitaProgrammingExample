namespace KitaProgrammingExample
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.songTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artistTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.albumArt = new System.Windows.Forms.PictureBox();
            this.trackList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // songTxt
            // 
            this.songTxt.Location = new System.Drawing.Point(249, 43);
            this.songTxt.Name = "songTxt";
            this.songTxt.Size = new System.Drawing.Size(297, 31);
            this.songTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Song Title";
            // 
            // artistTxt
            // 
            this.artistTxt.Location = new System.Drawing.Point(249, 87);
            this.artistTxt.Name = "artistTxt";
            this.artistTxt.Size = new System.Drawing.Size(297, 31);
            this.artistTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artist Name";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(330, 135);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(112, 34);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Search";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(773, 67);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.Size = new System.Drawing.Size(150, 31);
            this.outputTxt.TabIndex = 5;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(617, 67);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(112, 34);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // albumArt
            // 
            this.albumArt.Location = new System.Drawing.Point(145, 264);
            this.albumArt.Name = "albumArt";
            this.albumArt.Size = new System.Drawing.Size(400, 400);
            this.albumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumArt.TabIndex = 7;
            this.albumArt.TabStop = false;
            // 
            // trackList
            // 
            this.trackList.Location = new System.Drawing.Point(630, 264);
            this.trackList.Multiline = true;
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(313, 380);
            this.trackList.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 746);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.albumArt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.artistTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songTxt);
            this.Name = "Main";
            this.Text = "Music Info";
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox songTxt;
        private Label label1;
        private TextBox artistTxt;
        private Label label2;
        private Button submitBtn;
        private TextBox outputTxt;
        private Button clearBtn;
        private PictureBox albumArt;
        private TextBox trackList;
    }
}