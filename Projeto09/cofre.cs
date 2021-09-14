using System;

class Cofre {
  private double dinheiro;
  private double lucro;
  public Cofre (double dinheiro, double lucro){
  this.dinheiro = dinheiro;
  this.lucro = lucro;
  }
  
  public void CursoComprar(Curso p){
      if (np == cursos.Length) {
        Array.Resize( ref cursos, 2* cursos.Length);
      }
      cursos[np] = p;
      np++;
    }

  public void SetDinheiro(double lucro){
    this.dinheiro = dinheiro;
  }
  public void SetLucro(double lucro){
    this.lucro = lucro;
}
 public double GetDinheiro(){
    return dinheiro;
 public double GetLucro(){
    return lucro;

