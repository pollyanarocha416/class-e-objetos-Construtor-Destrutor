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
     //sobrecaga de construtores : varios construtores pro mesmo objto 
    public jogador(string n, int e, bool v){
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info(){
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("energia jogador: {0}", energia);
        Console.WriteLine("estado jogador: {0}", vivo);
    }

}

    //destrutor:e ao contrario do contrutor
    //~jogador(){
    //    Console.WriteLine("deletado {0}", nome);
    //}



class Program{
    static void Main(){

        //string nome1;
        //Console.WriteLine("Digite o nome do jogador 1: ");
        //nome1 = Console.ReadLine();
        //o new reserva memoria pra esse objeto
        
        jogador j2 = new jogador("Felipe");//j1 e um objeto da classe Jogador
        jogador j3 = new jogador("lorde", 10, true);
        jogador j4 = new jogador("felipe", 30, true);
        jogador j5 = new jogador("zezinDosTrator", 0, false);

        
        j2.info();
        j3.info();
        j4.info();
        j5.info();


        //Console.WriteLine("nome do jogador 1: {0}",j1.nome);
        //Console.WriteLine("nome do jogador 2: {0}",j2.nome);
        //mudar o valor aqui
        //j1.energia = 100;
        j2.energia = 50;
        //Console.WriteLine("\nEnergia do jogador 1: {0}", j1.energia);
        //Console.WriteLine("Energia do jogador 2: {0}", j2.energia);

        //construtores e destrutores:
    }
}