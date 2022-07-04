public class jogador{//toda classa tem um construtor
    public int energia;
    public bool vivo;
    public string nome;

    //construtor: Vai ser esecultado altomaticamente...
    public jogador(string n){//quando eu istanciar um objeto da classe.
        energia = 100;
        vivo = true;
        nome = n;
    }

    //destrutor:e ao contrario do contrutor
    ~jogador(){
        Console.WriteLine("deletado");
    }

}

class Program{
    static void Main(){

        string nome1;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1 = Console.ReadLine();
        //o new reserva memoria pra esse objeto
        jogador j1 = new jogador(nome1);
        jogador j2 = new jogador("Felipe");//j1 e um objeto da classe Jogador
        Console.WriteLine("nome do jogador 1: {0}",nome1);
        Console.WriteLine("nome do jogador 2: {0}",j2.nome);
        //mudar o valor aqui
        j1.energia = 100;
        j2.energia = 50;
        Console.WriteLine("\nEnergia do jogador 1: {0}", j1.energia);
        Console.WriteLine("Energia do jogador 2: {0}", j2.energia);

        //construtores e destrutores:
    }
}