namespace OrderEmployeedManagementWindowsNative
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.OrdersButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersButton
            // 
            this.OrdersButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrdersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrdersButton.BackgroundImage")));
            this.OrdersButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersButton.Location = new System.Drawing.Point(12, 208);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(129, 130);
            this.OrdersButton.TabIndex = 3;
            this.OrdersButton.Text = "&Create Orders";
            this.OrdersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 130);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Edit Orders";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.searchCtrlSToolStripMenuItem,
            this.orderStatusToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.createToolStripMenuItem.Text = "&Create";
            // 
            // searchCtrlSToolStripMenuItem
            // 
            this.searchCtrlSToolStripMenuItem.Name = "searchCtrlSToolStripMenuItem";
            this.searchCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.searchCtrlSToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.searchCtrlSToolStripMenuItem.Text = "&Search";
            // 
            // orderStatusToolStripMenuItem
            // 
            this.orderStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendingToolStripMenuItem1,
            this.incompleteToolStripMenuItem,
            this.recentToolStripMenuItem});
            this.orderStatusToolStripMenuItem.Name = "orderStatusToolStripMenuItem";
            this.orderStatusToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.orderStatusToolStripMenuItem.Text = "Order Status";
            // 
            // pendingToolStripMenuItem1
            // 
            this.pendingToolStripMenuItem1.Name = "pendingToolStripMenuItem1";
            this.pendingToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pendingToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.pendingToolStripMenuItem1.Text = "Pending";
            // 
            // incompleteToolStripMenuItem
            // 
            this.incompleteToolStripMenuItem.Name = "incompleteToolStripMenuItem";
            this.incompleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.incompleteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.incompleteToolStripMenuItem.Text = "Incomplete";
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(885, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrdersForm";
            this.Text = "Orders";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
    }
}