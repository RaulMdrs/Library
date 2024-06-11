// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        public static BooksController BooksController = new BooksController();
        public static void Menu()
        {
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------ MENU ------------------");
                Console.WriteLine("1. Livros");
                Console.WriteLine("2. Usuários");
                Console.WriteLine("3. Empréstimos");
                Console.WriteLine("4. Sair");
                Console.WriteLine("------------------------------------------");
                Console.Write("Escolha uma opção: ");
                option = int.Parse(Console.ReadLine());
                ReadOption(option);
            } while (option != 5);
        }
        
        static void Main(string[] args)
        {
            Menu();
        }

        public static void ReadOption(int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Livros");
                    BooksController.Menu();
                    break;
                case 2:
                    Console.WriteLine("Usuários");
                    break;
                case 3:
                    Console.WriteLine("Empréstimos");
                    break;
                case 54:
                    Exit();
                    break;
                default:
                    InvalidOption();
                    break;
            }
        }
        
        public static void Exit()
        {
            Console.WriteLine("Saindo...");
            return;
        }
        
        public static void InvalidOption()
        {
            Console.WriteLine("Opção inválida");
            return;
        }
    }
}