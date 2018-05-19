using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea4_Ejercicios_Albert
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Menu();
        }

        private void Menu()
        {
            string op;
            int ops;
            
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1. programa 1 capitulo 7, 2. programa 2 capitulo 7, 3. Programa 3 capitulo 7, 4. programa 4 capitulo 7" +
                "5. programa 5 capitulo 7, 6. Programa 1 capitulo 8, 7. Programa 2 capitulo, 8. Programa 3 capitulo, 9. Programa 4 capitulo 8" +
                ", 10. Programa 5 capitulo 8, 11. Programa 1 Capitulo 9, 12. Programa 2 Capitulo 9, 13. Programa 3 Capitulo 9 " +
                "14. Programa 4 Capitulo 9, 15. Programa 5 Capitulo 9 ");
            op = Console.ReadLine();
            ops = Convert.ToInt32(op);

            switch (ops)
            {
                case 1:
                    Capitulo7Programa1(); break;

                case 2:
                    Capitulo7Programa2(); break;

                case 3:
                    Capitulo7Programa3(); break;

                case 4:
                    Capitulo7Programa4(); break;

                case 5:
                    Capitulo7Programa5(); break;

                case 6:
                    Capitulo8Programa1(); break;

                case 7:
                    Capitulo8Programa2(); break;

                case 8:
                    Capitulo8Programa3(); break;

                case 9:
                    Capitul8programa4(); break;

                case 10:
                    Capitulo8Programa5(); break;

                case 11:
                    Capitulo9Programa1(); break;

                case 12:
                    Capitulo9Programa2(); break;

                case 13:
                    Capitulo9Programa3(); break;

                case 14:
                    Capitulo9Programa4(); break;

                case 15:
                    Capitulo9Programa5(); break;

            }

        }

        private void Capitulo7Programa1()
        {
            string calificacion;
            int calificaciones;
            int promedio = 0, max = 0, min = 0;
            ArrayList clase = new ArrayList();
            Console.WriteLine("Programa que Dice el promedio, la maxima y la minima calificacion de un grupo de estudiantes");
            for (int x = 0; ; x++)
            {
                Console.WriteLine("Digite calificacion");
                calificacion = Console.ReadLine();
                calificaciones = Convert.ToInt32(calificacion);
                if (calificaciones == 0)
                    break;
                clase.Add(calificaciones);

            }

            foreach (int datos in clase)
            {

                promedio = promedio + datos;
                if (min == 0)
                    min = datos;

                if (datos > max)
                    max = datos;

                if (min > datos)
                    min = datos;

            }

            Console.WriteLine("El promedio es {0}", promedio / clase.Count);
            Console.WriteLine("la calificacion maxima es {0}", max);
            Console.WriteLine("la calificacion minima es {0}", min);


        }

        private void Capitulo7Programa2()
        {
            Console.WriteLine("Diccionario");
            Hashtable Diccionario = new Hashtable();
            string op, valor;
            int ops;
            bool existe;
            Diccionario.Add("abaceria", "Tienda de comestibles");
            Diccionario.Add("abominar", "Condenar,maldecir");
            Diccionario.Add("acecinar", "Salar cualquier tipo de carne ahumada");
            do
            {
                Console.WriteLine("Tenemos las palabras: abaceria, abominar y acecinar  ");

                Console.WriteLine("Digite la palabra que desea");
                valor = Console.ReadLine();


                foreach (DictionaryEntry datos in Diccionario)
                {


                    if (valor == (string)datos.Key)
                    {
                        Console.WriteLine("La definiciones de {0} es:  {1}", datos.Key, datos.Value);
                        break;

                    }

                }

                existe = Diccionario.Contains(valor);
                if (existe == false)
                    Console.WriteLine("La palabra no se encuentra en el diccionario");

                Console.WriteLine("Digite 0 para salir, 1 para continuar");
                op = Console.ReadLine();
                ops = Convert.ToInt32(op);

            } while (ops != 0);
        }

        public struct AtencionCliente
        {
            public String nombre;
            public String telefono;
            public String direccion;
        }

        private void Capitulo7Programa3()
        {
            string nombre, salir;
            Queue Atencion = new Queue();
            AtencionCliente cliente = new AtencionCliente();
            Queue ClienteAtencion = new Queue();


            for (int x = 0; ; x++)
            {
                Console.WriteLine("Digite su nombre");
                nombre = Console.ReadLine();
                Atencion.Enqueue(nombre);

                Console.WriteLine("Digite 'salir' para salir o 'no' para no salir");
                salir = Console.ReadLine();
                if (salir == "Salir" || salir == "salir")
                    break;
            }

            foreach (string datos in Atencion)
            {
                Console.WriteLine("El cliente es: {0}", datos);
                cliente.nombre = datos;
                Console.WriteLine("Digite  direccion");
                cliente.direccion = Console.ReadLine();
                Console.WriteLine("Digite  telefono");
                cliente.telefono = Console.ReadLine();

                ClienteAtencion.Enqueue(cliente);



            }

            foreach (AtencionCliente datos in ClienteAtencion)
            {
                Console.WriteLine("Los datos son: Nombre: {0} , Telefono: {1}, Direccion: {2}", datos.nombre, datos.telefono, datos.direccion);

            }
        }

        private void Capitulo7Programa4()
        {

            string op;
            int ops, total = 0;


            ArrayList Gastos = new ArrayList();

            for (int x = 0; ; x++)
            {
                Console.WriteLine("Digite los gastos a calcular");
                op = Console.ReadLine();
                ops = Convert.ToInt32(op);
                if (ops == 0)
                    break;
                Gastos.Add(ops);

            }

            foreach (int datos in Gastos)
            {

                total += datos;

            }
            Console.WriteLine("El total es {0}", total);
            Gastos.Sort();
            Console.WriteLine("Los gastos Fueron:");
            foreach (int datos in Gastos)
            {

                Console.WriteLine("{0}", datos);


            }
        }

        public struct Agendas
        {

            public String Nombre;
            public String telefono;
        }

        private void Capitulo7Programa5()
        {
            string salir;
            ArrayList Agenda = new ArrayList();
            Agendas h = new Agendas();


            for (int x = 0; ; x++)
            {
                Console.WriteLine("Digite el nombre");
                h.Nombre = Console.ReadLine();

                Console.WriteLine("Digite el numero de telefono");
                h.telefono = Console.ReadLine();

                Agenda.Add(h);

                Console.WriteLine("Si desea salir digite'salir' si no digite 'no'");
                salir = Console.ReadLine();
                if (salir == "salir" || salir == "Salir")
                    break;
            }


            foreach (Agendas datos in Agenda)
            {
                Console.WriteLine("Los datos son {0} {1}", datos.Nombre, datos.telefono);

            }
        }

        private void Capitulo8Programa1()
        {
            string cadena;
            Console.WriteLine("Digite una cadena");
            cadena = Console.ReadLine();

            Console.WriteLine("La cadena fue: {0}", cadena);
        }

        private void Capitulo8Programa2()
        {
            string cadena, justificar, resultado = "", espacios;
            int espacio;
            Console.WriteLine("Digite una cadena");
            cadena = Console.ReadLine();
            Console.WriteLine("Hacia donde desea justificar, 'derecha' o 'izquierda'");
            justificar = Console.ReadLine();
            Console.WriteLine("Cuantos espacios desea moverlo?");
            espacios = Console.ReadLine();
            espacio = Convert.ToInt32(espacios);

            if (justificar == "derecha")
                resultado = cadena.PadRight(espacio);
            if (justificar == "izquierda")
                resultado = cadena.PadLeft(espacio);

            Console.WriteLine("{0}", resultado);
        }

        private void Capitulo8Programa3()
        {
            String formato, formatos;
            formatos = DateTime.Now.ToString("h:mm: ss tt ");
            formato = DateTime.Now.ToString("yyyy/dd/MM");
            Console.WriteLine("La hora es: {0} ", formatos);
            Console.WriteLine("La fecha es:{0} ", formato);
        }

        private void Capitul8programa4()
        {
            string numero1, numero2;
            int num1, num2, resultado = 0;

            Console.WriteLine("Digite 0 para salir");
            for (int x = 0; ; x++)
            {
                Console.WriteLine("Digite un numero");
                numero1 = Console.ReadLine();
                num1 = Convert.ToInt32(numero1);
                if (num1 == 0)
                    break;
                Console.WriteLine("Digite un numero");
                numero2 = Console.ReadLine();
                num2 = Convert.ToInt32(numero2);
                if (num2 == 0)
                    break;



                resultado += (num1 + num2);

            }

            if (resultado < 0)
                Console.WriteLine("El resultado es ({0})", resultado);
            else
                Console.WriteLine("El resultado es {0}", resultado);
        }

        private void Capitulo8Programa5()
        {
            string cadena, caden;
            ArrayList cadenas = new ArrayList();


            Console.WriteLine("Digite cadena 1");
            cadena = Console.ReadLine();
            cadenas.Add(cadena);

            Console.WriteLine("Digite cadena 2");
            caden = Console.ReadLine();
            cadenas.Add(caden);


            cadenas.Sort();

            foreach (string datos in cadenas)
            {

                Console.WriteLine("{0}", datos);


            }

        }

        public struct Tienda
        {
            public String NombreProducto;
            public int Codigo;
            public int valor;


        }

        private void Capitulo9Programa1()
        {
            string codigos, valores, salir;
            ArrayList tienda = new ArrayList();
            Tienda a = new Tienda();
            for (int x = 0; ; x++)
            {
                Console.WriteLine("Digite nombre del articulo {0}", x);
                a.NombreProducto = Console.ReadLine();
                Console.WriteLine("Digite valor del articulo {0}", x);
                valores = Console.ReadLine();
                a.valor = Convert.ToInt32(valores);
                Console.WriteLine("Digite Codigo del articulo {0}", x);
                codigos = Console.ReadLine();
                a.Codigo = Convert.ToInt32(codigos);
                tienda.Add(a);
                Console.WriteLine("Si desea salir digite 'salir'");
                salir = Console.ReadLine();
                if (salir == "salir" || salir == "Salir")
                    break;



            }
            foreach (Tienda datos in tienda)
            {
                Console.WriteLine("Nombre: {0} valor: {1} Codigo: {2}", datos.NombreProducto, datos.valor, datos.Codigo);
            }

        }

        public struct CuentaBancaria
        {
            public String TitularDeLaCuenta;
            public int NumeroDeLaCuenta;
            public String NombreDelBanco;
            public String DireccionDelBanco;
            public String CorreoDelTitular;
            public String DireccionTitular;

        }

        private void Capitulo9Programa2()
        {
            string numero;
            CuentaBancaria banco = new CuentaBancaria();
            Console.WriteLine("Digite el nombre del titular");
            banco.TitularDeLaCuenta = Console.ReadLine();

            Console.WriteLine("Digite el numero de la cuenta ");
            numero = Console.ReadLine();
            banco.NumeroDeLaCuenta = Convert.ToInt32(numero);

            Console.WriteLine("Digite el nombre del banco");
            banco.NombreDelBanco = Console.ReadLine();

            Console.WriteLine("Digite la direccion del banco");
            banco.DireccionDelBanco = Console.ReadLine();

            Console.WriteLine("Digite el correo del titular");
            banco.CorreoDelTitular = Console.ReadLine();

            Console.WriteLine("Digite la direccion del titular");
            banco.DireccionTitular = Console.ReadLine();

            Console.WriteLine("Nombre del titular: {0}\nNumero de cuenta: {1}\nNombre del banco: {2}\nDireccion del banco: {3}\nCorreo dle titular: {4}\n" +
                "Direccion del titular: {5}", banco.TitularDeLaCuenta, banco.NumeroDeLaCuenta, banco.NombreDelBanco, banco.DireccionDelBanco, banco.CorreoDelTitular, banco.DireccionTitular);

        }

        public struct Mascota
        {
            public String nombre;
            public String TipoMascota;
            public String FechaDeNacimiento;
            public String color;

        }

        public struct Propietario
        {
            public String Nombre;
            public String Direccion;
            public String telefono;
            public Mascota mascota;
        }

        private void Capitulo9Programa3()
        {
            Propietario dueno = new Propietario();

            Console.WriteLine("Digite el nombre del propietario ");
            dueno.Nombre = Console.ReadLine();

            Console.WriteLine("Digite la direccion del propietario ");
            dueno.Direccion = Console.ReadLine();

            Console.WriteLine("Digite el telefono del propietario ");
            dueno.telefono = Console.ReadLine();

            Console.WriteLine("Digite el nombre de la mascota ");
            dueno.mascota.nombre = Console.ReadLine();

            Console.WriteLine("Digite el tipo de la mascota ");
            dueno.mascota.TipoMascota = Console.ReadLine();

            Console.WriteLine("Digite la fecha de nacimiento de la mascota ");
            dueno.mascota.FechaDeNacimiento = Console.ReadLine();

            Console.WriteLine("Digite el color de la mascota ");
            dueno.mascota.color = Console.ReadLine();


            Console.WriteLine("Nombre del propietario: {0}\nDireccion del propietario: {1}\nTelefono Del propietario: {2}\nNombre de la mascota: {3}\n" +
                "Tipo de mascota: {4}\nFecha de nacimiento de la mascota: {5}\nColor de la mascota: {6} ", dueno.Nombre, dueno.Direccion, dueno.telefono, dueno.mascota.nombre
                , dueno.mascota.TipoMascota, dueno.mascota.FechaDeNacimiento, dueno.mascota.color);


        }

        enum Neumaticos { TodoTerreno = 1, DeInvierno, DeVerano, DeAllSeason, De4x4, DePerfilAncho, DePerfilBajo };

        private void Capitulo9Programa4()
        {
            string opcion;
            int opciones;
            Neumaticos goma;
            do
            {
                Console.WriteLine("Los tipos van del 1 al 7\nDigite 0 para salir");
                Console.WriteLine("Digite el tipo a saber");
                opcion = Console.ReadLine();
                opciones = Convert.ToInt32(opcion);

                switch (opciones)
                {
                    case 1:
                        {
                            goma = Neumaticos.TodoTerreno;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 2:
                        {
                            goma = Neumaticos.DeInvierno;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 3:
                        {
                            goma = Neumaticos.DeVerano;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 4:
                        {
                            goma = Neumaticos.DeAllSeason;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 5:
                        {
                            goma = Neumaticos.De4x4;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 6:
                        {
                            goma = Neumaticos.DePerfilAncho;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 7:
                        {
                            goma = Neumaticos.DePerfilBajo;
                            Console.WriteLine("{0}", goma); break;
                        }






                }
            } while (opciones != 0);






        }

        enum Estrellas { Aries = 1, Geminis, Tauro, cancer, leo, virgo, libra, escorpion, sagitario, capricornio, acuario, piscis };

        private void Capitulo9Programa5()
        {
            string opcion;
            int opciones;
            Estrellas estrella;
            do
            {
                Console.WriteLine("Los tipos van del 1 al 12\nDigite 0 para salir");
                Console.WriteLine("Digite el tipo a saber");
                opcion = Console.ReadLine();
                opciones = Convert.ToInt32(opcion);

                switch (opciones)
                {
                    case 1:
                        {
                            estrella = Estrellas.Aries;
                            Console.WriteLine("{0}", estrella); break;
                        }

                    case 2:
                        {
                            estrella = Estrellas.Geminis;
                            Console.WriteLine("{0}", estrella); break;
                        }

                    case 3:
                        {
                            estrella = Estrellas.Tauro;
                            Console.WriteLine("{0}", estrella); break;
                        }

                    case 4:
                        {
                            estrella = Estrellas.cancer;
                            Console.WriteLine("{0}", estrella); break;
                        }

                    case 5:
                        {
                            estrella = Estrellas.leo;
                            Console.WriteLine("{0}", estrella); break;
                        }

                    case 6:
                        {
                            estrella = Estrellas.virgo;
                            Console.WriteLine("{0}", estrella); break;
                        }

                    case 7:
                        {
                            estrella = Estrellas.libra;
                            Console.WriteLine("{0}", estrella); break;
                        }
                    case 8:
                        {
                            estrella = Estrellas.escorpion;
                            Console.WriteLine("{0}", estrella); break;
                        }
                    case 9:
                        {
                            estrella = Estrellas.sagitario;
                            Console.WriteLine("{0}", estrella); break;
                        }
                    case 10:
                        {
                            estrella = Estrellas.capricornio;
                            Console.WriteLine("{0}", estrella); break;
                        }
                    case 11:
                        {
                            estrella = Estrellas.acuario;
                            Console.WriteLine("{0}", estrella); break;
                        }
                    case 12:
                        {
                            estrella = Estrellas.piscis;
                            Console.WriteLine("{0}", estrella); break;
                        }






                }
            } while (opciones != 0);
        }







    }



}