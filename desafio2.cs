
bool valueNum = false; // deve ser criar bool para Do While
string? usuarioResp; // se cria variavel que pode ser nula
string respostaUsuario = ""; //variavel vazia se torna valor digitado pelo usuario

Console.WriteLine("Enter your role name (Administrator, Manager, or User)"); //pergunta do menu

do
{
    usuarioResp = Console.ReadLine();//varariavel de entrada feita pelo usuario
    if (usuarioResp != null)//averigua se é diferente de nulo
    {
        respostaUsuario = usuarioResp.Trim();//entra no bloco caso não seja nulo e variavel vazia se torna o valor digitado sem espaço vazios(Trim)
    }
    
    if (respostaUsuario.ToLower() == "administrator" || respostaUsuario.ToLower() == "manager" || respostaUsuario.ToLower() == "user" )// aqui ele compara a resposta do usuario com as 3 strings
    {
        valueNum = true; // caso se verdade, o loop se encerra aqui e no segundo print/Console.WriteLine sai a resposta
    }
    else
    {
        Console.WriteLine($"The role name that you entered, {respostaUsuario} is not valid.");// caso seja incorreto essa msg aparece e o loop continua
    }

}while(valueNum == false); //variavel sendo igual a falso o loop continua
Console.WriteLine($"Your input value ({respostaUsuario}) has been accepted.");// mensagem de acerto
