using System;
using System.Collections.Generic;

namespace AlquilerDeCarros
{
    public static class AlquilerUtil
    {
        public static List Alquileres = new List();

        public static void Crear(int numero, Carro carro, Cliente cliente, double precio)
        {
            if (precio <= cliente.PagoMaximo)
            {
                Alquileres.Add(new Alquiler { Numero = numero, CarroAlq = carro, Contratante = cliente, Precio = precio });
                Console.WriteLine("¡Alquiler registrado con éxito!");
            }
            else
            {
                Console.WriteLine("El precio excede el pago máximo del cliente.");
            }
        }

        public static void Listar()
        {
            Console.WriteLine("Listado de Alquileres:");
            foreach (var alquiler in Alquileres)
            {
                Console.WriteLine(alquiler);
            }
        }  

        public static void CarrosAAlquilar(Cliente cliente, List<Carro> carrosDisponibles)
        {
            Console.WriteLine($"Carros disponibles para el cliente {cliente.Nombre} con un pago máximo de {cliente.PagoMaximo:C}:");

            bool hayCarrosDisponibles = false;
            foreach (var carro in carrosDisponibles)
            {
                if (carro.PrecioAlquiler <= cliente.PagoMaximo)
                {
                    Console.WriteLine(carro);
                    hayCarrosDisponibles = true;
                }
            }

            if (!hayCarrosDisponibles)
            {
                Console.WriteLine("No hay carros disponibles dentro del presupuesto del cliente.");
            }
        }
    }
}