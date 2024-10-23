namespace POS_System
{
    partial class Menu
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
            this.panelPriceCal = new System.Windows.Forms.Panel();
            this.listBoxSelectItems = new System.Windows.Forms.ListBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPriceCal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPriceCal
            // 
            this.panelPriceCal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPriceCal.Controls.Add(this.listBoxSelectItems);
            this.panelPriceCal.Controls.Add(this.buttonHome);
            this.panelPriceCal.Controls.Add(this.numericQuantity);
            this.panelPriceCal.Controls.Add(this.listBoxPrice);
            this.panelPriceCal.Controls.Add(this.buttonDone);
            this.panelPriceCal.Controls.Add(this.buttonAddOrder);
            this.panelPriceCal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPriceCal.Location = new System.Drawing.Point(0, 486);
            this.panelPriceCal.Name = "panelPriceCal";
            this.panelPriceCal.Size = new System.Drawing.Size(1010, 145);
            this.panelPriceCal.TabIndex = 0;
            // 
            // listBoxSelectItems
            // 
            this.listBoxSelectItems.FormattingEnabled = true;
            this.listBoxSelectItems.ItemHeight = 16;
            this.listBoxSelectItems.Location = new System.Drawing.Point(52, 11);
            this.listBoxSelectItems.Name = "listBoxSelectItems";
            this.listBoxSelectItems.Size = new System.Drawing.Size(580, 132);
            this.listBoxSelectItems.TabIndex = 4;
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = global::POS_System.Properties.Resources.Home_Icon_Silhouette_free_icons_designed_by_Freepik;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.Location = new System.Drawing.Point(0, 11);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(36, 33);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(638, 11);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(49, 22);
            this.numericQuantity.TabIndex = 3;
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.ItemHeight = 16;
            this.listBoxPrice.Location = new System.Drawing.Point(721, 36);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(207, 68);
            this.listBoxPrice.TabIndex = 3;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(721, 105);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(207, 30);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.Color.Coral;
            this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrder.Location = new System.Drawing.Point(721, 3);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(207, 30);
            this.buttonAddOrder.TabIndex = 0;
            this.buttonAddOrder.Text = "Add To Order";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Location = new System.Drawing.Point(0, -4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1010, 0);
            this.panelMenu.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1010, 631);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPriceCal);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelPriceCal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPriceCal;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.ListBox listBoxSelectItems;
    }
}