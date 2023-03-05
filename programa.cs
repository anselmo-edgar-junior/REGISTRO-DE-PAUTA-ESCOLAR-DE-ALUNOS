class Aux{
    
    public int idade;
    public float media;
    public string nome;

    public Aux(){
        idade=0;
        nome="NULL";
        media=0.0f;
    }


    public void registrar(string nome, int idade, float media){
        this.nome=nome;
        this.idade=idade;
        this.media=media; 


        Console.WriteLine("Nome:{0}",this.nome);
        Console.WriteLine("idade:{0}",this.idade);
        Console.WriteLine("Média:{0}",this.media);
    }

    
}

class Resgistro{

   public struct registrar{
      public  string nome;
      public  int idade;
      public  float media;
    }
    static void Main(string[] args){
        int n;

        Console.WriteLine("quantos alunos você deseja registrar?");
        n=Convert.ToInt32(Console.ReadLine());
        Console.Clear();

         

        registrar[] reg= new registrar[n];
        
        
        Aux aux=new Aux();

        for(int i=0; i<reg.Length; i++){
            Console.WriteLine("digite seu nome: ------pessoa({0})---", i+1);
            reg[i].nome=Console.ReadLine();
            Console.WriteLine("digite sua idade: --------pessoa({0})---",i+1);
            reg[i].idade=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite sua media:----pessoa({0})---",i+1);
            float.TryParse(Console.ReadLine(), out reg[i].media);
            Console.Clear();
            if(reg[i].media<10){

                 Console.WriteLine("{0} foi reprovado/(a) com média:{1}",reg[i].nome, reg[i].media);
                 
            }else{
                Console.WriteLine("{0} foi aprovado/(a) com média:{1}",reg[i].nome, reg[i].media);
            }

            

            

            aux.registrar(reg[i].nome, reg[i].idade, reg[i].media);


            Console.WriteLine("\n\n");

            if(n>1){
                 

             Console.WriteLine("para ver os dados de outra pessoa pressione 'enter' ");
             Console.ReadLine();
             Console.Clear();}
        }

         


    }
}