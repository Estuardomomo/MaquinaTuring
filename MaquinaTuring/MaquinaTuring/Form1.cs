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
        int contador = 0;
        MaquinaTuring Palíndromo = new MaquinaTuring(new string[] {"q0", "q1", "q2", "q3", "q4", "q5", "q6", "q7"}, new string[] {"a","b","c"}, new string[] {"a","b","c","X"},"q0","X",new string[] {"q0","q4","q5","q6"},"Diagrama");
        MaquinaTuring CopiaPatrón = new MaquinaTuring(new string[] { "q0", "q1", "q2", "q3", "q4", "q5", "q6", "q7", "q8","q9","q10","q11","q12", "q13", "q14", "q15", "q16", "q17"}, new string[] { "a", "b", "c"}, new string[] { "a", "b", "c", "X" }, "q0", "X",new string[] {"q13"},"Diagrama");
        MaquinaTuring SumaUnaria = new MaquinaTuring(new string[] {"q0", "q1", "q2", "q3"}, new string[] {"1","+"}, new string[] {"1","+","X","="}, "q0","X",new string[] {"q3"},"Diagrama");
        MaquinaTuring RestaUnaria = new MaquinaTuring(new string[] {"q0","q1","q2","q3","q4"}, new string[] {"1","-"}, new string[] {"1","-","X"},"q0","X", new string[] {"q0", "q4"},"Diagrama");
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
            CopiaPatrón.AgregarTransición("q0,a", "q1,X,D");
            CopiaPatrón.AgregarTransición("q0,b", "q2,X,D");
            CopiaPatrón.AgregarTransición("q0,c", "q3,X,D");
            CopiaPatrón.AgregarTransición("q0,X", "q13,X,D");
            CopiaPatrón.AgregarTransición("q1,a", "q1,a,D");
            CopiaPatrón.AgregarTransición("q1,b", "q1,b,D");
            CopiaPatrón.AgregarTransición("q1,c", "q1,c,D");
            CopiaPatrón.AgregarTransición("q1,X", "q4,X,D");
            CopiaPatrón.AgregarTransición("q2,a", "q2,a,D");
            CopiaPatrón.AgregarTransición("q2,b", "q2,b,D");
            CopiaPatrón.AgregarTransición("q2,c", "q2,c,D");
            CopiaPatrón.AgregarTransición("q2,X", "q5,X,D");
            CopiaPatrón.AgregarTransición("q3,a", "q3,a,D");
            CopiaPatrón.AgregarTransición("q3,b", "q3,b,D");
            CopiaPatrón.AgregarTransición("q3,c", "q3,c,D");
            CopiaPatrón.AgregarTransición("q3,X", "q6,X,D");
            CopiaPatrón.AgregarTransición("q4,a", "q4,a,D");
            CopiaPatrón.AgregarTransición("q4,b", "q4,b,D");
            CopiaPatrón.AgregarTransición("q4,c", "q4,c,D");
            CopiaPatrón.AgregarTransición("q4,X", "q7,a,I");
            CopiaPatrón.AgregarTransición("q5,a", "q5,a,D");
            CopiaPatrón.AgregarTransición("q5,b", "q5,b,D");
            CopiaPatrón.AgregarTransición("q5,c", "q5,c,D");
            CopiaPatrón.AgregarTransición("q5,X", "q8,b,I");
            CopiaPatrón.AgregarTransición("q6,a", "q6,a,D");
            CopiaPatrón.AgregarTransición("q6,b", "q6,b,D");
            CopiaPatrón.AgregarTransición("q6,c", "q6,c,D");
            CopiaPatrón.AgregarTransición("q6,X", "q9,c,I");
            CopiaPatrón.AgregarTransición("q7,a", "q7,a,I");
            CopiaPatrón.AgregarTransición("q7,b", "q7,b,I");
            CopiaPatrón.AgregarTransición("q7,c", "q7,c,I");
            CopiaPatrón.AgregarTransición("q7,X", "q10,X,I");
            CopiaPatrón.AgregarTransición("q8,a", "q8,a,I");
            CopiaPatrón.AgregarTransición("q8,b", "q8,b,I");
            CopiaPatrón.AgregarTransición("q8,c", "q8,c,I");
            CopiaPatrón.AgregarTransición("q8,X", "q11,X,I");
            CopiaPatrón.AgregarTransición("q9,a", "q9,a,I");
            CopiaPatrón.AgregarTransición("q9,b", "q9,b,I");
            CopiaPatrón.AgregarTransición("q9,c", "q9,c,I");
            CopiaPatrón.AgregarTransición("q9,X", "q12,X,I");
            CopiaPatrón.AgregarTransición("q10,a", "q10,a,I");
            CopiaPatrón.AgregarTransición("q10,b", "q10,b,I");
            CopiaPatrón.AgregarTransición("q10,c", "q10,c,I");
            CopiaPatrón.AgregarTransición("q10,X", "q0,a,D");
            CopiaPatrón.AgregarTransición("q11,a", "q11,a,I");
            CopiaPatrón.AgregarTransición("q11,b", "q11,b,I");
            CopiaPatrón.AgregarTransición("q11,c", "q11,c,I");
            CopiaPatrón.AgregarTransición("q11,X", "q0,b,D");
            CopiaPatrón.AgregarTransición("q12,a", "q12,a,I");
            CopiaPatrón.AgregarTransición("q12,b", "q12,b,I");
            CopiaPatrón.AgregarTransición("q12,c", "q12,c,I");
            CopiaPatrón.AgregarTransición("q12,X", "q0,c,D");
            CopiaPatrón.AgregarTransición("q13,a", "q14,X,I");
            CopiaPatrón.AgregarTransición("q13,b", "q15,X,I");
            CopiaPatrón.AgregarTransición("q13,c", "q16,X,I");
            CopiaPatrón.AgregarTransición("q14,X", "q17,a,D");
            CopiaPatrón.AgregarTransición("q15,X", "q17,b,D");
            CopiaPatrón.AgregarTransición("q16,X", "q17,c,D");
            CopiaPatrón.AgregarTransición("q17,X", "q13,X,D");
            //Se introducen las transiciones de la suma
            SumaUnaria.AgregarTransición("q0,1","q0,1,D");
            SumaUnaria.AgregarTransición("q0,+","q1,1,D");
            SumaUnaria.AgregarTransición("q1,1","q1,1,D");
            SumaUnaria.AgregarTransición("q1,X","q2,X,I");
            SumaUnaria.AgregarTransición("q2,1","q3,X,D");
            //Se introducen las transiciones de la resta
            RestaUnaria.AgregarTransición("q0,1", "q1,X,D");
            RestaUnaria.AgregarTransición("q1,1", "q1,1,D");
            RestaUnaria.AgregarTransición("q1,-", "q1,-,D");
            RestaUnaria.AgregarTransición("q1,X", "q2,X,I");
            RestaUnaria.AgregarTransición("q2,1", "q3,X,I");
            RestaUnaria.AgregarTransición("q2,-", "q4,1,I");
            RestaUnaria.AgregarTransición("q3,1", "q3,1,I");
            RestaUnaria.AgregarTransición("q3,-", "q3,-,I");
            RestaUnaria.AgregarTransición("q3,X", "q0,X,D");
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
                entrada = "";
                if (rdoPalíndromo.Checked && Palíndromo.VerificarEntrada(tbEntrada.Text))
                {
                    entrada = tbEntrada.Text + "XXX";
                    Palíndromo.LlenarTabla(dgvTabla);
                    Palíndromo.ReiniciarEstado();
                    btnAvanzar.Enabled = true;
                    btnAnimación.Enabled = true;
                    btnDiagrama.Enabled = true;
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
                    CopiaPatrón.ReiniciarEstado();
                    btnAvanzar.Enabled = true;
                    btnAnimación.Enabled = true;
                    btnDiagrama.Enabled = true;
                }
                else if (rdoSuma.Checked && SumaUnaria.VerificarEntrada(tbEntrada.Text))
                {
                    entrada = tbEntrada.Text + "XXX";
                    SumaUnaria.LlenarTabla(dgvTabla);
                    SumaUnaria.ReiniciarEstado();
                    btnAvanzar.Enabled = true;
                    btnAnimación.Enabled = true;
                    btnDiagrama.Enabled = true;
                }
                else if (rdoResta.Checked)
                {
                    entrada = tbEntrada.Text + "XXX";
                    RestaUnaria.LlenarTabla(dgvTabla);
                    RestaUnaria.ReiniciarEstado();
                    btnAvanzar.Enabled = true;
                    btnAnimación.Enabled = true;
                    btnDiagrama.Enabled = true;
                }
                else if (rdoMultiplicación.Checked && MultiplicaciónUnaria.VerificarEntrada(tbEntrada.Text))
                {
                    entrada = tbEntrada.Text + "=XX";
                    int auxiliar = entrada.Length;
                    for (int i = 0; i < auxiliar; i++)
                    {
                        entrada += "XXXXXXXXXXXX";
                    }
                    MultiplicaciónUnaria.LlenarTabla(dgvTabla);
                    MultiplicaciónUnaria.ReiniciarEstado();
                    btnAvanzar.Enabled = true;
                    btnAnimación.Enabled = true;
                    btnDiagrama.Enabled = true;
                }
                if (entrada != "") {
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
                    contador = 0;
                    lbResultado.Text = "Estado: q0";
                }
            }
            else { MessageBox.Show("Ocurrió un error al ingresar la cadena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (rdoPalíndromo.Checked) {
                if (Palíndromo.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: "+ Palíndromo.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + Palíndromo.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else {
                    //revisar si es un estado terminal
                    if (Palíndromo.EsAceptación()){
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString();
                    }
                    else {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                    }
                }
            }
            else if (rdoPatrón.Checked)
            {
                if (CopiaPatrón.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + CopiaPatrón.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + CopiaPatrón.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (CopiaPatrón.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString() ;
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                    }
                }
            }
            else if (rdoSuma.Checked)
            {
                if (SumaUnaria.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + SumaUnaria.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + SumaUnaria.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (SumaUnaria.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString();
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                    }
                }
            }
            else if (rdoResta.Checked)
            {
                if (RestaUnaria.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + RestaUnaria.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + RestaUnaria.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (RestaUnaria.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString();
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                    }
                }
            }
            else if (rdoMultiplicación.Checked)
            {
                if (MultiplicaciónUnaria.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + MultiplicaciónUnaria.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + MultiplicaciónUnaria.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (MultiplicaciónUnaria.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString();
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rdoPalíndromo.Checked)
            {
                if (Palíndromo.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + Palíndromo.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + Palíndromo.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (Palíndromo.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                }
            }
            else if (rdoPatrón.Checked)
            {
                if (CopiaPatrón.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + CopiaPatrón.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + CopiaPatrón.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (CopiaPatrón.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                }
            }
            else if (rdoSuma.Checked)
            {
                if (SumaUnaria.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + SumaUnaria.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + SumaUnaria.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (SumaUnaria.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                }
            }
            else if (rdoResta.Checked)
            {
                if (RestaUnaria.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + RestaUnaria.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + RestaUnaria.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (RestaUnaria.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                }
            }
            else if (rdoMultiplicación.Checked)
            {
                if (MultiplicaciónUnaria.Avanzar(dgvCinta[cabezal, 0].Value.ToString(), ref argumentos, dgvTabla))//Aún existen más movimientos
                {
                    lbResultado.Text = "Estado: " + MultiplicaciónUnaria.MirarEstado() + " Contador: " + contador.ToString();
                    dgvCinta[cabezal, 0].Value = argumentos[1];
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                    cabezal = cabezal + MultiplicaciónUnaria.Dirección(argumentos[2]);
                    dgvCinta.Rows[0].Cells[cabezal].Style.BackColor = Color.LightBlue;
                    contador++;
                }
                else
                {
                    //revisar si es un estado terminal
                    if (MultiplicaciónUnaria.EsAceptación())
                    {
                        lbResultado.Text = "Resultado: La cadena es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                    else
                    {
                        lbResultado.Text = "Resultado: La cadena no es aceptada   Contador: " + contador.ToString();
                        timer1.Enabled = false;
                    }
                }
            }
            
        }

        private void btnAnimación_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
