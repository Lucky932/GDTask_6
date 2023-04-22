Console.Write("Введитет текст: ");

string somtext = Console.ReadLine();
string vollews = "ыаоэяиюуеЫАОЭЯИЮУЕ"; // Создаем массив с гласными
int con = 0;

char[] letvol =  vollews.ToCharArray(); // Разбиваем текст с гласными на отдельные символы
char[] lettext = somtext.ToCharArray(); // Разбиваем введенный текст тоже на отдельные символы

for (int i = 0; i < lettext.Length; i++)
{
    for (int j = 0; j < letvol.Length; j++)
    {
        if (lettext[i] == letvol[j])
        {
            con++; // обнаруживаем, сколько гласных в предложении
        }
    }
}

char[] result = new char[somtext.Length - con]; // создаем массив символов размер которого будет меньше на количество гласных от основного текста
int index = 0; // создаем новую переменную, которая будет индексом

foreach (char c in lettext) // создаем цикл с переменной типа символ, которая представляет массив lettext
{
    if (!(letvol.Contains(c))) // если переменная с не содержится в массиве с гласными -
    {
        result[index] = c; // -то добавляем этот символ в новый массив с символами (только согласные)
        index++;
    }
}

for  (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i]); // выводим получившийся текст
}