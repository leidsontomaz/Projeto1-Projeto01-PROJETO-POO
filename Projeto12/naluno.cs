using System;
using System.Collections.Generic;


class NAluno {
  private NAluno() { }
  static NAluno obj = new NAluno();
  public static NAluno Singleton{ get => obj; }
   
  private List<Aluno> alunos = new List<Aluno>();
       public void Abrir() {
    Arquivo<List<Aluno>> f = new Arquivo<List<Aluno>>();
    alunos = f.Abrir("./alunos.xml");
  }

  public void Salvar() {
     Arquivo<List<Aluno>> f = new Arquivo<List<Aluno>>();
    f.Salvar("./alunos.xml", Listar());
    
  }

  public List<Aluno> Listar() {
    alunos.Sort();
    return alunos;
  }
   public Aluno Listar(int id) {
     for (int i = 0; i < alunos.Count; i++)
       if (alunos[i].Id == id) return alunos[i];
     return null;
   }
  public void Inserir(Aluno a) {
    int max = 0;
    foreach(Aluno obj in alunos)
    if (obj.Id > max) max = obj.Id;
    a.Id = max +1;
    alunos.Add(a);
  }

  public  void Atualizar(Aluno a) {
    Aluno a_atual = Listar(a.Id);
    if (a_atual == null) return;
    a_atual.Nome = a.Nome;
    a_atual.Nascimento = a.Nascimento;
  }
  
  public  void Excluir(Aluno a) {
    if (a != null) alunos.Remove(a);
  }
}