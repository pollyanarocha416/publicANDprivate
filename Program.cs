

class jogador{
    private int energia;
    private string nome;

    public jogador(string nome){
        this.nome = nome;
        energia = 0;
    }
    public int getEnergia(){
        return energia;
    }
    public string getNome(){
        return nome;
    }
    public void setEnergia(int e){
        if(e<0){
            if(energia-e < 0){
                energia = 0;
            }else{
                energia += e;
            }
        }else if(e>0){
            if(energia+e > 100){
                energia = 100;
            }else{
                energia += e;
            }
        }

    }
}



class Program
{
    static void Main(){
        jogador j1 = new jogador("Bruno");

        j1.setEnergia(-30);

        Console.WriteLine("Nome: {0}",j1.getNome());
        Console.WriteLine("Energia: {0}",j1.getEnergia());
    }
}
