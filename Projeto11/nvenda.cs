using System;
using System.Collections.Generic;

class NVenda {
  private List<Venda> vendas = new List<Venda>();
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
