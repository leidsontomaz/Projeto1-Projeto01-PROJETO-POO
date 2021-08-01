using System;

class MainClass {
  private static NCategoria ncategoria = new NCategoria ();
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
    Console.WriteLine("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static void CategoriaListar() {
    Console.WriteLine("---- Lista de Categorias ---- ");
    Categoria [] cs = ncategoria.Listar();
    

   if (cs.Length == 0){
     Console.WriteLine("Nenhuma categoria de curso cadastrada");
     return;
   }
    foreach (Categoria c in cs)
    Console.WriteLine(c);
    Console.WriteLine();

  }
  public static void CategoriaInserir(){
    Console.WriteLine("---- Inserir uma nova Categoria ---- ");
    Console.WriteLine("Informe  um código para a categoria: ");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe  uma descrição: ");
    string descricao = Console.ReadLine();
    Console.WriteLine("Informe  o nome do professor ");
    string professor = Console.ReadLine();
    Console.WriteLine("Informe  o preço do curso: ");
    int preco = int.Parse(Console.ReadLine());
    Categoria c = new Categoria(id, descricao,preco,professor);
    ncategoria.Inserir(c);
  }
  }