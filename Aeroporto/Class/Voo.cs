using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Voo
{
    private string Nome, Origem, Destino;
    private int Numero, Capacidade_Pessoa, Quantidade_Assento;
    private List<Passageiro> Passenger = new List<Passageiro>();
    private Queue<Passageiro> pPassenger = new Queue<Passageiro>();

    public override string ToString()
    {
        return this.Nome;
    }

    public List<Passageiro> getPassengerList()
    {
        return Passenger;
    }

    public Queue<Passageiro> getPassengerQueue()
    {
        return pPassenger;
    }

    public bool removePassengerQueue(Passageiro p)
    {
        bool rt = false;
        Queue<Passageiro> Aux = new Queue<Passageiro>();

        while (pPassenger.Count > 0)
        {
            var Item = pPassenger.Dequeue();

            if (p.Equals(Item))
            {
                rt = true;
                break;
            }

            Aux.Enqueue(Item);
        }

        while (Aux.Count > 0)
        {
            var Item = Aux.Dequeue();

            pPassenger.Enqueue(Item);
        }

        return rt;
    }

    public void addPassenger(Passageiro p)
    {
        Passenger.Add(p);
        Quantidade_Assento--;

        if (Quantidade_Assento < 0)
            Quantidade_Assento = 0;
    }

    public void removePassenger(Passageiro p)
    {
        foreach (Passageiro psg in Passenger)
        {
            if (p.Equals(psg))
            {
                Passenger.Remove(psg);
                Quantidade_Assento++;

                if (Quantidade_Assento > Capacidade_Pessoa)
                    Quantidade_Assento = Capacidade_Pessoa;

                break;
            }
        }
    }

    public void setNome(string n)
    {
        Nome = n;
    }

    public string getNome()
    {
        return Nome;
    }
    public void setOrigem(string o)
    {
        Origem = o;
    }

    public string getOrigem()
    {
        return Origem;
    }

    public void setDestino(string d)
    {
        Destino = d;
    }

    public string getDestino()
    {
        return Destino;
    }

    public void setNumero(int n)
    {
        Numero = n;
    }

    public int getNumero()
    {
        return Numero;
    }

    public void setCapacidade(int c)
    {
        Capacidade_Pessoa = c;
    }

    public int getCapacidade()
    {
        return Capacidade_Pessoa;
    }

    public void setAssentos(int a)
    {
        Quantidade_Assento = a;
    }

    public int getAssentos()
    {
        return Quantidade_Assento;
    }
}
