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


    Curso p1 = new Curso (10, "Java para iniciantes", 10 , "Adalberto");
    Curso p2 = new Curso (11, "Java Avançado", 20 , "Miguel");
    Curso p3 = new Curso (20, "Python para iniciantes", 10 , "Adalberto");
    Curso p4 = new Curso (21, "Python Avançado", 20 , "Lucca");
    Curso p5 = new Curso (30, "HTML para iniciantes", 10 , "Beto");
    Curso p6 = new Curso (31, "HTML completo", 50 , "Beto");
    Curso p7 = new Curso (40, "C# para iniciantes", 10 , "Gilbert");
    Curso p8 = new Curso (41, "C# POO", 100 , "Gilbert");
  Console.WriteLine (p1);
  Console.WriteLine (p2);
  Console.WriteLine (p3);
  Console.WriteLine (p4);
  Console.WriteLine (p5);
  Console.WriteLine (p6);
  Console.WriteLine (p7);
  Console.WriteLine (p8);
  }
}

class Categoria {
  private int id;
  private string descricao;
  public Categoria(int id, string descricao) {
    this.id = id;
    this.descricao = descricao;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetDescricao(string descricao){
    this.descricao = descricao;
  }
   public int GetId(){
    return id;
   }
    public string GetDescricao(){
    return descricao;
    }
  public override string ToString(){
    return id + " - " + descricao;
  }
}


 class Curso {
  
   private int id;
  private string descricao;
  private double preco;
  private string professor;
  private Categoria categoria;

  public Curso (int id, string descricao, double preco, string professor) {
    this.id = id;
    this.descricao = descricao;
    this.preco = preco > 0 ? preco : 0;
    this.professor = professor;
    }

  public Curso (int id, string descricao, double preco, string professor, Categoria categoria) : this(id,descricao,preco,professor) {
    this.descricao = descricao;
    }

    public void SetId(int id){
    this.id = id;
  }
  public void SetDescricao(string descricao){
    this.descricao = descricao;
  }
  public void SetProfessor(string professor){
    this.professor = professor;
  }
  public void SetPreco(double preco){
    this.preco = preco > 0 ? preco : 0;
  }
  public void SetCategoria(Categoria categoria){
    this.categoria = categoria;
  }

   public int GetId(){
    return id;
   }
    public string GetDescricao(){
    return descricao;
    }
      public string GetProfessor(){
    return professor;
   }
    public double GetPreco(){
    return preco;
    }
    public Categoria GetCategoria(){
      return categoria;
    }
    public override string ToString(){
      if (categoria == null)
      return id + " - " + descricao + " - preço: R$ " + preco.ToString("0.00 ") + " - Professor: " + professor;
    else
      return id + " - " + descricao + " - preço: R$ " + preco.ToString("0.00 ") + " - Professor: " + professor + " - " + categoria.GetDescricao();
  }
}