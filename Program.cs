using System;
static public class jogador{//toda classa tem um construtor
    static public int energia;
    static public bool vivo;
    //static public string nome;

    //construtor: Vai ser esecultado altomaticamente...
    static public void iniciar(string n){//quando eu istanciar um objeto da classe.
        energia = 100;
        vivo = true;
        //nome = n;
    }
     //sobrecaga de construtores : varios construtores pro mesmo objto 
   

    //static public void info(){
    //    Console.WriteLine("Nome jogador: {0}", nome);
    //    Console.WriteLine("energia jogador: {0}", energia);
    //    Console.WriteLine("estado jogador: {0}", vivo);

    //}
}
class Inimigo{
    static public bool alerta;
    public string nome;

    public Inimigo(string n){
        alerta = false;
        nome = n;
    }
     
     public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("---------------");
     }
}
    //destrutor:e ao contrario do contrutor
    //~jogador(){
    //    Console.WriteLine("deletado {0}", nome);
    //}



class Program{
    static void Main(){
        jogador.iniciar("Bruno");
        //jogador.info();

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta = true;
        i1.info();
        i2.info();
        i3.info();




        //string nome1;
        //Console.WriteLine("Digite o nome do jogador 1: ");
        //nome1 = Console.ReadLine();
        //o new reserva memoria pra esse objeto

        //jogador j2 = new jogador("Felipe");//j1 e um objeto da classe Jogador
        //jogador j3 = new jogador("lorde", 10, true);
        //jogador j4 = new jogador("felipe", 30, true);
        //jogador j5 = new jogador("zezinDosTrator", 0, false);


        //j2.info();
        //j3.info();
        //j4.info();
        //j5.info();


        //Console.WriteLine("nome do jogador 1: {0}",j1.nome);
        //Console.WriteLine("nome do jogador 2: {0}",j2.nome);
        //mudar o valor aqui
        //j1.energia = 100;
        //j2.energia = 50;
        //Console.WriteLine("\nEnergia do jogador 1: {0}", j1.energia);
        //Console.WriteLine("Energia do jogador 2: {0}", j2.energia);

        //construtores e destrutores:
    }
}