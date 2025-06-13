using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promedio
{
    public partial class frmCuadroNotas : Form
    {
        public frmCuadroNotas()
        {
            InitializeComponent();
        }

        private void btnAgregarPromedio_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, promedio;
            if (String.IsNullOrEmpty(txtNotaUno.Text) ||
                    String.IsNullOrEmpty(txtNotaDos.Text) ||
                    String.IsNullOrEmpty(txtNotaTres.Text)) 
            {
                lblError.Text = "Existe un campo vacio \n porfavor ingresa el dato que falta";
            }
            else
            {
                nota1 = double.Parse(txtNotaUno.Text);
                nota2 = double.Parse(txtNotaDos.Text);
                nota3 = double.Parse(txtNotaTres.Text);

                if ((nota1 > 10 || nota1 < 0) || (nota2 > 10 || nota2 < 0) || (nota3 > 10 || nota3 < 0))
                {
                    lblError.Text = "Porfavor ingresa un valor entre 0 y 10";
                }
                else
                {
                    promedio = (nota1 + nota2 + nota3) / 3;
                    txtPromedioFinal.Text = promedio.ToString("N2");
                    lblError.Text = string.Empty;
                }
                
            }
            txtNotaUno.ReadOnly = true;
            txtNotaDos.ReadOnly = true;
            txtNotaTres.ReadOnly = true;


            //double nota1, nota2, nota3, promedio;
            //nota1 = double.Parse(txtNotaUno.Text);
            //nota2 = double.Parse(txtNotaDos.Text);
            //nota3 = double.Parse(txtNotaTres.Text);
            //if (nota1 >0 && nota1 <=10 && nota2 > 0 && nota2 <= 10 && nota3 > 0 && nota3 <= 10)
            //{
            //    promedio = (nota1+ nota2 + nota3) / 3;
            //    txtPromedioFinal.Text = promedio.ToString(); 
            //}
            //else
            //{
            //    txtPromedioFinal.Text = "Verifica que hayas ingresado notas entre 1 a 10";
            //}
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            txtNotaUno.Clear();
            txtNotaDos.Clear();
            txtNotaTres.Clear();
            txtPromedioFinal.Clear();
            txtNotaUno.ReadOnly = false;
            txtNotaDos.ReadOnly = false;
            txtNotaTres.ReadOnly = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
