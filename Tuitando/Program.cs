using System; 

class minhaClasse {

    static void Main(string[] args) { 

        Console.WriteLine("Escreva a linha de texto:");
        string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            if(arr.Length <=  140) //complete a condicional
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");
    }

}
