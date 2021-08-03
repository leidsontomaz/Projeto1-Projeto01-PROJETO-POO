using System;

class NCurso {
  private Curso[] cursos = new Curso[10];
  private int np;
  public Curso []  Listar() {
    Curso[] p = new Curso[np];
    Array.Copy (cursos, p , np);
    return p;
  }
   public Curso Listar(int id) {
     for (int i = 0; i < np; i++)
       if (cursos[i].GetId() == id) return cursos[i];
     return null;
   }
   
  public void Inserir(Curso p) {
    if (np == cursos.Length) {
      Array.Resize( ref cursos, 2 * cursos.Length);
    
    }
    cursos[np] = p;
    np++;

  Categoria c = p.GetCategoria();
  if (c != null) c.CursoInserir(p);
   }

  public void Atualizar(Curso p){
    Curso p_atual = Listar (p.GetId());
    p_atual.SetDescricao(p.GetDescricao());
    p_atual.SetProfessor(p.GetProfessor());
    p_atual.SetPreco(p.GetPreco());
    if (p_atual.GetCategoria() != null) {
      p_atual.GetCategoria().CursoExcluir(p_atual);
    }
    p_atual.SetCategoria(p.GetCategoria());
    if (p_atual.GetCategoria() != null) {
    p_atual.GetCategoria().CursoInserir(p_atual);
  }
  }
   private int Indice(Curso p){
    for (int i =0; i < np; i++)
    if (cursos[i] == p) return i;
    return -1;
   }

  public void Excluir(Curso p){
    int n = Indice(p);
    if (n == -1) return;
    for (int i =0; i < np; i++)
    cursos[i] = cursos[1+1];
    np--;
    Categoria c = p.GetCategoria();
    if (c != null) c.CursoExcluir(p);
  }
  
  
}