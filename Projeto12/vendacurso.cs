using System;

public class VendaCurso {
  private double preco;
  private Curso curso;
  private int cursoId;

  public double Preco {get => preco; set => preco = value;}
  public int CursoId {get => cursoId; set => cursoId = value;}
  public VendaCurso() { }

  public VendaCurso ( Curso curso) {
    this.preco = curso.GetPreco();
    this.curso = curso;
    this.cursoId = curso.GetId();
  }
  public void SetPreco(double preco){
    this.preco = preco;
  }
  public void SetCurso(Curso curso){
    this.curso = curso;
    this.curso = curso;
  }
  public double GetPreco(){
    return preco;
  }
  public Curso GetCurso(){
    return curso;
}
public override string ToString(){
  return curso.GetDescricao() + " - preço: " + preco.ToString("c2");
}
}