namespace CapaVisual
{
    partial class frmPropietario
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
            GuardarPropietario = new Button();
            ApellidosTextBox = new TextBox();
            TelefonoTextBox = new TextBox();
            DNITextBox = new TextBox();
            NombresTextBox = new TextBox();
            CorreoTextBox = new TextBox();
            DireccionTextBox = new TextBox();
            NombresLabel = new Label();
            ApellidosLabel = new Label();
            DNILabel = new Label();
            CorreoLabel = new Label();
            TelefonoLabel = new Label();
            DireccionLabel = new Label();
            SuspendLayout();
            // 
            // GuardarPropietario
            // 
            GuardarPropietario.Location = new Point(558, 283);
            GuardarPropietario.Name = "GuardarPropietario";
            GuardarPropietario.Size = new Size(137, 55);
            GuardarPropietario.TabIndex = 0;
            GuardarPropietario.Text = "Guardar Propietario";
            GuardarPropietario.UseVisualStyleBackColor = true;
            GuardarPropietario.Click += GuardarPropietario_Click;
            // 
            // ApellidosTextBox
            // 
            ApellidosTextBox.Location = new Point(194, 97);
            ApellidosTextBox.Name = "ApellidosTextBox";
            ApellidosTextBox.Size = new Size(100, 23);
            ApellidosTextBox.TabIndex = 1;
            // 
            // TelefonoTextBox
            // 
            TelefonoTextBox.Location = new Point(194, 232);
            TelefonoTextBox.Name = "TelefonoTextBox";
            TelefonoTextBox.Size = new Size(100, 23);
            TelefonoTextBox.TabIndex = 2;
            // 
            // DNITextBox
            // 
            DNITextBox.Location = new Point(194, 149);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(100, 23);
            DNITextBox.TabIndex = 3;
            // 
            // NombresTextBox
            // 
            NombresTextBox.Location = new Point(194, 59);
            NombresTextBox.Name = "NombresTextBox";
            NombresTextBox.Size = new Size(100, 23);
            NombresTextBox.TabIndex = 4;
            // 
            // CorreoTextBox
            // 
            CorreoTextBox.Location = new Point(194, 191);
            CorreoTextBox.Name = "CorreoTextBox";
            CorreoTextBox.Size = new Size(100, 23);
            CorreoTextBox.TabIndex = 5;
            // 
            // DireccionTextBox
            // 
            DireccionTextBox.Location = new Point(194, 261);
            DireccionTextBox.Name = "DireccionTextBox";
            DireccionTextBox.Size = new Size(100, 23);
            DireccionTextBox.TabIndex = 6;
            // 
            // NombresLabel
            // 
            NombresLabel.AutoSize = true;
            NombresLabel.Location = new Point(104, 62);
            NombresLabel.Name = "NombresLabel";
            NombresLabel.Size = new Size(56, 15);
            NombresLabel.TabIndex = 7;
            NombresLabel.Text = "Nombres";
            // 
            // ApellidosLabel
            // 
            ApellidosLabel.AutoSize = true;
            ApellidosLabel.Location = new Point(99, 100);
            ApellidosLabel.Name = "ApellidosLabel";
            ApellidosLabel.Size = new Size(56, 15);
            ApellidosLabel.TabIndex = 8;
            ApellidosLabel.Text = "Apellidos";
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Location = new Point(103, 152);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(27, 15);
            DNILabel.TabIndex = 9;
            DNILabel.Text = "DNI";
            // 
            // CorreoLabel
            // 
            CorreoLabel.AutoSize = true;
            CorreoLabel.Location = new Point(103, 194);
            CorreoLabel.Name = "CorreoLabel";
            CorreoLabel.Size = new Size(43, 15);
            CorreoLabel.TabIndex = 10;
            CorreoLabel.Text = "Correo";
            // 
            // TelefonoLabel
            // 
            TelefonoLabel.AutoSize = true;
            TelefonoLabel.Location = new Point(103, 235);
            TelefonoLabel.Name = "TelefonoLabel";
            TelefonoLabel.Size = new Size(52, 15);
            TelefonoLabel.TabIndex = 11;
            TelefonoLabel.Text = "Telefono";
            // 
            // DireccionLabel
            // 
            DireccionLabel.AutoSize = true;
            DireccionLabel.Location = new Point(103, 269);
            DireccionLabel.Name = "DireccionLabel";
            DireccionLabel.Size = new Size(57, 15);
            DireccionLabel.TabIndex = 12;
            DireccionLabel.Text = "Direccion";
            // 
            // frmPropietario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DireccionLabel);
            Controls.Add(TelefonoLabel);
            Controls.Add(CorreoLabel);
            Controls.Add(DNILabel);
            Controls.Add(ApellidosLabel);
            Controls.Add(NombresLabel);
            Controls.Add(DireccionTextBox);
            Controls.Add(CorreoTextBox);
            Controls.Add(NombresTextBox);
            Controls.Add(DNITextBox);
            Controls.Add(TelefonoTextBox);
            Controls.Add(ApellidosTextBox);
            Controls.Add(GuardarPropietario);
            Name = "frmPropietario";
            Text = "frmPropietario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GuardarPropietario;
        private TextBox ApellidosTextBox;
        private TextBox TelefonoTextBox;
        private TextBox DNITextBox;
        private TextBox NombresTextBox;
        private TextBox CorreoTextBox;
        private TextBox DireccionTextBox;
        private Label NombresLabel;
        private Label ApellidosLabel;
        private Label DNILabel;
        private Label CorreoLabel;
        private Label TelefonoLabel;
        private Label DireccionLabel;
    }
}