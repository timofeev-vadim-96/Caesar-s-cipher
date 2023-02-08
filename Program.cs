char[] rusAlphabet = {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к',
                       'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц',
                       'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'А', 'Б', 'В',
                       'Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                       'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я',
                      };
System.Console.WriteLine("Введите текст, который желаете зашифровать");
string userText = Console.ReadLine();
string[] textArray = userText.Split(" ") // массив для определения длины слова
                    .ToArray();
int currentWordIndex = 0;
int n = textArray[0].Length;
char[] resultText = new char[userText.Length];
char [] CopyTextInArray (char [] inputText, string InputUserText)
{
    for (int i = 0; i < resultText.Length; i++)
    {
        resultText[i] = InputUserText[i];
    }
    return inputText;
}
CopyTextInArray(resultText, userText);
void CaesarCode(string inputText, char[] inputLanguage)
{
    for (int i = 0; i < inputText.Length; i++)
    {
        int dif = 0;
        if (inputText[i] == ' ')
        {
            currentWordIndex++;
            n = textArray[currentWordIndex].Length;
        } 
        for (int j = 0; j < inputLanguage.Length; j++)
        {
            if (inputText[i] == inputLanguage[j])
            {
                if (j + n > inputLanguage.Length)
                {
                    dif = (j + n) - inputLanguage.Length / 2;
                    resultText[i] = inputLanguage[dif];
                    continue;
                }
                else resultText[i] = inputLanguage[j + n]; continue;
            }
        }

    }
}
CaesarCode(userText, rusAlphabet);
System.Console.WriteLine(resultText);