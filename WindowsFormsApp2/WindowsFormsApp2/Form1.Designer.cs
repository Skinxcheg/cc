namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timePick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.doctorsDataSet = new WindowsFormsApp2.doctorsDataSet();
            this.tableAdapterManager = new WindowsFormsApp2.doctorsDataSetTableAdapters.TableAdapterManager();
            this.doctorsTableAdapter = new WindowsFormsApp2.doctorsDataSetTableAdapters.doctorsTableAdapter();
            this.doctorFullNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorFullNameTableAdapter = new WindowsFormsApp2.doctorsDataSetTableAdapters.doctorFullNameTableAdapter();
            this.doctorFullNameComboBox = new System.Windows.Forms.ComboBox();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new WindowsFormsApp2.doctorsDataSetTableAdapters.clientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorFullNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timePick
            // 
            this.timePick.Location = new System.Drawing.Point(19, 94);
            this.timePick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timePick.Name = "timePick";
            this.timePick.Size = new System.Drawing.Size(265, 22);
            this.timePick.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Запись на прием";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата приёма";
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(19, 188);
            this.ClientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(265, 22);
            this.ClientName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон";
            // 
            // ClientPhone
            // 
            this.ClientPhone.Location = new System.Drawing.Point(19, 236);
            this.ClientPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(265, 22);
            this.ClientPhone.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(19, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Записаться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddClientToDB);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выберите врача";
            // 
            // doctorsDataSet
            // 
            this.doctorsDataSet.DataSetName = "doctorsDataSet";
            this.doctorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.doctorFullNameTableAdapter = null;
            this.tableAdapterManager.doctorsTableAdapter = this.doctorsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.doctorsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorFullNameBindingSource
            // 
            this.doctorFullNameBindingSource.DataMember = "doctorFullName";
            this.doctorFullNameBindingSource.DataSource = this.doctorsDataSet;
            // 
            // doctorFullNameTableAdapter
            // 
            this.doctorFullNameTableAdapter.ClearBeforeFill = true;
            // 
            // doctorFullNameComboBox
            // 
            this.doctorFullNameComboBox.DataSource = this.doctorFullNameBindingSource;
            this.doctorFullNameComboBox.DisplayMember = "FullName";
            this.doctorFullNameComboBox.FormattingEnabled = true;
            this.doctorFullNameComboBox.Location = new System.Drawing.Point(19, 141);
            this.doctorFullNameComboBox.Name = "doctorFullNameComboBox";
            this.doctorFullNameComboBox.Size = new System.Drawing.Size(265, 24);
            this.doctorFullNameComboBox.TabIndex = 10;
            this.doctorFullNameComboBox.ValueMember = "Id";
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.doctorsDataSet;
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "doctors";
            this.doctorsBindingSource1.DataSource = this.doctorsDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Записи доктора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkDoctorClients);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 392);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.doctorFullNameComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePick);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorFullNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timePick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private doctorsDataSet doctorsDataSet;
        private doctorsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource doctorFullNameBindingSource;
        private doctorsDataSetTableAdapters.doctorFullNameTableAdapter doctorFullNameTableAdapter;
        private System.Windows.Forms.ComboBox doctorFullNameComboBox;
        private doctorsDataSetTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private System.Windows.Forms.Button button2;
        private doctorsDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
    }
}

