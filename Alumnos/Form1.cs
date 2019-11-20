using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{ // Las excepciones contienen
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            Dato data = new Dato();
            if (TxtMatricula.Text == " ")
            {
                Ep.SetError(TxtMatricula, "Matricula no ha sido ingresada");
            }
            else if (TxtNombre.Text == " ")
            {
                Ep.SetError(TxtNombre, "Nombre sin ingresar");
            }
            else if (TxtSemestre.Text == " ")
            {
                Ep.SetError(TxtSemestre, "Escribe un semestre");
            }
            else if (TxtCarrera.Text == " ")
            {
                Ep.SetError(TxtCarrera, "Coloca una carrera");
            }
            else if (TxtTelefono.Text == " ")
            {
                Ep.SetError(TxtTelefono, "Teclea un numero de telefono");
            }
            try
            {
                data.Matricula = Convert.ToInt32(TxtMatricula.Text);
                MessageBox.Show(Convert.ToString(data.Matricula));
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Favor de ingresar exclusivamente numeros");
               
            }
            try
            {
                throw new Excepcion_Especial("ha sido creado de modo correcto");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error al registrar al alumno"+ ex.Message);
            }
            catch(Excepcion_Especial espEx)
            {
                MessageBox.Show(espEx.Message);
            }
            finally
            {
                Ep.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtCalificacion_Validating(object sender, CancelEventArgs e)
        {
          try
            {
                int cal = Convert.ToInt32(TxtCalificacion.Text);
                if (cal < 1 && cal > 10)
                {
                    MessageBox.Show("Selecciona un numero entre 1 y 10, por favor", "Error");
                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error en la entrada de datos", "Error",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }
        }
    }
}
