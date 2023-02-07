// Программа, которая переводит введенный текст в код цезаря, смещая буквы на n значений относительно алфавита
char [] rusAlphabet = {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к',
                       'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц',
                       'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
// string usAlphabet = "abcdefghijklmnopqrstuvwxyz";
System.Console.WriteLine("Введите текст, который желаете зашифровать");
string userText = Convert.ToString(Console.ReadLine());
int n = 3;
char [] resultText = new char [userText.Length];
void CaesarCode (string inputText, char [] inputLanguage)
{
    for (int i = 0; i < inputText.Length; i++)
    {
        for (int j = 0; j < inputLanguage.Length; j++)
        {
            if (inputText[i] == inputLanguage[j]) resultText[i] = inputLanguage[j+n];
        }
    }
}
CaesarCode (userText, rusAlphabet);
System.Console.WriteLine(resultText);