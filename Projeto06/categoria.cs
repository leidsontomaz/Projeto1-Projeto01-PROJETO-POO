using System;

class Categoria {
  private Curso curso;
  private int id;
  private string descricao;
  private Curso [] cursos = new Curso[10];
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
    return id + " - " + descricao + " - Cursos: " + np;
}
}