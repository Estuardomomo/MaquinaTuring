using System;
using System.Collections.Generic;
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
        private string rutaDiagrama;
        private string estadoActual;
        //Constructor - Fija los valores de los atributos excepto el diccionario, este debe llenarse manualmente.
        public MaquinaTuring(string[] estados, string[] simboloEntrada, string[] simboloCinta, string FijarEstadoInicial, string FijarBlanco, string[] estadosFinales, string Diagrama) {
            this.unidadControl = estados;
            this.alfabetoEntrada = simboloEntrada;
            this.alfabetoCinta = simboloCinta;
            Transiciones = new Dictionary<string, string>();
            this.estadoInicial = FijarEstadoInicial;
            this.simboloBlanco = FijarBlanco;
            this.estadoAceptación = estadosFinales;
            this.rutaDiagrama = Diagrama;
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

        }
        //Mover cabezal
        public void Avanzar(string caracter) {

        }
    }
}
