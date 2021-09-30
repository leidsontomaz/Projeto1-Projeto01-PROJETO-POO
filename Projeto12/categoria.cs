using System;

public class Categoria {
  private int id;
  private string descricao;
  private Curso [] cursos = new Curso[10];
  private int np;

  public int Id {get => id; set => id = value; }
  public string Descricao {get => descricao; set => descricao = value; }
  public Categoria() { }


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
    private int CursoIndice(Curso p) {
      for (int i = 0; i < np; i++)
      if (cursos[i] == p) return i;
      return -1;
    }
    public void CursoExcluir(Curso p) {
      int n = CursoIndice(p);
      if (n == -1) return;
      for (int i = n; i < np -1; i++)
      cursos[i] = cursos[i +1];
      np--;

    }
  public override string ToString(){
    return id + " - " + descricao + " - Cursos: " + np;
}
}