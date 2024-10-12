int idade;

Console.WriteLine("Digite sua idade: ");
idade =  Convert.ToInt16(Console.ReadLine()!);

if(idade >=  18 && idade <= 67){
    Console.WriteLine("Você pode ser doador de sangue");
}
else{
    Console.WriteLine("Você não pode ser doador de sangue");
}



