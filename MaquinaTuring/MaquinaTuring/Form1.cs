using System;
using System.Drawing;
using System.Windows.Forms;

namespace MaquinaTuring
{
    public partial class Form1 : Form
    {
        string entrada;
        int cabezal = 0;
        string[] argumentos;
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
            SumaUnaria.AgregarTransición("q0,1","q0,1,D");
            SumaUnaria.AgregarTransición("q0,+","q1,1,D");
            SumaUnaria.AgregarTransición("q1,1","q1,1,D");
            SumaUnaria.AgregarTransición("q1,X","q2,X,I");
            SumaUnaria.AgregarTransición("q2,1","q3,X,D");
            //Se introducen las transiciones de la multiplicación
            MultiplicaciónUnaria.AgregarTransición("q0,1","q1,1,D");
            MultiplicaciónUnaria.AgregarTransición("q1,1","q2,1,I");
            MultiplicaciónUnaria.AgregarTransición("q1,*","q2,*,I");
            MultiplicaciónUnaria.AgregarTransición("q2,1","q3,X,D");
            MultiplicaciónUnaria.AgregarTransición("q2,*","q10,*,D");
            MultiplicaciónUnaria.AgregarTransición("q3,1","q3,1,D");
            MultiplicaciónUnaria.AgregarTransición("q3,*","q4,*,D");
            MultiplicaciónUnaria.AgregarTransición("q4,1","q5,X,D");
            MultiplicaciónUnaria.AgregarTransición("q4,=","q8,=,I");
            MultiplicaciónUnaria.AgregarTransición("q5,1","q5,1,D");
            MultiplicaciónUnaria.AgregarTransición("q5,=","q6,=,D");
            MultiplicaciónUnaria.AgregarTransición("q6,1", "q6,1,D");
            MultiplicaciónUnaria.AgregarTransición("q6,X", "q7,1,I");
            MultiplicaciónUnaria.AgregarTransición("q7,1", "q7,1,I");
            MultiplicaciónUnaria.AgregarTransición("q7,=", "q7,=,I");
            MultiplicaciónUnaria.AgregarTransición("q7,X", "q4,1,D");
            MultiplicaciónUnaria.AgregarTransición("q8,1", "q9,1,I");
            MultiplicaciónUnaria.AgregarTransición("q9,1", "q9,1,I");
            MultiplicaciónUnaria.AgregarTransición("q9,*", "q9,*,I");
            MultiplicaciónUnaria.AgregarTransición("q9,X", "q2,1,D");
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (tbEntrada.Text != "")
            {
                if (rdoPalíndromo.Checked && Palíndromo.VerificarEntrada(tbEntrada.Text))
                {
                    entrada = tbEntrada.Text + "XXX";
                    Palíndromo.LlenarTabla(dgvTabla);
                }
                else if (rdoPatrón.Checked && CopiaPatrón.VerificarEntrada(tbEntrada.Text))
                {
                    entrada = tbEntrada.Text + "XX";
                    int auxiliar = entrada.Length;
                    for (int i = 0; i < auxiliar; i++)
                    {
                        entrada += "X";
                    }
                    CopiaPatrón.LlenarTabla(dgvTabla);
                }
                else if (rdoSuma.Checked && SumaUnaria.VerificarEntrada(tbEntrada.Text))
                {
                    entrada = tbEntrada.Text + "XXX";
                    SumaUnaria.LlenarTabla(dgvTabla);
                }
                else if (rdoResta.Checked)
                {
                }
                else if (rdoMultiplicación.Checked && MultiplicaciónUnaria.VerificarEntrada(tbEntrada.Text))
                {
                    entrada = tbEntrada.Text + "=XX";
                    int auxiliar = entrada.Length;
                    for (int i = 0; i < auxiliar; i++)
                    {
                        entrada += "XXXXXXXX";
                    }
                    MultiplicaciónUnaria.LlenarTabla(dgvTabla);
                }
                cabezal = 0;
                //Cinta
                dgvCinta.Rows.Clear();
                dgvCinta.Columns.Clear();
                dgvCinta.Refresh();
                for (int i = 0; i < entrada.Length; i++)
                {
                    dgvCinta.Columns.Add(i.ToString(), i.ToString());
                    dgvCinta[i, 0].Value = entrada[i];
                }
                dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                dgvCinta.ReadOnly = true;
                lbResultado.Text = "Estado: q0";
            }
            else { MessageBox.Show("Ocurrió un error al ingresar la cadena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (rdoPalíndromo.Checked) {
                if (Palíndromo.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: "+ Palíndromo.MirarEstado();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + Palíndromo.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                }
                else {
                    //revisar si es un estado terminal
                    if (Palíndromo.EsAceptación()){
                        lbResultado.Text = "Resultado: La cadena es aceptada";
                    }
                    else {
                        lbResultado.Text = "Resultado: La cadena no es aceptada";
                    }
                }
            }
            else if (rdoPatrón.Checked)
            {
            }
            else if (rdoSuma.Checked)
            {
                if (SumaUnaria.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + SumaUnaria.MirarEstado();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + SumaUnaria.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (SumaUnaria.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada";
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada";
                    }
                }
            }
            else if (rdoResta.Checked)
            {
            }
            else if (rdoMultiplicación.Checked)
            {
                if (MultiplicaciónUnaria.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + MultiplicaciónUnaria.MirarEstado();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + MultiplicaciónUnaria.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (MultiplicaciónUnaria.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada";
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada";
                    }
                }
            }
        }
    }
}
