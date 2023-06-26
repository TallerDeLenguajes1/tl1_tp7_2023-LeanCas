namespace EspacioCalculadora
{

    class Calculadora
    {

        private double dato;

        private double resultado;

        public double Dato { get => dato; set => dato = value; }
        public double Resultado { get => dato; }

        //Contructura

        public Calculadora()
        {

            dato = 0;

        }


        //FUNCIONES

        public void Sumar(double termino)
        {

            dato += termino;

        }

        public void Restar(double termino)
        {

            dato -= termino;

        }



        public void Multiplicar(double termino)
        {

            dato *= termino;

        }


        public void Dividir(double termino)
        {

            dato /= termino;

        }


        public void Limpiar()
        {

            dato = 0;

        }



    }




}