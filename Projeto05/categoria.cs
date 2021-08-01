using System;

class Categoria {
  private Curso curso;
  private int id;
  private string descricao;
  private int preco;
  private string professor;
  private Curso [] cursos = new Curso[10];
  private int np;
  public Categoria(int id, string descricao, int preco, string professor) {
    this.id = id;
    this.descricao = descricao;
    this.preco = preco;
    this.professor = professor;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetDescricao(string descricao){
    this.descricao = descricao;
  }
    public void SetPreco(int preco){
    this.preco = preco;
  }
  public void SetProfessor(string professor){
    this.professor = professor;
  }

   public int GetId(){
    return id;
   }
    public string GetDescricao(){
    return descricao;
    }
     public int GetPreco(){
    return preco;
   }
    public string GetProfessor(){
    return professor;
    }

    public Curso [] CursoListar(){
      Curso [] c = new Curso [np];
      Array.Copy(cursos, c, np);
      return c;
    }
    public void CursoInserir(Curso p){
      if (np == cursos.Length) {
        Array.Resize( ref cursos, 2* cursos.Length);
      }
      cursos[np] = p;
      np++;
    }
  public override string ToString(){
    return id + " - " + descricao + " - Alunos: " + np + " - professor: " + professor + " - preço: " + preco;
  }
}