using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTuring
{
    class MaquinaTuring
    {
        private string[] unidadControl;
        private string[] alfabetoEntrada;
        private string[] alfabetoCinta;
        private Dictionary<string, string> Transiciones;
        private string estadoInicial;
        private string simboloBlanco;
        private string[] estadoAceptación;
        private string estadoActual;
        //Constructor - Fija los valores de los atributos excepto el diccionario, este debe llenarse manualmente.
        public MaquinaTuring(string[] estados, string[] simboloEntrada, string[] simboloCinta, string FijarEstadoInicial, string FijarBlanco, string[] estadosFinales) {
            this.unidadControl = estados;
            this.alfabetoEntrada = simboloEntrada;
            this.alfabetoCinta = simboloCinta;
            Transiciones = new Dictionary<string, string>();
            this.estadoInicial = FijarEstadoInicial;
            this.simboloBlanco = FijarBlanco;
            this.estadoAceptación = estadosFinales;
            this.estadoActual = "q0";
        }
        //Operaciones del diccionario
        public void AgregarTransición(string llave, string valor) {
            this.Transiciones.Add(llave, valor);
        }
        public void ConsultaTransición(string llave) {
            this.Transiciones.ContainsKey(llave);
        }
        public void ObtenerTransición(string llave, ref string variable) {
            this.Transiciones.TryGetValue(llave, out variable);
        }
        public int Dirección(string a) {
            switch (a) {
                case "D":{ return 1;}
                default:{ return -1;}
            }
        }
        //Llenar la tabla
        public void LlenarTabla(System.Windows.Forms.DataGridView Grid) {
            string texto = string.Empty;
            //Eliminar la tabla anterior
            Grid.Rows.Clear();
            Grid.Columns.Clear();
            Grid.Refresh();
            //añadir todos los estados
            Grid.Columns.Add("","");
            for (int k = 0; k < unidadControl.Length; k++)
            {
                Grid.Rows.Add(unidadControl[k]);
                if (estadoAceptación.Contains(unidadControl[k])) {
                    Grid.Rows[k].Cells[0].Style.BackColor = Color.LightGreen;
                }
            }
            //por cada simbolo de cinta, agrego su traslación.
            for (int i = 0; i < alfabetoCinta.Length; i++)
            {
                Grid.Columns.Add(i.ToString(), alfabetoCinta[i]);
                for (int j = 0; j < unidadControl.Length; j++)
                {
                    ObtenerTransición(unidadControl[j]+","+alfabetoCinta[i], ref texto);
                    Grid[i + 1, j].Value = texto;
                }
            }
            Grid.ReadOnly = true;
        }
        //Realizar la transición de la maquina de turing
        public bool Avanzar(string caracter,ref string[] argumentos, System.Windows.Forms.DataGridView tabla) {
            string auxiliar = "";
            ObtenerTransición(estadoActual + "," + caracter, ref auxiliar);
            if (auxiliar != null){
                string[] datos = auxiliar.Split(',');
                PintarTabla(estadoActual, caracter, tabla);
                estadoActual = datos[0];
                argumentos = datos;
                return true;
            }
            else {
                return false;
            }
        }
        //Comprobar si se terminó en un estado de aceptación
        public bool EsAceptación() {
            return this.estadoAceptación.Contains(estadoActual);
        }
        public string MirarEstado() { return this.estadoActual; }
        public bool VerificarEntrada(string entrada) {
            for (int z = 0; z < entrada.Length; z++) {
                if (!alfabetoEntrada.Contains(entrada[z].ToString())) {
                    return false;
                }
            }
            return true;
        }
        private void PintarTabla(string pivoteFila, string pivoteCol, System.Windows.Forms.DataGridView tabla) {
            int fila = 0;
            //pinto todos de blanco
            for (int k = 1; k < tabla.ColumnCount; k++)
            {
                for (int j = 0; j < tabla.RowCount - 1; j++)
                {
                    tabla[k, j].Style.BackColor = Color.White;
                }
            }
            //encuentro la fila de la nueva transición
            for (int j = 0; j < tabla.RowCount - 1; j++)
            {
                if (tabla[0, j].Value.ToString() == pivoteFila)
                {
                    fila = j;
                }
            }
            //pinto la casilla de la transición
            for (int k = 1; k < tabla.ColumnCount; k++)
            {
                try
                {
                    if (tabla.Columns[k].HeaderText == pivoteCol)
                    {
                        tabla[k, fila].Style.BackColor = Color.LightBlue;
                    }
                }
                catch { }
            }
        }
        public void ReiniciarEstado() { this.estadoActual = "q0"; }
    }
}
