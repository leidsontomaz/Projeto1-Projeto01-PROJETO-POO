using System;

class Categoria {
  private int id;
  private string descricao;
  private Curso [] produtos = new Curso[10];
  private int np;
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
    public Curso [] ProdutoListar(){
      Curso [] c = new Curso [np];
      Array.Copy(produtos, c, np);
      return c;
    }
    public void ProdutoInserir(Curso p){
      if (np == produtos.Length) {
        Array.Resize( ref produtos, 2* produtos.Length);
      }
      produtos[np] = p;
      np++;
    }
  public override string ToString(){
    return id + " - " + descricao + " - Numeros de produtos: " + np;
  }
}