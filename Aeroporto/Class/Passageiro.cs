using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Passageiro
{
    private string Nome, CPF, RG, DataNascimento, Sexo, EstadoCivil, Endereco;
    private int Idade, ID_Embarque;

    public override bool Equals(Object obj)
    {
        if (obj is Passageiro)
        {
            Passageiro p = (Passageiro)obj;

            if (((this.CPF == null) && (p.getCPF() == null) || this.CPF.Equals(p.getCPF())) ||
                ((this.RG == null) && (p.getRG() == null) || this.RG.Equals(p.getRG())))
                return true;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    
    public override string ToString()
    {
        return this.Nome;
    }

    public void setNome(string n)
    {
        Nome = n;
    }

    public string getNome()
    {
        return Nome;
    }

    public void setEmbarque(int e)
    {
        ID_Embarque = e;
    }

    public int getEmbarque()
    {
        return ID_Embarque;
    }

    public void setCPF(string c)
    {
        CPF = c;
    }

    public string getCPF()
    {
        return CPF;
    }

    public void setRG(string r)
    {
        RG = r;
    }

    public string getRG()
    {
        return RG;
    }

    public void setDataNascimento(string d)
    {
        DataNascimento = d;
    }

    public string getDataNascimento()
    {
        return DataNascimento;
    }

    public void setSexo(string s)
    {
        Sexo = s;
    }

    public string getSexo()
    {
        return Sexo;
    }

    public void setEstadoCivil(string e)
    {
        EstadoCivil = e;
    }

    public string getEstadoCivil()
    {
        return EstadoCivil;
    }

    public void setEndereco(string end)
    {
        Endereco = end;
    }

    public string getEndereco()
    {
        return Endereco;
    }

    public void setIdade(int i)
    {
        Idade = i;
    }

    public int getIdade()
    {
        return Idade;
    }
}
