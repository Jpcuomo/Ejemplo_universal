using System;
using System.Text;

namespace ClassLibrary1
{
    public class Estudiante
    {
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static Random _random;

        /// <summary>
        /// Metodo estatico para inicializar al atributo random
        /// </summary>
        static Estudiante()
        {
            // Se inicializa el atributo random con una instancia de Random
            _random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _legajo = legajo;
        }

        /// <summary>
        /// Metodo para modificar atributo privado notaPrimerParcial
        /// </summary>
        public int SetNotaPrimerParcial
        {
            set {_notaPrimerParcial = value;}
        }

        /// <summary>
        /// Metodo para modificar atributo privado notaSegundoParcial
        /// </summary>
        public int SetNotaSegundoParcial
        {
            set {_notaSegundoParcial = value;}
        }

        /// <summary>
        /// Calcula y retorna el promedio de ambos parciales
        /// </summary>
        /// <returns>Valor promedio de notas (double)</returns>
        private double _CalcularPromedio()
        {
            return ((double)_notaPrimerParcial + _notaSegundoParcial) / 2;
        }

        /// <summary>
        /// Calcula y devuelve la nota final
        /// </summary>
        /// <returns>Nota final (int)</returns>
        public int CalcularNotaFinal()
        {
            if (_notaPrimerParcial >= 4 && _notaSegundoParcial >= 4)
            {
                return _random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Muestra los datos del alumno
        /// </summary>
        /// <returns>Cadena formateada</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder(100); // Limito la cadena a 100 caracteres
            
            sb.AppendLine("Datos del alumno:");
            sb.AppendLine($"Nombre y apellido: {_nombre.ToUpper()} {_apellido.ToUpper()}");
            sb.AppendLine($"Legajo {_legajo}");
            sb.AppendLine($"Nota 1er parcial: {_notaPrimerParcial}");
            sb.AppendLine($"Nota 2do parcial: {_notaSegundoParcial}");
            sb.AppendLine($"Promedio de notas: {_CalcularPromedio():F2}");
            int notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado.");
            }
            return sb.ToString();
        }
    }
}