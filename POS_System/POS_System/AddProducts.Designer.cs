namespace POS_System
{
    partial class AddProducts
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
            this.labelAddProducts = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxAddPicture = new System.Windows.Forms.PictureBox();
            this.buttonPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddProducts
            // 
            this.labelAddProducts.AutoSize = true;
            this.labelAddProducts.BackColor = System.Drawing.Color.Transparent;
            this.labelAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProducts.Location = new System.Drawing.Point(242, 26);
            this.labelAddProducts.Name = "labelAddProducts";
            this.labelAddProducts.Size = new System.Drawing.Size(400, 69);
            this.labelAddProducts.TabIndex = 0;
            this.labelAddProducts.Text = "Add Products";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.BackColor = System.Drawing.Color.Transparent;
            this.labelProductId.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductId.Location = new System.Drawing.Point(340, 159);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(101, 24);
            this.labelProductId.TabIndex = 1;
            this.labelProductId.Text = "Product ID";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(340, 199);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(133, 24);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(340, 246);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 24);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(513, 159);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(258, 22);
            this.textBoxProductId.TabIndex = 2;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(513, 200);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(258, 22);
            this.textBoxProductName.TabIndex = 2;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(513, 246);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(258, 22);
            this.textBoxProductPrice.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(650, 321);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(121, 39);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(513, 321);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 39);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBoxAddPicture
            // 
            this.pictureBoxAddPicture.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxAddPicture.Location = new System.Drawing.Point(120, 148);
            this.pictureBoxAddPicture.Name = "pictureBoxAddPicture";
            this.pictureBoxAddPicture.Size = new System.Drawing.Size(170, 159);
            this.pictureBoxAddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddPicture.TabIndex = 4;
            this.pictureBoxAddPicture.TabStop = false;
            // 
            // buttonPicture
            // 
            this.buttonPicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPicture.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPicture.Location = new System.Drawing.Point(158, 321);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Size = new System.Drawing.Size(84, 28);
            this.buttonPicture.TabIndex = 5;
            this.buttonPicture.Text = "Picture";
            this.buttonPicture.UseVisualStyleBackColor = false;
            this.buttonPicture.Click += new System.EventHandler(this.buttonPicture_Click);
            // 
            // AddProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::POS_System.Properties.Resources.Download_premium_image_of_Rectangle_fast_food_frame_design_resource_by_katie_about_burger_background__burger_frame__beer__alcohol_beer_background_design__and_french_fries_23823541;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 631);
            this.Controls.Add(this.buttonPicture);
            this.Controls.Add(this.pictureBoxAddPicture);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.labelAddProducts);
            this.Name = "AddProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Products";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddProducts;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxAddPicture;
        private System.Windows.Forms.Button buttonPicture;
    }
}