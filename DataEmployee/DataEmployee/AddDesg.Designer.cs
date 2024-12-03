namespace DataEmployee
{
    partial class AddDesg
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeptId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesgId = new System.Windows.Forms.TextBox();
            this.txtDesgName = new System.Windows.Forms.TextBox();
            this.btnAddDesg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD DESIGNANTION";
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptId.Location = new System.Drawing.Point(223, 158);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(50, 37);
            this.lblDeptId.TabIndex = 1;
            this.lblDeptId.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESG NAME";
            // 
            // txtDesgId
            // 
            this.txtDesgId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesgId.Location = new System.Drawing.Point(540, 168);
            this.txtDesgId.Name = "txtDesgId";
            this.txtDesgId.Size = new System.Drawing.Size(297, 44);
            this.txtDesgId.TabIndex = 3;
            // 
            // txtDesgName
            // 
            this.txtDesgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesgName.Location = new System.Drawing.Point(540, 313);
            this.txtDesgName.Name = "txtDesgName";
            this.txtDesgName.Size = new System.Drawing.Size(297, 44);
            this.txtDesgName.TabIndex = 4;
            // 
            // btnAddDesg
            // 
            this.btnAddDesg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDesg.Location = new System.Drawing.Point(419, 460);
            this.btnAddDesg.Name = "btnAddDesg";
            this.btnAddDesg.Size = new System.Drawing.Size(195, 59);
            this.btnAddDesg.TabIndex = 5;
            this.btnAddDesg.Text = "Add";
            this.btnAddDesg.UseVisualStyleBackColor = true;
            this.btnAddDesg.Click += new System.EventHandler(this.btnAddDesg_Click);
            // 
            // AddDesg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 657);
            this.Controls.Add(this.btnAddDesg);
            this.Controls.Add(this.txtDesgName);
            this.Controls.Add(this.txtDesgId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.label1);
            this.Name = "AddDesg";
            this.Text = "q";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesgId;
        private System.Windows.Forms.TextBox txtDesgName;
        private System.Windows.Forms.Button btnAddDesg;
    }
}