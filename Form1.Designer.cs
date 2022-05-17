namespace ResizEasy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectPicture = new System.Windows.Forms.PictureBox();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.ResultsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DefaultCheckBox = new System.Windows.Forms.CheckBox();
            this.InputNewSize = new System.Windows.Forms.TextBox();
            this.AppendNewSizeButton = new System.Windows.Forms.PictureBox();
            this.FinishButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPicture)).BeginInit();
            this.ResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppendNewSizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectPicture
            // 
            this.SelectPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectPicture.Image = ((System.Drawing.Image)(resources.GetObject("SelectPicture.Image")));
            this.SelectPicture.Location = new System.Drawing.Point(10, 28);
            this.SelectPicture.Name = "SelectPicture";
            this.SelectPicture.Size = new System.Drawing.Size(131, 130);
            this.SelectPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectPicture.TabIndex = 0;
            this.SelectPicture.TabStop = false;
            this.SelectPicture.Click += new System.EventHandler(this.SelectPicture_Click);
            // 
            // SelectLabel
            // 
            this.SelectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectLabel.ForeColor = System.Drawing.Color.Lime;
            this.SelectLabel.Location = new System.Drawing.Point(38, 9);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(76, 16);
            this.SelectLabel.TabIndex = 1;
            this.SelectLabel.Text = "Select Image";
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.Controls.Add(this.DefaultCheckBox);
            this.ResultsPanel.Location = new System.Drawing.Point(147, 28);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(131, 167);
            this.ResultsPanel.TabIndex = 2;
            // 
            // DefaultCheckBox
            // 
            this.DefaultCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.DefaultCheckBox.Checked = true;
            this.DefaultCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.DefaultCheckBox.Location = new System.Drawing.Point(5, 5);
            this.DefaultCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.DefaultCheckBox.Name = "DefaultCheckBox";
            this.DefaultCheckBox.Padding = new System.Windows.Forms.Padding(5);
            this.DefaultCheckBox.Size = new System.Drawing.Size(100, 33);
            this.DefaultCheckBox.TabIndex = 0;
            this.DefaultCheckBox.Text = "100";
            this.DefaultCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DefaultCheckBox.UseVisualStyleBackColor = false;
            this.DefaultCheckBox.CheckedChanged += new System.EventHandler(this.DefaultCheckBox_CheckedChanged);
            this.DefaultCheckBox.Click += new System.EventHandler(this.DefaultCheckBox_Click);
            // 
            // InputNewSize
            // 
            this.InputNewSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.InputNewSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputNewSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputNewSize.Font = new System.Drawing.Font("Swis721 Hv BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputNewSize.ForeColor = System.Drawing.Color.Lime;
            this.InputNewSize.Location = new System.Drawing.Point(152, 6);
            this.InputNewSize.Name = "InputNewSize";
            this.InputNewSize.Size = new System.Drawing.Size(80, 15);
            this.InputNewSize.TabIndex = 1;
            this.InputNewSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputNewSize.TextChanged += new System.EventHandler(this.InputNewSize_TextChanged);
            // 
            // AppendNewSizeButton
            // 
            this.AppendNewSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppendNewSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("AppendNewSizeButton.Image")));
            this.AppendNewSizeButton.Location = new System.Drawing.Point(238, 5);
            this.AppendNewSizeButton.Name = "AppendNewSizeButton";
            this.AppendNewSizeButton.Size = new System.Drawing.Size(20, 20);
            this.AppendNewSizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppendNewSizeButton.TabIndex = 3;
            this.AppendNewSizeButton.TabStop = false;
            this.AppendNewSizeButton.Click += new System.EventHandler(this.AppendNewSizeButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishButton.ForeColor = System.Drawing.Color.Lime;
            this.FinishButton.Location = new System.Drawing.Point(10, 164);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(131, 23);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(147, 161);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.AppendNewSizeButton);
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.InputNewSize);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.SelectPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.8D;
            this.Text = "ResizEasy";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.SelectPicture)).EndInit();
            this.ResultsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppendNewSizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox SelectPicture;
        private Label SelectLabel;
        private FlowLayoutPanel ResultsPanel;
        private CheckBox DefaultCheckBox;
        private TextBox InputNewSize;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private PictureBox AppendNewSizeButton;
        private Button FinishButton;
    }
}