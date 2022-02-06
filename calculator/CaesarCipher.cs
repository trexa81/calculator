
public class CaesarCipher
{
    /// <summary>
    /// алфавмт
    /// </summary>
    const string fullAlfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    int letterQty = fullAlfabet.Length;     // Length:  Возвращает количество символов в текущей системе
    

    private string ACoder(string text, int k = (-1))
    {
        string retVal1 = "";
        for (int i = 0; i < text.Length; i++)
        {
            var c = text[i];   // преобразует текст в массив чар
            var index = fullAlfabet.IndexOf(c); // IndexOf: ипользует идех Юникода 
            if (index < 0)
            {
                //если символ не найден, то добавляем его в неизменном виде
                retVal1 += c.ToString();
            }
            else
            {
                var codeIndex = (letterQty + index + k) % letterQty;
                retVal1 += fullAlfabet[codeIndex];
            }
        }

        return retVal1;
    }

    private string BCoder(string text)
    {
        string retVal2 = "";
        for (int i = 0; i < text.Length; i++)
        {
            var c = text[i];   // преобразует текст в массив чар
            var index = fullAlfabet.IndexOf(c); // IndexOf: ипользует идех Юникода 
            if (index < 0)
            {
                //если символ не найден, то добавляем его в неизменном виде
                retVal2 += c.ToString();
            }
            else
            {
                var codeIndex = (letterQty - index + 32) % letterQty;
                retVal2 += fullAlfabet[codeIndex];
            }
        }

        return retVal2;  // символ с новым индексом
    }

    public string AEncrypt(string plainMessage, int key)
        => ACoder(plainMessage, key);

    //дешифрование текста IСoder
    public string ADecrypt(string encryptedMessage, int Key)
        => ACoder(encryptedMessage, -Key);

    //шифрование текста
    public string BEncrypt(string plainMessage)
        => BCoder(plainMessage);

    //дешифрование текста IСoder
    public string BDecrypt(string encryptedMessage)
        => BCoder(encryptedMessage);
}

