using System;
using retofinal.Clases;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Bienvenido al juego piedra, papel o tijera");
        Random random = new Random();
        Papel p = new Papel();
        Piedra s = new Piedra();
        Tijera t = new Tijera();
        Objeto[] objetos = new Objeto[3];
        objetos[0] = s;
        objetos[1] = p;
        objetos[2] = t;
        int jug = 1, J1;
        String Jugador, maquina;
        String[] juegos = { s.Nombre, p.Nombre, t.Nombre };
        while (jug == 1)
        {
            Console.WriteLine("Menú");
            Console.WriteLine("1.\n" + s.Nombre);
            Console.WriteLine("2.\n" + p.Nombre);
            Console.WriteLine("3.\n" + t.Nombre);
            Console.WriteLine("Ingrese opción");
            J1 = int.Parse(Console.ReadLine());
            Jugador = juegos[J1 - 1];
            maquina = juegos[random.Next(0, 3)];
            Console.WriteLine("La computadora escogio " + (maquina));
            if (((Jugador == s.Nombre) && (maquina == t.Nombre))
                || ((Jugador == p.Nombre) && (maquina == s.Nombre))
                || ((Jugador == t.Nombre) && (maquina == p.Nombre)))
                Console.WriteLine("GANASTE\n");

            if (((Jugador == s.Nombre) && (maquina == p.Nombre))
                || ((Jugador == p.Nombre) && (maquina == t.Nombre))
                || ((Jugador == t.Nombre) && (maquina == s.Nombre)))
                Console.WriteLine("PERDISTE\n");

            if (((Jugador == s.Nombre) && (maquina == s.Nombre))
                || ((Jugador == p.Nombre) && (maquina == p.Nombre))
                || ((Jugador == t.Nombre) && (maquina == t.Nombre)))
                Console.WriteLine("EMPATE\n");

            Console.WriteLine("\n¿Otro intento? 1:si 0:no");
            jug = int.Parse(Console.ReadLine());
        }
        Console.ReadKey();
    }
}