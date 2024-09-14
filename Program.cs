class Program
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento(5.00m, 2.00m);

        estacionamento.AdicionarVeiculo("ABC-1234");
        estacionamento.AdicionarVeiculo("XYZ-5678");

        estacionamento.ListarVeiculos();

        estacionamento.RemoverVeiculo("ABC-1234", 3);

        estacionamento.ListarVeiculos();
    }
}

























//using projetoteste.models;

//int numero =10;
//int cont=1;
//int x=0;

//Console.WriteLine("com enquanto ");

//while(cont<=10){
//  x=numero*cont;
//  Console.WriteLine( $"{numero} x {cont} = {x}");
//  cont++;
//
//  
//}
//cont=1;
//x=0;
//numero =10;
//Console.WriteLine("com para ");

//for(cont = 0; cont<10;){
///    x=numero*cont;
//     Console.WriteLine( $"{numero} x {cont} = {x}");
//     cont++;
//   
//}

///int soma =0; int numero =0;

//do
//{
//  Console.WriteLine("Digite um numero //0 para parar ");
//  numero= Convert.ToInt32(Console.ReadLine());
  
//  soma+=numero;
//}while(numero !=0);

//Console.WriteLine(soma);


//int quantidadeEmEstoque = 3;
//int quantidadeCompra = 0;
//bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

//Console.WriteLine("Quantidade de compras: "+quantidadeCompra);
//Console.WriteLine("Quantidade de estoque: "+quantidadeEmEstoque);
//Console.WriteLine("é possivel realizar a venda ? "+possivelVenda);
//if (quantidadeCompra == 0){
 // Console.WriteLine("venda nao realizada");
  
  
//}
//else if (possivelVenda)
//{
 //Console.WriteLine("Venda Realizada...");
//}

//else
//{
 // Console.WriteLine("Desculpinha nao temos a quantidade suficiente em nosso estoque....");
//}



