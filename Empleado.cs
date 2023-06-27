namespace EspacioEmpleado
{

    public enum cargos
    {

        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    class Empleado
    {

        private string? nombre;

        private string? apellido;

        private DateTime nacimiento;

        private char estadoCivil;

        private char genero;

        private DateTime ingreso;

        private double sueldo;

        private cargos cargo;


        //Encapsulamiento

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime Ingreso { get => ingreso; set => ingreso = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public cargos Cargo { get => cargo; set => cargo = value; }

        public Empleado(string? nombre, string? apellido, DateTime nacimiento, char estadoCivil, char genero, DateTime ingreso, double sueldo, cargos cargo)
        {

            this.nombre = nombre;

            this.apellido = apellido;

            this.nacimiento = nacimiento;

            this.estadoCivil = estadoCivil;

            this.genero = genero;

            this.ingreso = ingreso;

            this.ingreso = ingreso;

            this.sueldo = sueldo;

            this.cargo = cargo;

        }


        public int antiguedad()
        {

            DateTime fechaHoy = DateTime.Now;

            int anioActual = fechaHoy.Year;

            return (anioActual - ingreso.Year);

        }

        public int edad()
        {

            DateTime fechaHoy = DateTime.Now;

            int anioActual = fechaHoy.Year;

            return (anioActual - nacimiento.Year);

        }

        public int jubilacion(char genero)
        {

            int edad;

            DateTime fechaHoy = DateTime.Now;

            int anioActual = fechaHoy.Year;

            edad = (anioActual - nacimiento.Year);

            if (genero == 'm')
            {

                return 65 - edad;


            }
            else
            {

                return 60 - edad;

            }


        }

        public void calcularSueldo(Empleado empleado)
        {
            double plus1, plus2, plus3;

            if (empleado.antiguedad() > 20)
            {

                plus1 = 1.25;


            }
            else
            {

                plus1 = 1 + (empleado.antiguedad() / 100);

            }


            if (empleado.cargo == cargos.Ingeniero || empleado.cargo == cargos.Especialista)
            {

                plus2 = 1.50;

            }
            else
            {

                plus2 = 1;
            }

            if (empleado.estadoCivil == 'c')
            {

                plus3 = 15000;

            }
            else
            {

                plus3 = 0;

            }

            empleado.sueldo = empleado.sueldo * plus1 * plus2 + plus3;

        }


    }



}