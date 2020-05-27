namespace Furnitures
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonZakaz = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonAgents = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZakaz
            // 
            this.buttonZakaz.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonZakaz.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonZakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZakaz.Font = new System.Drawing.Font("Rounds Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakaz.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonZakaz.Location = new System.Drawing.Point(12, 315);
            this.buttonZakaz.Name = "buttonZakaz";
            this.buttonZakaz.Size = new System.Drawing.Size(292, 70);
            this.buttonZakaz.TabIndex = 9;
            this.buttonZakaz.Text = "Оформить заказ";
            this.buttonZakaz.UseVisualStyleBackColor = false;
            this.buttonZakaz.Click += new System.EventHandler(this.buttonZakaz_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonProducts.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Rounds Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProducts.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonProducts.Location = new System.Drawing.Point(12, 239);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(292, 70);
            this.buttonProducts.TabIndex = 8;
            this.buttonProducts.Text = "Данные о товарах";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonAgents
            // 
            this.buttonAgents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgents.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgents.Font = new System.Drawing.Font("Rounds Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAgents.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAgents.Location = new System.Drawing.Point(12, 163);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(292, 70);
            this.buttonAgents.TabIndex = 7;
            this.buttonAgents.Text = "Данные о менеджерах";
            this.buttonAgents.UseVisualStyleBackColor = false;
            this.buttonAgents.Click += new System.EventHandler(this.buttonAgents_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClients.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Rounds Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonClients.Location = new System.Drawing.Point(12, 87);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(292, 70);
            this.buttonClients.TabIndex = 6;
            this.buttonClients.Text = "Данные о клиентах";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Furnitures.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(316, 394);
            this.Controls.Add(this.buttonZakaz);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonAgents);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonZakaz;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonAgents;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

