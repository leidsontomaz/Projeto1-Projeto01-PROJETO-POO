using System;

class MainClass {
  private static NCategoria ncategoria = new NCategoria ();
  private static NCurso ncurso = new NCurso ();
  public static void Main (string[] args) {
    int op = 0;
    Console.WriteLine("------Plataforma de Cursos Online para Programadores");
    do{
      try {
        op = Menu ();
        switch (op) {
          case 1: CategoriaListar (); break;
          case 2: CategoriaInserir(); break;
          case 3: CursoListar(); break;
          case 4: CursoInserir(); break;
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
    Console.WriteLine("1- Visualizar listas de categorias de cursos");
    Console.WriteLine("2- Inserir uma nova categoria de cursos");
     Console.WriteLine("3- Visualizar os cursos listados");
    Console.WriteLine("4- Inserir um novo curso na plataforma");
    Console.WriteLine("0 - Fim");
    Console.Write("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
   public static void CursoListar() {
    Console.WriteLine("---- Lista de Categorias ---- ");
    Curso [] ps = ncurso.Listar();
    

   if (ps.Length == 0){
     Console.WriteLine("Nenhuma  curso cadastrado");
     return;
   }
    foreach (Curso p in ps)
    Console.WriteLine(p);
    Console.WriteLine();

  }
  public static void CursoInserir(){
    Console.WriteLine("---- Inserir um novo curso ---- ");
    Console.WriteLine("Informe  um código para o curso: ");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe  uma descrição: ");
    string descricao = Console.ReadLine();
    Console.WriteLine("Informe  o nome do professor ");
    string professor = Console.ReadLine();
    Console.WriteLine("Informe  o preço do curso: ");
    double preco = double.Parse(Console.ReadLine()); 
    Console.Write("Informe o código da categoria do curso: ");
    int  idcategoria = int.Parse(Console.ReadLine());
    Categoria c = ncategoria.Listar(idcategoria);
    Curso p = new Curso(id, descricao, preco, professor, c);
    ncurso.Inserir(p);

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
    Categoria c = new Categoria(id, descricao);
    ncategoria.Inserir(c);
  }
  }