
string? resultadoLeitura;
string funcao = "";
bool entradaCorresponde = false;

do{
    Console.WriteLine("Qual a sua função: Administrador. Gerente ou Usuario");
    resultadoLeitura = Console.ReadLine();
    
    if (resultadoLeitura != null)
    {
        funcao = resultadoLeitura.Trim();
    }

    if (funcao.ToLower() == "Administrador" || funcao.ToLower() == "Gerente" || funcao.ToLower() == "Usuario" )
    {
        entradaCorresponde = true;
    }
    else
    {
        Console.WriteLine($"Desculpe, sua entrada {funcao} é incorreta.");
    }

}while(entradaCorresponde == false);

Console.WriteLine($"Sua entrada foi {funcao}");
resultadoLeitura = Console.ReadLine();
