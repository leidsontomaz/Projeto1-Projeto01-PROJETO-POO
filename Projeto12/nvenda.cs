using System;
using System.Collections.Generic;

class NVenda {
    private NVenda() { }
  static NVenda obj = new NVenda();
  public static NVenda Singleton{ get => obj; }
  
  private List<Venda> vendas = new List<Venda>();


 public void Abrir() {
    Arquivo<List<Venda>> f = new Arquivo<List<Venda>>();
    vendas = f.Abrir("./vendas.xml");
    AtualizarAluno();
    AtualizarCurso();
  }


  public void Salvar() {
     Arquivo<List<Venda>> f = new Arquivo<List<Venda>>();
    f.Salvar("./vendas.xml", Listar());
    
  }


  private void AtualizarAluno(){
    foreach(Venda v in vendas){
      Aluno a = NAluno.Singleton.Listar(v.AlunoId);
      if (a!=null) v.SetAluno(a);
    }
  }

 private void AtualizarCurso(){
   foreach(Venda v in vendas){
     foreach(VendaCurso vi in v.CursoListar()){
       Curso p = NCurso.Singleton.Listar(vi.CursoId);
       if (p!=null) vi.SetCurso(p);
     }
   }
    
  }

  public List<Venda> Listar(){
    return vendas;
  }


  public List<Venda> Listar(Aluno a){
    List<Venda> vs = new List<Venda>();
    foreach(Venda v in vendas)
    if (v.GetAluno() == a) vs.Add(v);
    return vs;
  }

    public Venda ListarCarrinho(Aluno a){
    foreach(Venda v in vendas)
    if (v.GetAluno() == a && v.GetCarrinho()) return v;
    return null;
  }

  public void Inserir(Venda v, bool carrinho){
    int max = 0;
    foreach (Venda obj in vendas)
    if (obj.GetId()> max) max = obj.GetId();
    v.SetId(max +1);

    vendas.Add(v);
  
   v.SetCarrinho(carrinho);

  }

  public List<VendaCurso> CursoListar( Venda v) {
    return v.CursoListar();
  }
public void CursoInserir(Venda v, Curso p) {
  v.CursoInserir( p);
}

public void CursoExcluir(Venda v){
  v.CursoExcluir();
}
}
