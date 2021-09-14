using System;

class VendaCurso {
  private double preco;
  private Curso curso;
  public VendaCurso ( Curso curso) {
    this.preco = curso.GetPreco();
    this.curso = curso;
  }
  public void SetPreco(double preco){
    this.preco = preco;
  }
  public void SetCurso(Curso curso){
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