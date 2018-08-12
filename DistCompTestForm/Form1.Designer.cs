namespace DistCompTestForm
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
            this.txtStn1 = new System.Windows.Forms.TextBox();
            this.txtStn2 = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.BtnDistance = new System.Windows.Forms.Button();
            this.distComp = new RouteDistanceLibrary.RouteDistanceComponent(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStn1
            // 
            this.txtStn1.Location = new System.Drawing.Point(62, 59);
            this.txtStn1.Name = "txtStn1";
            this.txtStn1.Size = new System.Drawing.Size(100, 20);
            this.txtStn1.TabIndex = 0;
            // 
            // txtStn2
            // 
            this.txtStn2.Location = new System.Drawing.Point(62, 100);
            this.txtStn2.Name = "txtStn2";
            this.txtStn2.Size = new System.Drawing.Size(100, 20);
            this.txtStn2.TabIndex = 1;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(62, 198);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(100, 20);
            this.txtRes.TabIndex = 2;
            // 
            // BtnDistance
            // 
            this.BtnDistance.Location = new System.Drawing.Point(62, 148);
            this.BtnDistance.Name = "BtnDistance";
            this.BtnDistance.Size = new System.Drawing.Size(75, 23);
            this.BtnDistance.TabIndex = 3;
            this.BtnDistance.Text = "button1";
            this.BtnDistance.UseVisualStyleBackColor = true;
            this.BtnDistance.Click += new System.EventHandler(this.BtnDistance_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(62, 224);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 4;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(62, 250);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 309);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.BtnDistance);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtStn2);
            this.Controls.Add(this.txtStn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStn1;
        private System.Windows.Forms.TextBox txtStn2;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button BtnDistance;
        private RouteDistanceLibrary.RouteDistanceComponent distComp;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtChange;
    }
}

