namespace POS_System
{
    partial class Start
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonStart.Location = new System.Drawing.Point(388, 226);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(224, 73);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdmin.BackgroundImage = global::POS_System.Properties.Resources.Google_Images;
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdmin.Location = new System.Drawing.Point(0, 2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(46, 39);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // Start
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::POS_System.Properties.Resources.Cartoon_Restaurant_Chef_Recruitment_Design_Poster_Vector_Background_Wallpaper_Image_For_Free_Download___Pngtree;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 631);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonStart);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
  
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAdmin;
    }
}