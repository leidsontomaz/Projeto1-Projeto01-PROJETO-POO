using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;

class NCategoria {
  private NCategoria() { }
  static NCategoria obj = new NCategoria();
  public static NCategoria Singleton{ get => obj; }
   
  private Categoria[] categorias = new Categoria[10];
  private int nc;

  public void Abrir() {
    Arquivo<Categoria[]> f = new Arquivo<Categoria[]>();
    categorias = f.Abrir("./categorias.xml");
    nc = categorias.Length;
  }

  public void Salvar() {
     Arquivo<Categoria[]> f = new Arquivo<Categoria[]>();
    f.Salvar("./categorias.xml", Listar());
    
  }

  public Categoria []  Listar() {
    Categoria[] c = new Categoria[nc];
    Array.Copy (categorias, c , nc);
    return c;
  }
   public Categoria Listar(int id) {
     for (int i = 0; i < nc; i++)
       if (categorias[i].GetId() == id) return categorias[i];
     return null;
   }
  public void Inserir(Categoria c) {
    if (nc == categorias.Length) {
      Array.Resize( ref categorias, 2 * categorias.Length);
    
    }
    categorias[nc] = c;
    nc++;

  }

  public  void Atualizar(Categoria c) {
    Categoria c_atual = Listar(c.GetId());
    if (c_atual == null) return;
    c_atual.SetDescricao(c.GetDescricao());
  }
  
  private int Indice(Categoria c){
   for (int i= 0; i < nc; i++)
   if (categorias[i] == c) return i;
   return -1;
  }
  public  void Excluir(Categoria c) {
    int n = Indice(c);
    if (n == -1) return;
    for (int i = n; i < nc; i++)
    categorias[i] = categorias[i + 1];
    nc--;
    Curso [] ps = c.CursoListar();
    foreach(Curso p in ps ) p.SetCategoria(null);
  }
}