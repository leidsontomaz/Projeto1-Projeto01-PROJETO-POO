using System;

class MainClass {
  public static void Main (string[] args) {
    int op = 0;
    Console.WriteLine("------Plataforma de Cursos Online para Programadores");
    do{
      try {
        op = Menu ();
        switch (op) {
          case 1: CategoriaListar (); break;
          case 2: CategoriaInserir(); break;
        }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);
        op = 100;
      }
    } while (op!= 0);
  Console.WriteLine("Até breve...");
  }

  public static int Menu(){
    Console.WriteLine();
    Console.WriteLine("----------");
    Console.WriteLine("1- Categoria - Listar");
    Console.WriteLine("2- Categoria - Inserir");
    Console.WriteLine("0 - Fim");
    Console.WriteLine("Informe uma opção ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;

  }
  public static void CategoriaListar(){
    Console.WriteLine("---- Lista de Categorias ---- ");

  }
  public static void CategoriaInserir(){
    Console.WriteLine("---- Inserir uma nova Categoria ---- ");
  }
  }