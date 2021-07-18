using System;
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
    this.categoria = categoria;
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