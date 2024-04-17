namespace ZHMinta
{
    partial class FormEdit
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
            textBox6 = new TextBox();
            vizsgaKerdesBindingSource = new BindingSource(components);
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)vizsgaKerdesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "Kep", true));
            textBox6.Location = new Point(60, 451);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(438, 31);
            textBox6.TabIndex = 15;
            // 
            // vizsgaKerdesBindingSource
            // 
            vizsgaKerdesBindingSource.DataSource = typeof(VizsgaKerdes);
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "V3", true));
            textBox5.Location = new Point(60, 390);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(438, 31);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "V2", true));
            textBox4.Location = new Point(60, 311);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(438, 31);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "V1", true));
            textBox3.Location = new Point(60, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(438, 31);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "Kerdes", true));
            textBox2.Location = new Point(60, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(438, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "Szam", true));
            textBox1.Location = new Point(60, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(438, 31);
            textBox1.TabIndex = 10;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(224, 554);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(386, 554);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", vizsgaKerdesBindingSource, "HelyesValasz", true));
            textBox7.Location = new Point(60, 504);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(438, 31);
            textBox7.TabIndex = 16;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 625);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormEdit";
            Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)vizsgaKerdesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
    private BindingSource vizsgaKerdesBindingSource;
    private TextBox textBox5;
    private TextBox textBox4;
    private TextBox textBox3;
    private TextBox textBox2;
    private TextBox textBox1;
    private Button button2;
    private Button button1;
    private TextBox textBox7;
}
}