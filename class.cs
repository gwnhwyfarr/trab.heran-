using System;

class Colaborador : Pessoa
{
    public double salario;

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;
    }

public void mensagemColaborador()
    {
        Console.WriteLine("Salario: " + salario);
    }
}
