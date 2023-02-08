char [] rusAlphabet = {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к',
                       'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц',
                       'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'А', 'Б', 'В',
                       'Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                       'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я',
                      };
// string usAlphabet = "abcdefghijklmnopqrstuvwxyz";
System.Console.WriteLine("Введите текст, который желаете зашифровать");
string userText = Convert.ToString(Console.ReadLine());
int n = 3;
char [] resultText = new char [userText.Length];
void CaesarCode (string inputText, char [] inputLanguage)
{
    for (int i = 0; i < inputText.Length; i++)
    {
        int dif = 0;
        int indexInLang = 0;
        for (int j = 0; j < inputLanguage.Length; j++)
        {
            if (inputText[i] == inputLanguage[j]) 
            {
                indexInLang = j; 
                if (j+n > inputLanguage.Length/2)
                {
                    dif = (j+n) - inputLanguage.Length/2;
                    resultText[i] = inputLanguage[dif];
                }
                else resultText[i] = inputLanguage[j+n];
            }
        }
    }
}
CaesarCode (userText, rusAlphabet);
System.Console.WriteLine(resultText);