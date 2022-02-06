//namespace calculator;

public class CaesarCipher
{
    /// <summary>
    /// алфавмт
    /// </summary>
    const string fullAlfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    int letterQty = fullAlfabet.Length;     // Length:  Возвращает количество символов в текущей системе

    private string CodeEncode(string text)
    {
        string retVal = "";
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
                var codeIndex = (letterQty - index + 32) % letterQty;
                retVal += fullAlfabet[codeIndex];
            }
        }

        return retVal;  // символ с новым индексом
    }

    //шифрование текста
    public string Encrypt(string plainMessage)
        => CodeEncode(plainMessage);

    //дешифрование текста IСoder
    public string Decrypt(string encryptedMessage)
        => CodeEncode(encryptedMessage);
}

// Определить интерфейс IСoder, который полагает методы поддержки шифрования строк.
// В интерфейсе объявляются два метода Encode() и Decode(), используемые для шифрования и дешифрования строк.
// Создать класс ACoder, реализующий интерфейс ICoder.
// Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. (В результате такого сдвига буква А становится буквой Б).
// Создать класс BCoder, реализующий интерфейс ICoder.
// Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита.
// (Например, буква В заменяется на букву Э.
// Написать программу, демонстрирующую функционирование классов).

