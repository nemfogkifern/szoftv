namespace ZHMinta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            szamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kerdesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            helyesValaszDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vizsgaKerdesBindingSource = new BindingSource(components);
            OpenButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            newButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vizsgaKerdesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { szamDataGridViewTextBoxColumn, kerdesDataGridViewTextBoxColumn, v1DataGridViewTextBoxColumn, v2DataGridViewTextBoxColumn, v3DataGridViewTextBoxColumn, kepDataGridViewTextBoxColumn, helyesValaszDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vizsgaKerdesBindingSource;
            dataGridView1.Location = new Point(21, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(701, 716);
            dataGridView1.TabIndex = 0;
            // 
            // szamDataGridViewTextBoxColumn
            // 
            szamDataGridViewTextBoxColumn.DataPropertyName = "Szam";
            szamDataGridViewTextBoxColumn.HeaderText = "Szam";
            szamDataGridViewTextBoxColumn.MinimumWidth = 8;
            szamDataGridViewTextBoxColumn.Name = "szamDataGridViewTextBoxColumn";
            szamDataGridViewTextBoxColumn.Width = 150;
            // 
            // kerdesDataGridViewTextBoxColumn
            // 
            kerdesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kerdesDataGridViewTextBoxColumn.DataPropertyName = "Kerdes";
            kerdesDataGridViewTextBoxColumn.HeaderText = "Kerdes";
            kerdesDataGridViewTextBoxColumn.MinimumWidth = 8;
            kerdesDataGridViewTextBoxColumn.Name = "kerdesDataGridViewTextBoxColumn";
            // 
            // v1DataGridViewTextBoxColumn
            // 
            v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            v1DataGridViewTextBoxColumn.HeaderText = "V1";
            v1DataGridViewTextBoxColumn.MinimumWidth = 8;
            v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            v1DataGridViewTextBoxColumn.Visible = false;
            v1DataGridViewTextBoxColumn.Width = 150;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            v2DataGridViewTextBoxColumn.HeaderText = "V2";
            v2DataGridViewTextBoxColumn.MinimumWidth = 8;
            v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            v2DataGridViewTextBoxColumn.Visible = false;
            v2DataGridViewTextBoxColumn.Width = 150;
            // 
            // v3DataGridViewTextBoxColumn
            // 
            v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            v3DataGridViewTextBoxColumn.HeaderText = "V3";
            v3DataGridViewTextBoxColumn.MinimumWidth = 8;
            v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            v3DataGridViewTextBoxColumn.Visible = false;
            v3DataGridViewTextBoxColumn.Width = 150;
            // 
            // kepDataGridViewTextBoxColumn
            // 
            kepDataGridViewTextBoxColumn.DataPropertyName = "Kep";
            kepDataGridViewTextBoxColumn.HeaderText = "Kep";
            kepDataGridViewTextBoxColumn.MinimumWidth = 8;
            kepDataGridViewTextBoxColumn.Name = "kepDataGridViewTextBoxColumn";
            kepDataGridViewTextBoxColumn.Visible = false;
            kepDataGridViewTextBoxColumn.Width = 150;
            // 
            // helyesValaszDataGridViewTextBoxColumn
            // 
            helyesValaszDataGridViewTextBoxColumn.DataPropertyName = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.HeaderText = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.MinimumWidth = 8;
            helyesValaszDataGridViewTextBoxColumn.Name = "helyesValaszDataGridViewTextBoxColumn";
            helyesValaszDataGridViewTextBoxColumn.Visible = false;
            helyesValaszDataGridViewTextBoxColumn.Width = 150;
            // 
            // vizsgaKerdesBindingSource
            // 
            vizsgaKerdesBindingSource.DataSource = typeof(VizsgaKerdes);
            // 
            // OpenButton
            // 
            OpenButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenButton.Location = new Point(1482, 25);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(146, 51);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.Location = new Point(1482, 770);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(143, 46);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.Location = new Point(1321, 770);
            editButton.Name = "editButton";
            editButton.Size = new Size(143, 46);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveButton.Location = new Point(1321, 25);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(151, 51);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "V1", true));
            textBox1.Location = new Point(927, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(698, 132);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "V2", true));
            textBox2.Location = new Point(927, 277);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(698, 132);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "V3", true));
            textBox3.Location = new Point(927, 450);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(698, 132);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "HelyesValasz", true));
            textBox4.Location = new Point(927, 608);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(698, 132);
            textBox4.TabIndex = 8;
            // 
            // newButton
            // 
            newButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newButton.Location = new Point(1154, 771);
            newButton.Name = "newButton";
            newButton.Size = new Size(143, 46);
            newButton.TabIndex = 9;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1652, 845);
            Controls.Add(newButton);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(saveButton);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(OpenButton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vizsgaKerdesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button OpenButton;
        private Button deleteButton;
        private Button editButton;
        private Button saveButton;
        private BindingSource vizsgaKerdesBindingSource;
        private DataGridViewTextBoxColumn szamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kerdesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn helyesValaszDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button newButton;
    }
}
