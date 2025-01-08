namespace Form21Files
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstNombres = new ListBox();
            btnNew = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            txtContenido = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 24);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 24);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(359, 59);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(211, 289);
            lstNombres.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(231, 123);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 26);
            btnNew.TabIndex = 4;
            btnNew.Text = "new Name";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(231, 182);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(100, 25);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(231, 244);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(100, 27);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(12, 59);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(193, 294);
            txtContenido.TabIndex = 7;
            txtContenido.TextChanged += txtContenido_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(231, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 366);
            Controls.Add(txtNombre);
            Controls.Add(txtContenido);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(btnNew);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstNombres;
        private Button btnNew;
        private Button btnRead;
        private Button btnWrite;
        private TextBox txtContenido;
        private TextBox txtNombre;
    }
}
