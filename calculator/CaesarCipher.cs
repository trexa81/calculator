namespace calculator;

public class CaesarCipher
{
    /// <summary>
    /// символы русской азбуки
    /// </summary>
    const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

    private string CodeEncode(string text, int k)
    {
        
        // алфавмт верхнего инижнего регистра
        var fullAlfabet = alfabet + alfabet.ToLower(); // ToLower: Возвращает копию этой строки, преобразованную в нижний регистр
        var letterQty = fullAlfabet.Length;     // Length:  Возвращает количество символов в текущей системе
        var retVal = "";
        for (int i = 0; i < text.Length; i++)
        {
            var c = text[i];   // преобразует текст в массив чар
            var index = fullAlfabet.IndexOf(c); // IndexOf: ипользует идех Юникода 
            if (index < 0)
            {
                //если символ не найден, то добавляем его в неизменном виде
                retVal += c.ToString();
            }
            else
            {
                var codeIndex = (letterQty + index + k) % letterQty;
                retVal += fullAlfabet[codeIndex];
            }
        }

        return retVal;  // символ с новым индексом
    }

    //шифрование текста
    public string Encrypt(string plainMessage, int key)
        => CodeEncode(plainMessage, key);

    //дешифрование текста
    public string Decrypt(string encryptedMessage, int key)
        => CodeEncode(encryptedMessage, -key);
}