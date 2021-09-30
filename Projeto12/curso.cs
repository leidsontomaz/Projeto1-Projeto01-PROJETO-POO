using System;
 public class Curso {  
  private int id;
  private string descricao;
  private double preco;
  private string professor;
  private int categoriaId;
  private Categoria categoria;

  public int Id {get => id; set => id = value; }
  public string Descricao {get => descricao; set => descricao = value; }
  public double Preco {get => preco; set => preco = value; }
  public string Professor {get => professor; set => professor = value; }
  public int CategoriaId {get => categoriaId; set => categoriaId = value; }
  public Curso() { }


  public Curso (int id, string descricao, double preco, string professor) {
    this.id = id;
    this.descricao = descricao;
    this.preco = preco > 0 ? preco : 0;
    this.professor = professor;
    }

  public Curso (int id, string descricao, double preco, string professor, Categoria categoria) : this(id,descricao,preco,professor) {
    this.categoria = categoria;
    this.categoriaId = categoria.GetId();
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
    this.CategoriaId = categoria.GetId();
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