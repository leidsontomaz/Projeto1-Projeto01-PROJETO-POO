using System;

public class Aluno: IComparable<Aluno> {
  public int Id {get; set; }
  public string Nome {get; set; }
  public DateTime Nascimento {get; set; }
  public int CompareTo(Aluno obj){
     return this.Nome.CompareTo(obj.Nome);
  }
  public override string ToString() {
    return Id + " - " + Nome + " - " + Nascimento.ToString("dd/MM/yyyy");
  }
}