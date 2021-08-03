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
          case 3: CategoriaAtualizar(); break;
          case 4: CategoriaExcluir(); break;
          case 5: CursoListar(); break;
          case 6: CursoInserir(); break;
          case 7: CursoAtualizar(); break;
          case 8: CursoExcluir(); break;
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
     Console.WriteLine("3- Atualizar categorias");
    Console.WriteLine("4- Excluir uma categoria");
    Console.WriteLine("5- Visualizar os cursos listados");
    Console.WriteLine("6- Inserir um novo curso na plataforma");
     Console.WriteLine("7- Atualizar cursos");
    Console.WriteLine("8- Excluir um curso");
    Console.WriteLine("0 - Fim");
    Console.Write("Informe uma opção: ");
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
    Categoria c = new Categoria(id, descricao);
    ncategoria.Inserir(c);
  }

   public static void CategoriaAtualizar() {
     Console.WriteLine("----- Atualização de Categorias ----------");
     CategoriaListar();
    Console.WriteLine("Informe  um código para ATUALIZAR uma categoria: ");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe  uma descrição: ");
    string descricao = Console.ReadLine();
    Categoria c = new Categoria(id, descricao);
    ncategoria.Atualizar(c);
   }

   public static void CategoriaExcluir() {
     Console.WriteLine("----- Exclusão de Categorias ----------");
     CategoriaListar();
     Console.WriteLine("Informe  um código para EXCLUIR uma categoria: ");
    int id = int.Parse(Console.ReadLine());
    Categoria c = ncategoria.Listar(id);
    ncategoria.Excluir(c);
   }
  

   public static void CursoListar() {
    Console.WriteLine("---- Lista de Cursos ---- ");
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

  public static void CursoAtualizar() {
     Console.WriteLine("---- ATUALIZAÇÃO de um curso ---- ");
     CursoListar();
    Console.WriteLine("Informe  o código para atualizar curso: ");
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
    ncurso.Atualizar(p);
    }

  public static void CursoExcluir() {
    Console.WriteLine("----- Exclusão de Curso ----------");
     CategoriaListar();
     Console.WriteLine("Informe  um código para EXCLUIR um Curso: ");
    int id = int.Parse(Console.ReadLine());
    Curso p = ncurso.Listar(id);
    ncurso.Excluir(p);
  }
}