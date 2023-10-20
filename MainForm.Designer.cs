namespace CustomDataList
{
    partial class MainForm
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
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_RemIndex = new System.Windows.Forms.Button();
            this.BTN_RemFirst = new System.Windows.Forms.Button();
            this.BTN_RemLast = new System.Windows.Forms.Button();
            this.BTN_Load = new System.Windows.Forms.Button();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.TXT_Last = new System.Windows.Forms.TextBox();
            this.TXT_Num = new System.Windows.Forms.TextBox();
            this.TXT_Score = new System.Windows.Forms.TextBox();
            this.TXT_Index = new System.Windows.Forms.TextBox();
            this.TXT_Load = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LIST_Students = new System.Windows.Forms.DataGridView();
            this.BTN_Clear_Data_Grid = new System.Windows.Forms.Button();
            this.BTN_Clear_File = new System.Windows.Forms.Button();
            this.COMBO_Items = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.COMBO_Direction = new System.Windows.Forms.ComboBox();
            this.BTN_Sort = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LIST_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.Location = new System.Drawing.Point(56, 152);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(301, 34);
            this.BTN_Add.TabIndex = 5;
            this.BTN_Add.Text = "Add New Student Information";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_RemIndex
            // 
            this.BTN_RemIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RemIndex.Location = new System.Drawing.Point(211, 210);
            this.BTN_RemIndex.Name = "BTN_RemIndex";
            this.BTN_RemIndex.Size = new System.Drawing.Size(169, 34);
            this.BTN_RemIndex.TabIndex = 7;
            this.BTN_RemIndex.TabStop = false;
            this.BTN_RemIndex.Text = "Remove Index";
            this.BTN_RemIndex.UseVisualStyleBackColor = true;
            this.BTN_RemIndex.Click += new System.EventHandler(this.BTN_RemIndex_Click);
            // 
            // BTN_RemFirst
            // 
            this.BTN_RemFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RemFirst.Location = new System.Drawing.Point(36, 250);
            this.BTN_RemFirst.Name = "BTN_RemFirst";
            this.BTN_RemFirst.Size = new System.Drawing.Size(169, 34);
            this.BTN_RemFirst.TabIndex = 8;
            this.BTN_RemFirst.TabStop = false;
            this.BTN_RemFirst.Text = "Remove First";
            this.BTN_RemFirst.UseVisualStyleBackColor = true;
            this.BTN_RemFirst.Click += new System.EventHandler(this.BTN_RemFirst_Click);
            // 
            // BTN_RemLast
            // 
            this.BTN_RemLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RemLast.Location = new System.Drawing.Point(211, 250);
            this.BTN_RemLast.Name = "BTN_RemLast";
            this.BTN_RemLast.Size = new System.Drawing.Size(169, 34);
            this.BTN_RemLast.TabIndex = 9;
            this.BTN_RemLast.TabStop = false;
            this.BTN_RemLast.Text = "Remove Last";
            this.BTN_RemLast.UseVisualStyleBackColor = true;
            this.BTN_RemLast.Click += new System.EventHandler(this.BTN_RemLast_Click);
            // 
            // BTN_Load
            // 
            this.BTN_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Load.Location = new System.Drawing.Point(15, 428);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(107, 34);
            this.BTN_Load.TabIndex = 0;
            this.BTN_Load.TabStop = false;
            this.BTN_Load.Text = "Load File";
            this.BTN_Load.UseVisualStyleBackColor = true;
            this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // TXT_Name
            // 
            this.TXT_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Name.Location = new System.Drawing.Point(211, 12);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(208, 29);
            this.TXT_Name.TabIndex = 1;
            // 
            // TXT_Last
            // 
            this.TXT_Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Last.Location = new System.Drawing.Point(211, 47);
            this.TXT_Last.Name = "TXT_Last";
            this.TXT_Last.Size = new System.Drawing.Size(208, 29);
            this.TXT_Last.TabIndex = 2;
            // 
            // TXT_Num
            // 
            this.TXT_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Num.Location = new System.Drawing.Point(211, 82);
            this.TXT_Num.Name = "TXT_Num";
            this.TXT_Num.Size = new System.Drawing.Size(208, 29);
            this.TXT_Num.TabIndex = 3;
            // 
            // TXT_Score
            // 
            this.TXT_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Score.Location = new System.Drawing.Point(211, 117);
            this.TXT_Score.Name = "TXT_Score";
            this.TXT_Score.Size = new System.Drawing.Size(208, 29);
            this.TXT_Score.TabIndex = 4;
            // 
            // TXT_Index
            // 
            this.TXT_Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Index.Location = new System.Drawing.Point(36, 212);
            this.TXT_Index.Name = "TXT_Index";
            this.TXT_Index.Size = new System.Drawing.Size(169, 29);
            this.TXT_Index.TabIndex = 6;
            this.TXT_Index.TabStop = false;
            // 
            // TXT_Load
            // 
            this.TXT_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Load.Location = new System.Drawing.Point(128, 430);
            this.TXT_Load.Name = "TXT_Load";
            this.TXT_Load.ReadOnly = true;
            this.TXT_Load.Size = new System.Drawing.Size(641, 29);
            this.TXT_Load.TabIndex = 0;
            this.TXT_Load.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Student Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Final Score:";
            // 
            // LIST_Students
            // 
            this.LIST_Students.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LIST_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LIST_Students.Location = new System.Drawing.Point(425, 12);
            this.LIST_Students.Name = "LIST_Students";
            this.LIST_Students.RowHeadersWidth = 62;
            this.LIST_Students.Size = new System.Drawing.Size(457, 412);
            this.LIST_Students.TabIndex = 16;
            this.LIST_Students.TabStop = false;
            // 
            // BTN_Clear_Data_Grid
            // 
            this.BTN_Clear_Data_Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clear_Data_Grid.Location = new System.Drawing.Point(128, 381);
            this.BTN_Clear_Data_Grid.Name = "BTN_Clear_Data_Grid";
            this.BTN_Clear_Data_Grid.Size = new System.Drawing.Size(183, 34);
            this.BTN_Clear_Data_Grid.TabIndex = 17;
            this.BTN_Clear_Data_Grid.TabStop = false;
            this.BTN_Clear_Data_Grid.Text = "Clear Data Grid";
            this.BTN_Clear_Data_Grid.UseVisualStyleBackColor = true;
            this.BTN_Clear_Data_Grid.Click += new System.EventHandler(this.BTN_Clear_Data_Grid_Click);
            // 
            // BTN_Clear_File
            // 
            this.BTN_Clear_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clear_File.Location = new System.Drawing.Point(15, 381);
            this.BTN_Clear_File.Name = "BTN_Clear_File";
            this.BTN_Clear_File.Size = new System.Drawing.Size(107, 34);
            this.BTN_Clear_File.TabIndex = 18;
            this.BTN_Clear_File.TabStop = false;
            this.BTN_Clear_File.Text = "Clear File";
            this.BTN_Clear_File.UseVisualStyleBackColor = true;
            this.BTN_Clear_File.Click += new System.EventHandler(this.BTN_Clear_File_Click);
            // 
            // COMBO_Items
            // 
            this.COMBO_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_Items.FormattingEnabled = true;
            this.COMBO_Items.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Number",
            "Score"});
            this.COMBO_Items.Location = new System.Drawing.Point(113, 299);
            this.COMBO_Items.Name = "COMBO_Items";
            this.COMBO_Items.Size = new System.Drawing.Size(150, 24);
            this.COMBO_Items.TabIndex = 19;
            this.COMBO_Items.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Order By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Direction:";
            // 
            // COMBO_Direction
            // 
            this.COMBO_Direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_Direction.FormattingEnabled = true;
            this.COMBO_Direction.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.COMBO_Direction.Location = new System.Drawing.Point(113, 329);
            this.COMBO_Direction.Name = "COMBO_Direction";
            this.COMBO_Direction.Size = new System.Drawing.Size(150, 24);
            this.COMBO_Direction.TabIndex = 22;
            this.COMBO_Direction.TabStop = false;
            // 
            // BTN_Sort
            // 
            this.BTN_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sort.Location = new System.Drawing.Point(280, 299);
            this.BTN_Sort.Name = "BTN_Sort";
            this.BTN_Sort.Size = new System.Drawing.Size(121, 54);
            this.BTN_Sort.TabIndex = 23;
            this.BTN_Sort.TabStop = false;
            this.BTN_Sort.Text = "Sort";
            this.BTN_Sort.UseVisualStyleBackColor = true;
            this.BTN_Sort.Click += new System.EventHandler(this.BTN_Sort_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.Location = new System.Drawing.Point(775, 428);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(107, 34);
            this.BTN_Save.TabIndex = 24;
            this.BTN_Save.TabStop = false;
            this.BTN_Save.Text = "Save List";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 472);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.BTN_Sort);
            this.Controls.Add(this.COMBO_Direction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.COMBO_Items);
            this.Controls.Add(this.BTN_Clear_File);
            this.Controls.Add(this.BTN_Clear_Data_Grid);
            this.Controls.Add(this.LIST_Students);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_Load);
            this.Controls.Add(this.TXT_Index);
            this.Controls.Add(this.TXT_Score);
            this.Controls.Add(this.TXT_Num);
            this.Controls.Add(this.TXT_Last);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.BTN_Load);
            this.Controls.Add(this.BTN_RemLast);
            this.Controls.Add(this.BTN_RemFirst);
            this.Controls.Add(this.BTN_RemIndex);
            this.Controls.Add(this.BTN_Add);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Data List";
            ((System.ComponentModel.ISupportInitialize)(this.LIST_Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_RemIndex;
        private System.Windows.Forms.Button BTN_RemFirst;
        private System.Windows.Forms.Button BTN_RemLast;
        private System.Windows.Forms.Button BTN_Load;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.TextBox TXT_Last;
        private System.Windows.Forms.TextBox TXT_Num;
        private System.Windows.Forms.TextBox TXT_Score;
        private System.Windows.Forms.TextBox TXT_Index;
        private System.Windows.Forms.TextBox TXT_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView LIST_Students;
        private System.Windows.Forms.Button BTN_Clear_Data_Grid;
        private System.Windows.Forms.Button BTN_Clear_File;
        private System.Windows.Forms.ComboBox COMBO_Items;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox COMBO_Direction;
        private System.Windows.Forms.Button BTN_Sort;
        private System.Windows.Forms.Button BTN_Save;
    }
}

