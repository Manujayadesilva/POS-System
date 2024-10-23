namespace POS_System
{
    partial class ManagementSales
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
            this.labelManagement = new System.Windows.Forms.Label();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonSaleItems = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSales = new System.Windows.Forms.Label();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManagement
            // 
            this.labelManagement.AutoSize = true;
            this.labelManagement.Font = new System.Drawing.Font("Mongolian Baiti", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagement.ForeColor = System.Drawing.Color.Coral;
            this.labelManagement.Location = new System.Drawing.Point(249, 3);
            this.labelManagement.Name = "labelManagement";
            this.labelManagement.Size = new System.Drawing.Size(541, 64);
            this.labelManagement.TabIndex = 0;
            this.labelManagement.Text = "Management System";
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonProducts.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.Location = new System.Drawing.Point(110, 126);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(178, 49);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSales.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSales.Location = new System.Drawing.Point(433, 126);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(178, 49);
            this.buttonSales.TabIndex = 2;
            this.buttonSales.Text = "Sales";
            this.buttonSales.UseVisualStyleBackColor = false;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // buttonSaleItems
            // 
            this.buttonSaleItems.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSaleItems.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaleItems.Location = new System.Drawing.Point(755, 126);
            this.buttonSaleItems.Name = "buttonSaleItems";
            this.buttonSaleItems.Size = new System.Drawing.Size(178, 49);
            this.buttonSaleItems.TabIndex = 2;
            this.buttonSaleItems.Text = "Sale Items";
            this.buttonSaleItems.UseVisualStyleBackColor = false;
            this.buttonSaleItems.Click += new System.EventHandler(this.buttonSaleItems_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(79, 186);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.Location = new System.Drawing.Point(13, 193);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(58, 24);
            this.labelSales.TabIndex = 4;
            this.labelSales.Text = "Sales:";
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(16, 222);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.RowTemplate.Height = 24;
            this.dataGridViewSales.Size = new System.Drawing.Size(982, 393);
            this.dataGridViewSales.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::POS_System.Properties.Resources.Ícones_de_Sair_Para_Botao_App_para_download_gratuito;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Location = new System.Drawing.Point(0, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(40, 36);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // ManagementSales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1010, 631);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.labelSales);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSaleItems);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelManagement);
            this.Name = "ManagementSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManagement;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonSaleItems;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.DataGridView dataGridViewSales;
    }
}