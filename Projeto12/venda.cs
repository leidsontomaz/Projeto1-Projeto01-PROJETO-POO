using System;
using System.Collections.Generic;

public class Venda {
private int id;
private DateTime data;
private bool carrinho;
private Aluno aluno;
private int alunoId;
private List<VendaCurso> cursos = new List<VendaCurso>();

public int Id {get => id; set => id = value;}
public DateTime Data {get => data; set => data = value;}
public bool Carrinho {get => carrinho; set => carrinho = value;}
public int AlunoId {get => alunoId; set => alunoId = value;}
public List<VendaCurso> Cursos {get => cursos; set => cursos = value;}
public Venda() { }

public Venda(DateTime data, Aluno aluno){
  this.data = data;
  this.carrinho = true;
  this.aluno = aluno;
  this.AlunoId = aluno.Id;
}
public void SetId (int id) {
    this.id = id;

  }
  public void SetData(DateTime data){
    this.data = data;
  }
  public void SetCarrinho(bool carrinho){
    this.carrinho = carrinho;
  }

  public void SetAluno(Aluno aluno){
    this.aluno = aluno;
  }
  public int GetId(){
    return id;
  }
  public DateTime GetData(){
    return data;
  }
  public bool GetCarrinho(){
    return carrinho;
}
 public Aluno GetAluno(){
    return aluno;
}

public override string ToString(){
  if (carrinho)
    return "compra: " + id + " - " + data.ToString("dd/mm/yyyy") + " - Aluno:" + aluno.Nome + " - carrinho";
    else 
    return "compra: " + id + " - " + data.ToString("dd/mm/yyyy") + " - Aluno:" + aluno.Nome;
}

private VendaCurso CursoListar(Curso p){
 foreach(VendaCurso vi in cursos)
 if (vi.GetCurso() == p) return vi;
 return null;
}

public List<VendaCurso> CursoListar(){
  return cursos;
}
public void CursoInserir(Curso p){
  VendaCurso curso = CursoListar(p);
  if (curso == null){
  curso = new VendaCurso(p);
  cursos.Add(curso);
  }
  else
 Console.WriteLine("Você já adicionou esse curso");
}
public void CursoExcluir(){
  cursos.Clear();
}
}