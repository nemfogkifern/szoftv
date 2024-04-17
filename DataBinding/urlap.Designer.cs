namespace DataBinding
{
    partial class urlap
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
            components = new System.ComponentModel.Container();
            okButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTextBox = new TextBox();
            PopulationTextBox = new TextBox();
            AreaTextBox = new TextBox();
            bindingSource1 = new BindingSource(components);
            countryDataBindingSource = new BindingSource(components);
            countryDataBindingSource1 = new BindingSource(components);
            countryDataBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(141, 332);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 34);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 1;
            label1.Text = "Country Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 230);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 2;
            label2.Text = "Area in km2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 131);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 3;
            label3.Text = "Population:";
            // 
            // NameTextBox
            // 
            NameTextBox.DataBindings.Add(new Binding("Text", countryDataBindingSource, "Name", true));
            NameTextBox.Location = new Point(38, 73);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(318, 31);
            NameTextBox.TabIndex = 4;
            // 
            // PopulationTextBox
            // 
            PopulationTextBox.DataBindings.Add(new Binding("Text", countryDataBindingSource1, "Population", true));
            PopulationTextBox.Location = new Point(38, 169);
            PopulationTextBox.Name = "PopulationTextBox";
            PopulationTextBox.Size = new Size(318, 31);
            PopulationTextBox.TabIndex = 5;
            // 
            // AreaTextBox
            // 
            AreaTextBox.DataBindings.Add(new Binding("Text", countryDataBindingSource2, "AreaInSquareKm", true));
            AreaTextBox.Location = new Point(38, 271);
            AreaTextBox.Name = "AreaTextBox";
            AreaTextBox.Size = new Size(318, 31);
            AreaTextBox.TabIndex = 6;
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // countryDataBindingSource1
            // 
            countryDataBindingSource1.DataSource = typeof(CountryData);
            // 
            // countryDataBindingSource2
            // 
            countryDataBindingSource2.DataSource = typeof(CountryData);
            // 
            // urlap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 400);
            Controls.Add(AreaTextBox);
            Controls.Add(PopulationTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(okButton);
            Name = "urlap";
            Text = "urlap";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTextBox;
        private TextBox PopulationTextBox;
        private TextBox AreaTextBox;
        private BindingSource bindingSource1;
        private BindingSource countryDataBindingSource;
        private BindingSource countryDataBindingSource1;
        private BindingSource countryDataBindingSource2;
    }
}