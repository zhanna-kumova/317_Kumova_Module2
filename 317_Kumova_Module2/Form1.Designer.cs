namespace _317_Kumova_Module2
{
    partial class MenuForm
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
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.daytime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferences = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dinner = new System.Windows.Forms.PictureBox();
            this.describtion_label = new System.Windows.Forms.Label();
            this.breakfest = new System.Windows.Forms.PictureBox();
            this.lunch = new System.Windows.Forms.PictureBox();
            this.buttonget_result_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGridView
            // 
            this.menuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.menuGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.daytime,
            this.preferences});
            this.menuGridView.Location = new System.Drawing.Point(12, 1);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.RowHeadersWidth = 51;
            this.menuGridView.RowTemplate.Height = 24;
            this.menuGridView.Size = new System.Drawing.Size(280, 140);
            this.menuGridView.TabIndex = 0;
            // 
            // daytime
            // 
            this.daytime.HeaderText = "период";
            this.daytime.MinimumWidth = 6;
            this.daytime.Name = "daytime";
            this.daytime.Width = 85;
            // 
            // preferences
            // 
            this.preferences.HeaderText = "предпочтения";
            this.preferences.MinimumWidth = 6;
            this.preferences.Name = "preferences";
            this.preferences.Width = 109;
            // 
            // dinner
            // 
            this.dinner.Location = new System.Drawing.Point(289, 233);
            this.dinner.Name = "dinner";
            this.dinner.Size = new System.Drawing.Size(201, 183);
            this.dinner.TabIndex = 1;
            this.dinner.TabStop = false;
            // 
            // describtion_label
            // 
            this.describtion_label.AutoSize = true;
            this.describtion_label.Location = new System.Drawing.Point(314, 174);
            this.describtion_label.Name = "describtion_label";
            this.describtion_label.Size = new System.Drawing.Size(144, 17);
            this.describtion_label.TabIndex = 2;
            this.describtion_label.Text = "Попробуйте вот это:";
            // 
            // breakfest
            // 
            this.breakfest.Location = new System.Drawing.Point(29, 233);
            this.breakfest.Name = "breakfest";
            this.breakfest.Size = new System.Drawing.Size(203, 183);
            this.breakfest.TabIndex = 3;
            this.breakfest.TabStop = false;
            // 
            // lunch
            // 
            this.lunch.Location = new System.Drawing.Point(542, 233);
            this.lunch.Name = "lunch";
            this.lunch.Size = new System.Drawing.Size(201, 183);
            this.lunch.TabIndex = 4;
            this.lunch.TabStop = false;
            // 
            // buttonget_result_btn
            // 
            this.buttonget_result_btn.Location = new System.Drawing.Point(570, 72);
            this.buttonget_result_btn.Name = "buttonget_result_btn";
            this.buttonget_result_btn.Size = new System.Drawing.Size(143, 23);
            this.buttonget_result_btn.TabIndex = 5;
            this.buttonget_result_btn.Text = "Посоветовать";
            this.buttonget_result_btn.UseVisualStyleBackColor = true;
            this.buttonget_result_btn.Click += new System.EventHandler(this.buttonget_result_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "завтрак";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "обед";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ужин";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonget_result_btn);
            this.Controls.Add(this.lunch);
            this.Controls.Add(this.breakfest);
            this.Controls.Add(this.describtion_label);
            this.Controls.Add(this.dinner);
            this.Controls.Add(this.menuGridView);
            this.Name = "MenuForm";
            this.Text = "Menu ";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn daytime;
        private System.Windows.Forms.DataGridViewComboBoxColumn preferences;
        private System.Windows.Forms.PictureBox dinner;
        private System.Windows.Forms.Label describtion_label;
        private System.Windows.Forms.PictureBox breakfest;
        private System.Windows.Forms.PictureBox lunch;
        private System.Windows.Forms.Button buttonget_result_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

