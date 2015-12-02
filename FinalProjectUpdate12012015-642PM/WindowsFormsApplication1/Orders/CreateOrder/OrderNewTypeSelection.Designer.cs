namespace OrderEmployeedManagementWindowsNative
{
    partial class OrderBuildTypeSelectionForm
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
            this.ClientSelectioncomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClitentSelectionlabel = new System.Windows.Forms.Label();
            this.orderTypeComboBox = new System.Windows.Forms.ComboBox();
            this.OrderTypelabel = new System.Windows.Forms.Label();
            this.CreateNewOrderbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientSelectioncomboBox
            // 
            this.ClientSelectioncomboBox.FormattingEnabled = true;
            this.ClientSelectioncomboBox.Items.AddRange(new object[] {
            "Tom",
            "Lewis",
            "John",
            "Cooper",
            "Lora",
            "Shirley",
            "Bupkus"});
            this.ClientSelectioncomboBox.Location = new System.Drawing.Point(21, 71);
            this.ClientSelectioncomboBox.Name = "ClientSelectioncomboBox";
            this.ClientSelectioncomboBox.Size = new System.Drawing.Size(161, 21);
            this.ClientSelectioncomboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Order";
            // 
            // ClitentSelectionlabel
            // 
            this.ClitentSelectionlabel.AutoSize = true;
            this.ClitentSelectionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClitentSelectionlabel.Location = new System.Drawing.Point(25, 53);
            this.ClitentSelectionlabel.Name = "ClitentSelectionlabel";
            this.ClitentSelectionlabel.Size = new System.Drawing.Size(112, 15);
            this.ClitentSelectionlabel.TabIndex = 2;
            this.ClitentSelectionlabel.Text = "Client Selection:";
            // 
            // orderTypeComboBox
            // 
            this.orderTypeComboBox.FormattingEnabled = true;
            this.orderTypeComboBox.Items.AddRange(new object[] {
            "Shirt",
            "Hat",
            "Sticker",
            "Custom"});
            this.orderTypeComboBox.Location = new System.Drawing.Point(332, 71);
            this.orderTypeComboBox.Name = "orderTypeComboBox";
            this.orderTypeComboBox.Size = new System.Drawing.Size(161, 21);
            this.orderTypeComboBox.TabIndex = 0;
            // 
            // OrderTypelabel
            // 
            this.OrderTypelabel.AutoSize = true;
            this.OrderTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTypelabel.Location = new System.Drawing.Point(343, 53);
            this.OrderTypelabel.Name = "OrderTypelabel";
            this.OrderTypelabel.Size = new System.Drawing.Size(81, 15);
            this.OrderTypelabel.TabIndex = 2;
            this.OrderTypelabel.Text = "Order Type:";
            // 
            // CreateNewOrderbutton
            // 
            this.CreateNewOrderbutton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewOrderbutton.Location = new System.Drawing.Point(444, 139);
            this.CreateNewOrderbutton.Name = "CreateNewOrderbutton";
            this.CreateNewOrderbutton.Size = new System.Drawing.Size(165, 56);
            this.CreateNewOrderbutton.TabIndex = 3;
            this.CreateNewOrderbutton.Text = "Create";
            this.CreateNewOrderbutton.UseVisualStyleBackColor = true;
            this.CreateNewOrderbutton.Click += new System.EventHandler(this.CreateNewOrderbutton_Click);
            // 
            // OrderBuildTypeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 207);
            this.Controls.Add(this.CreateNewOrderbutton);
            this.Controls.Add(this.OrderTypelabel);
            this.Controls.Add(this.ClitentSelectionlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderTypeComboBox);
            this.Controls.Add(this.ClientSelectioncomboBox);
            this.MinimumSize = new System.Drawing.Size(637, 245);
            this.Name = "OrderBuildTypeSelectionForm";
            this.Text = "Initiate Order";
            this.Load += new System.EventHandler(this.OrderBuildForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClientSelectioncomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClitentSelectionlabel;
        private System.Windows.Forms.ComboBox orderTypeComboBox;
        private System.Windows.Forms.Label OrderTypelabel;
        private System.Windows.Forms.Button CreateNewOrderbutton;
    }
}