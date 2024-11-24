namespace DressCode.forms
{
    partial class DressAccessories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DressAccessories));
            this.label8 = new System.Windows.Forms.Label();
            this.DG_View = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ClearButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Add_button = new Guna.UI2.WinForms.Guna2Button();
            this.Delete_button = new Guna.UI2.WinForms.Guna2Button();
            this.Update_button = new Guna.UI2.WinForms.Guna2Button();
            this.Count_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Quality_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.Category_box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Size_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Price_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brend_box = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_View)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(34, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(352, 38);
            this.label8.TabIndex = 26;
            this.label8.Text = "Склад аксессуаров:";
            // 
            // DG_View
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DG_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_View.ColumnHeadersHeight = 4;
            this.DG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_View.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DG_View.Location = new System.Drawing.Point(499, 110);
            this.DG_View.Name = "DG_View";
            this.DG_View.RowHeadersVisible = false;
            this.DG_View.Size = new System.Drawing.Size(864, 562);
            this.DG_View.TabIndex = 25;
            this.DG_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DG_View.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DG_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DG_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DG_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DG_View.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DG_View.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DG_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DG_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_View.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DG_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DG_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DG_View.ThemeStyle.HeaderStyle.Height = 4;
            this.DG_View.ThemeStyle.ReadOnly = false;
            this.DG_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DG_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DG_View.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DG_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DG_View.ThemeStyle.RowsStyle.Height = 22;
            this.DG_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DG_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.brend_box);
            this.guna2GroupBox1.Controls.Add(this.ClearButton);
            this.guna2GroupBox1.Controls.Add(this.Add_button);
            this.guna2GroupBox1.Controls.Add(this.Delete_button);
            this.guna2GroupBox1.Controls.Add(this.Update_button);
            this.guna2GroupBox1.Controls.Add(this.Count_tb);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.ID_tb);
            this.guna2GroupBox1.Controls.Add(this.Quality_tb);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.loginLabel);
            this.guna2GroupBox1.Controls.Add(this.Category_box);
            this.guna2GroupBox1.Controls.Add(this.passwordLabel);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.Size_tb);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.Price_tb);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(28, 110);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(447, 562);
            this.guna2GroupBox1.TabIndex = 24;
            this.guna2GroupBox1.Text = "Поля для работы с данными:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageRotate = 0F;
            this.ClearButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("ClearButton.InitialImage")));
            this.ClearButton.Location = new System.Drawing.Point(356, 511);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(60, 46);
            this.ClearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClearButton.TabIndex = 23;
            this.ClearButton.TabStop = false;
            // 
            // Add_button
            // 
            this.Add_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.Location = new System.Drawing.Point(127, 512);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(180, 45);
            this.Add_button.TabIndex = 22;
            this.Add_button.Text = "Добавить";
            // 
            // Delete_button
            // 
            this.Delete_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Location = new System.Drawing.Point(236, 461);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(180, 45);
            this.Delete_button.TabIndex = 21;
            this.Delete_button.Text = "Удалить";
            // 
            // Update_button
            // 
            this.Update_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Update_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Update_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Update_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Update_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Update_button.ForeColor = System.Drawing.Color.White;
            this.Update_button.Location = new System.Drawing.Point(23, 461);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(180, 45);
            this.Update_button.TabIndex = 20;
            this.Update_button.Text = "Обновить";
            // 
            // Count_tb
            // 
            this.Count_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Count_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Count_tb.DefaultText = "";
            this.Count_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Count_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Count_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Count_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Count_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Count_tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_tb.ForeColor = System.Drawing.Color.Black;
            this.Count_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Count_tb.Location = new System.Drawing.Point(147, 115);
            this.Count_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Count_tb.Name = "Count_tb";
            this.Count_tb.PasswordChar = '*';
            this.Count_tb.PlaceholderText = "";
            this.Count_tb.SelectedText = "";
            this.Count_tb.Size = new System.Drawing.Size(236, 33);
            this.Count_tb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(19, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Качество:";
            // 
            // ID_tb
            // 
            this.ID_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_tb.DefaultText = "";
            this.ID_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ID_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ID_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID_tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_tb.ForeColor = System.Drawing.Color.Black;
            this.ID_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID_tb.Location = new System.Drawing.Point(147, 63);
            this.ID_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ID_tb.Name = "ID_tb";
            this.ID_tb.PasswordChar = '\0';
            this.ID_tb.PlaceholderText = "";
            this.ID_tb.SelectedText = "";
            this.ID_tb.Size = new System.Drawing.Size(236, 33);
            this.ID_tb.TabIndex = 7;
            // 
            // Quality_tb
            // 
            this.Quality_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Quality_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quality_tb.DefaultText = "";
            this.Quality_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Quality_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Quality_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quality_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quality_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quality_tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quality_tb.ForeColor = System.Drawing.Color.Black;
            this.Quality_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quality_tb.Location = new System.Drawing.Point(147, 354);
            this.Quality_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quality_tb.Name = "Quality_tb";
            this.Quality_tb.PasswordChar = '*';
            this.Quality_tb.PlaceholderText = "";
            this.Quality_tb.SelectedText = "";
            this.Quality_tb.Size = new System.Drawing.Size(236, 33);
            this.Quality_tb.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Категория:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.White;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(19, 77);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(28, 19);
            this.loginLabel.TabIndex = 9;
            this.loginLabel.Text = "ID:";
            // 
            // Category_box
            // 
            this.Category_box.BackColor = System.Drawing.Color.Transparent;
            this.Category_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Category_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_box.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Category_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Category_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Category_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Category_box.ItemHeight = 30;
            this.Category_box.Location = new System.Drawing.Point(147, 405);
            this.Category_box.Name = "Category_box";
            this.Category_box.Size = new System.Drawing.Size(236, 36);
            this.Category_box.TabIndex = 16;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.White;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(19, 192);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 19);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Бренд:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Количество:";
            // 
            // Size_tb
            // 
            this.Size_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Size_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Size_tb.DefaultText = "";
            this.Size_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Size_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Size_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Size_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Size_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Size_tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size_tb.ForeColor = System.Drawing.Color.Black;
            this.Size_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Size_tb.Location = new System.Drawing.Point(147, 235);
            this.Size_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Size_tb.Name = "Size_tb";
            this.Size_tb.PasswordChar = '*';
            this.Size_tb.PlaceholderText = "";
            this.Size_tb.SelectedText = "";
            this.Size_tb.Size = new System.Drawing.Size(236, 33);
            this.Size_tb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Размер:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена:";
            // 
            // Price_tb
            // 
            this.Price_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Price_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price_tb.DefaultText = "";
            this.Price_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Price_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Price_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Price_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Price_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Price_tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_tb.ForeColor = System.Drawing.Color.Black;
            this.Price_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Price_tb.Location = new System.Drawing.Point(147, 293);
            this.Price_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Price_tb.Name = "Price_tb";
            this.Price_tb.PasswordChar = '*';
            this.Price_tb.PlaceholderText = "";
            this.Price_tb.SelectedText = "";
            this.Price_tb.Size = new System.Drawing.Size(236, 33);
            this.Price_tb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(312, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "DressCode 1.0 Система управления магазином";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1295, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(49, 47);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 31;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1350, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 44);
            this.label2.TabIndex = 30;
            this.label2.Text = "X";
            // 
            // brend_box
            // 
            this.brend_box.BackColor = System.Drawing.Color.Transparent;
            this.brend_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.brend_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brend_box.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brend_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brend_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.brend_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.brend_box.ItemHeight = 30;
            this.brend_box.Location = new System.Drawing.Point(147, 175);
            this.brend_box.Name = "brend_box";
            this.brend_box.Size = new System.Drawing.Size(236, 36);
            this.brend_box.TabIndex = 24;
            // 
            // DressAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DG_View);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DressAccessories";
            this.Text = "DressAccessories";
            ((System.ComponentModel.ISupportInitialize)(this.DG_View)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView DG_View;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox ClearButton;
        private Guna.UI2.WinForms.Guna2Button Add_button;
        private Guna.UI2.WinForms.Guna2Button Delete_button;
        private Guna.UI2.WinForms.Guna2Button Update_button;
        private Guna.UI2.WinForms.Guna2TextBox Count_tb;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox ID_tb;
        private Guna.UI2.WinForms.Guna2TextBox Quality_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label loginLabel;
        private Guna.UI2.WinForms.Guna2ComboBox Category_box;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox Size_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox Price_tb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox brend_box;
    }
}