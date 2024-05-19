using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Interface;
using CapaNegocio;

namespace CapaVisual
{
    public partial class frmPropietario : Form
    {
        private NPropietario _propietarioNegocio;

        public frmPropietario(NPropietario propietarioNegocio)
        {
            InitializeComponent();
            _propietarioNegocio = propietarioNegocio;
        }

        private void GuardarPropietario_Click(object sender, EventArgs e)
        {
            try
            {
                _propietarioNegocio.GuardarPropietario(
                    DNITextBox.Text,
                    NombresTextBox.Text,
                    ApellidosTextBox.Text,
                    CorreoTextBox.Text,
                    TelefonoTextBox.Text,
                    DireccionTextBox.Text
                );

                MessageBox.Show("Propietario guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los TextBox después de guardar exitosamente
                DNITextBox.Clear();
                NombresTextBox.Clear();
                ApellidosTextBox.Clear();
                CorreoTextBox.Clear();
                TelefonoTextBox.Clear();
                DireccionTextBox.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar propietario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}