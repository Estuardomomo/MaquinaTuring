using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaTuring
{
    public partial class Form1 : Form
    {
        string entrada;
        int cabezal = 0;
        MaquinaTuring Palíndromo = new MaquinaTuring(new string[] {"q0", "q1", "q2", "q3", "q4", "q5", "q6", "q7"}, new string[] {"a","b","c"}, new string[] {"a","b","c","X"},"q0","X",new string[] {"q0","q4","q5","q6"},"Diagrama");
        MaquinaTuring CopiaPatrón = new MaquinaTuring(new string[] { "q0", "q1", "q2", "q3", "q4", "q5", "q6", "q7", "q8","q9","q10","q11","q12", "q13", "q14", "q15", "q16", "q17"}, new string[] { "a", "b", "c"}, new string[] { "a", "b", "c", "X" }, "q0", "X",new string[] {"q13"},"Diagrama");
        MaquinaTuring SumaUnaria = new MaquinaTuring(new string[] {"q0", "q1", "q2", "q3"}, new string[] {"1","+"}, new string[] {"1","+","X","="}, "q0","X",new string[] {"q3"},"Diagrama");
        MaquinaTuring MultiplicaciónUnaria = new MaquinaTuring(new string[] {"q0", "q1", "q2", "q3", "q4", "q5", "q6", "q7", "q8", "q9", "q10"}, new string[] {"1","*"}, new string[] {"1","*","=","X"},"q0","X",new string[] {"q10"},"Diagrama");
        public Form1()
        {
            InitializeComponent();
            //Se introducen las transiciones del palíndromo
            Palíndromo.AgregarTransición("q0,a", "q1,X,D");
            Palíndromo.AgregarTransición("q0,b", "q2,X,D");
            Palíndromo.AgregarTransición("q0,c", "q3,X,D");
            Palíndromo.AgregarTransición("q1,a", "q1,a,D");
            Palíndromo.AgregarTransición("q1,b", "q1,b,D");
            Palíndromo.AgregarTransición("q1,c", "q1,c,D");
            Palíndromo.AgregarTransición("q1,X", "q4,X,I");
            Palíndromo.AgregarTransición("q2,a", "q2,a,D");
            Palíndromo.AgregarTransición("q2,b", "q2,b,D");
            Palíndromo.AgregarTransición("q2,c", "q2,c,D");
            Palíndromo.AgregarTransición("q2,X", "q5,X,I");
            Palíndromo.AgregarTransición("q3,a", "q3,a,D");
            Palíndromo.AgregarTransición("q3,b", "q3,b,D");
            Palíndromo.AgregarTransición("q3,c", "q3,c,D");
            Palíndromo.AgregarTransición("q3,X", "q6,X,I");
            Palíndromo.AgregarTransición("q4,a", "q7,X,I");
            Palíndromo.AgregarTransición("q5,b", "q7,X,I");
            Palíndromo.AgregarTransición("q6,c", "q7,X,I");
            Palíndromo.AgregarTransición("q7,a", "q7,a,I");
            Palíndromo.AgregarTransición("q7,b", "q7,b,I");
            Palíndromo.AgregarTransición("q7,c", "q7,c,I");
            Palíndromo.AgregarTransición("q7,X", "q0,X,D");
            //Se introducen las transiciones para la copia del patrón
            //Se introducen las transiciones de la suma
            //Se introducen las transiciones de la multiplicación
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (tbEntrada.Text != "")
            {
                entrada = tbEntrada.Text+"XXX";
                if (rdoPalíndromo.Checked)
                {
                    for (int i = 0; i < entrada.Length; i++) {
                        dgvCinta.Columns.Add(i.ToString(), i.ToString());
                        dgvCinta[i, 0].Value = entrada[i];
                    }
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.Cyan;
                }
                else if (rdoPatrón.Checked)
                {
                }
                else if (rdoSuma.Checked)
                {
                }
                else if (rdoResta.Checked)
                {
                }
                else if (rdoMultiplicación.Checked)
                {
                }
            }
            else { MessageBox.Show("Ocurrió un error al ingresar la cadena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
