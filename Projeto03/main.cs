using System;

class MainClass {
  public static void Main (string[] args) {
    Categoria c1 = new Categoria (10, "Java");
    Categoria c2 = new Categoria (20, "Python");
    Categoria c3 = new Categoria (30, "HTML");
    Categoria c4 = new Categoria (40, "C#");
    Console.WriteLine (c1);
    Console.WriteLine (c2);
    Console.WriteLine (c3);
    Console.WriteLine (c4);


    Curso p1 = new Curso (10, "Java para iniciantes", 10 , "Adalberto", c1);
    Curso p2 = new Curso (11, "Java Avançado", 20 , "Miguel", c1);
    Curso p3 = new Curso (20, "Python para iniciantes", 10 , "Adalberto", c2);
    Curso p4 = new Curso (21, "Python Avançado", 20 , "Lucca", c2);
    Curso p5 = new Curso (30, "HTML para iniciantes", 10 , "Beto", c3);
    Curso p6 = new Curso (31, "HTML completo", 50 , "Beto", c3);
    Curso p7 = new Curso (40, "C# para iniciantes", 10 , "Gilbert", c4);
    Curso p8 = new Curso (41, "C# POO", 100 , "Gilbert", c4);
  Console.WriteLine();
  Console.WriteLine();
  Console.WriteLine (p1);
  Console.WriteLine (p2);
  Console.WriteLine (p3);
  Console.WriteLine (p4);
  Console.WriteLine (p5);
  Console.WriteLine (p6);
  Console.WriteLine (p7);
  Console.WriteLine (p8);

  c1.ProdutoInserir(p1);
  c1.ProdutoInserir(p2);
  c2.ProdutoInserir(p3);
  c2.ProdutoInserir(p4);
  c3.ProdutoInserir(p5);
  c3.ProdutoInserir(p6);
  c4.ProdutoInserir(p7);
  c4.ProdutoInserir(p8);
  Console.WriteLine();
  Console.WriteLine();
  Curso [] v = c1.ProdutoListar ();
  Console.Write("Produtos na categoria: ");
  Console.WriteLine(c1.GetDescricao());
  foreach (Curso p in v) Console.WriteLine(p);

  Console.WriteLine();
   v = c2.ProdutoListar ();
  Console.Write("Produtos na categoria: ");
  Console.WriteLine(c2.GetDescricao());
  foreach (Curso p in v) Console.WriteLine(p);

  Console.WriteLine();
   v = c3.ProdutoListar ();
  Console.Write("Produtos na categoria: ");
  Console.WriteLine(c3.GetDescricao());
  foreach (Curso p in v) Console.WriteLine(p);

  Console.WriteLine();
   v = c4.ProdutoListar ();
  Console.Write("Produtos na categoria: ");
  Console.WriteLine(c4.GetDescricao());
  foreach (Curso p in v) Console.WriteLine(p);
  }
}