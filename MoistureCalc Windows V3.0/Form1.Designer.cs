namespace MoistureCalc_Windows_V3._0
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.DoneButton = new System.Windows.Forms.Button();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.LabelWetWeight = new System.Windows.Forms.Label();
            this.labelDryWeight = new System.Windows.Forms.Label();
            this.labelMoistureContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoneButton
            // 
            this.DoneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DoneButton.Location = new System.Drawing.Point(293, 275);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 40);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneClicked);
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CommentTextBox.Location = new System.Drawing.Point(229, 239);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(198, 30);
            this.CommentTextBox.TabIndex = 1;
            this.CommentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelWetWeight
            // 
            this.LabelWetWeight.AutoSize = true;
            this.LabelWetWeight.Location = new System.Drawing.Point(225, 108);
            this.LabelWetWeight.Name = "LabelWetWeight";
            this.LabelWetWeight.Size = new System.Drawing.Size(143, 23);
            this.LabelWetWeight.TabIndex = 2;
            this.LabelWetWeight.Text = "Wet Sample Weight:";
            // 
            // labelDryWeight
            // 
            this.labelDryWeight.AutoSize = true;
            this.labelDryWeight.Location = new System.Drawing.Point(225, 131);
            this.labelDryWeight.Name = "labelDryWeight";
            this.labelDryWeight.Size = new System.Drawing.Size(142, 23);
            this.labelDryWeight.TabIndex = 3;
            this.labelDryWeight.Text = "Dry Sample Weight:";
            // 
            // labelMoistureContent
            // 
            this.labelMoistureContent.AutoSize = true;
            this.labelMoistureContent.Location = new System.Drawing.Point(225, 158);
            this.labelMoistureContent.Name = "labelMoistureContent";
            this.labelMoistureContent.Size = new System.Drawing.Size(172, 23);
            this.labelMoistureContent.TabIndex = 4;
            this.labelMoistureContent.Text = "Moisture Content Result:";
            // 
            // ResultsForm
            // 
            this.AcceptButton = this.DoneButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1024, 745);
            this.Controls.Add(this.labelMoistureContent);
            this.Controls.Add(this.labelDryWeight);
            this.Controls.Add(this.LabelWetWeight);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.DoneButton);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::MoistureCalc_Windows_V3._0.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MoistureCalc_Windows_V3._0.Properties.Settings.Default, "appText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::MoistureCalc_Windows_V3._0.Properties.Settings.Default.Location;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResultsForm";
            this.Opacity = 0.8D;
            this.Text = global::MoistureCalc_Windows_V3._0.Properties.Settings.Default.appText;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Label LabelWetWeight;
        private System.Windows.Forms.Label labelDryWeight;
        private System.Windows.Forms.Label labelMoistureContent;
    }
}

