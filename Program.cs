Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if( idade > 18 && idade <67){
    Console.WriteLine("Pode doar sangue");
}else{
    Console.WriteLine("Não pode doar sangue");
}
Console.WriteLine(idade);