using System;

class NCurso {
  private Curso[] cursos = new Curso[10];
  private int np;
  
  public void Inserir(Curso p) {
    if (np == cursos.Length) {
      Array.Resize( ref cursos, 2 * cursos.Length);
    
    }
    cursos[np] = p;
    np++;

  Categoria c = p.GetCategoria();
  if (c != null) c.CursoInserir(p);
   }
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
  
}