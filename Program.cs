char caracter;
caracter = 'a';
caracter = 'e';
caracter = 'i';
caracter = 'o';
caracter = 'u';
do
{
    Console.Write("INGRESE UN CARACTER: ");
    caracter = char.Parse(Console.ReadLine());
}
while (caracter != 'a' && caracter != 'e' && caracter != 'i' && caracter != 'o' && caracter != 'u'&&
caracter != 'A' && caracter != 'E' && caracter != 'I' && caracter != 'O' && caracter != 'U');
 Console.Write("LA PRIMERA VOCAL ES: : "+ caracter);
