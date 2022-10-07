namespace SGM_Management_System
{
    partial class frm_View_Student_Details
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Vies_Student_Details = new System.Windows.Forms.Label();
            this.dgv_Student_Details_Table = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._S_SGM_Mgt_System_dbDataSet1 = new SGM_Management_System._S_SGM_Mgt_System_dbDataSet1();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter = new SGM_Management_System._S_SGM_Mgt_System_dbDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.btn_Add_Student_Details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_SGM_Mgt_System_dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Vies_Student_Details
            // 
            this.lbl_Vies_Student_Details.AutoSize = true;
            this.lbl_Vies_Student_Details.BackColor = System.Drawing.Color.Pink;
            this.lbl_Vies_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vies_Student_Details.Location = new System.Drawing.Point(245, 19);
            this.lbl_Vies_Student_Details.Name = "lbl_Vies_Student_Details";
            this.lbl_Vies_Student_Details.Size = new System.Drawing.Size(390, 44);
            this.lbl_Vies_Student_Details.TabIndex = 6;
            this.lbl_Vies_Student_Details.Text = "View Student Details";
            // 
            // dgv_Student_Details_Table
            // 
            this.dgv_Student_Details_Table.AllowUserToAddRows = false;
            this.dgv_Student_Details_Table.AllowUserToDeleteRows = false;
            this.dgv_Student_Details_Table.AutoGenerateColumns = false;
            this.dgv_Student_Details_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_Details_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_Details_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.mobilenoDataGridViewTextBoxColumn});
            this.dgv_Student_Details_Table.DataSource = this.studentDetailsBindingSource;
            this.dgv_Student_Details_Table.Location = new System.Drawing.Point(12, 84);
            this.dgv_Student_Details_Table.Name = "dgv_Student_Details_Table";
            this.dgv_Student_Details_Table.ReadOnly = true;
            this.dgv_Student_Details_Table.Size = new System.Drawing.Size(852, 354);
            this.dgv_Student_Details_Table.TabIndex = 1;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobilenoDataGridViewTextBoxColumn
            // 
            this.mobilenoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.HeaderText = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.Name = "mobilenoDataGridViewTextBoxColumn";
            this.mobilenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this._S_SGM_Mgt_System_dbDataSet1;
            // 
            // _S_SGM_Mgt_System_dbDataSet1
            // 
            this._S_SGM_Mgt_System_dbDataSet1.DataSetName = "_S_SGM_Mgt_System_dbDataSet1";
            this._S_SGM_Mgt_System_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(737, 1);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(138, 44);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Add_Student_Details
            // 
            this.btn_Add_Student_Details.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Add_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Student_Details.Location = new System.Drawing.Point(280, 460);
            this.btn_Add_Student_Details.Name = "btn_Add_Student_Details";
            this.btn_Add_Student_Details.Size = new System.Drawing.Size(310, 44);
            this.btn_Add_Student_Details.TabIndex = 2;
            this.btn_Add_Student_Details.Text = "Add Student Details";
            this.btn_Add_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Add_Student_Details.Click += new System.EventHandler(this.btn_Add_Student_Details_Click);
            // 
            // frm_View_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(876, 531);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add_Student_Details);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.dgv_Student_Details_Table);
            this.Controls.Add(this.lbl_Vies_Student_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student Details";
            this.Load += new System.EventHandler(this.frm_View_Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._S_SGM_Mgt_System_dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Vies_Student_Details;
        private System.Windows.Forms.DataGridView dgv_Student_Details_Table;
        private System.Windows.Forms.Button btn_Log_Out;
        private _S_SGM_Mgt_System_dbDataSet1 _S_SGM_Mgt_System_dbDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private _S_SGM_Mgt_System_dbDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Add_Student_Details;
    }
}