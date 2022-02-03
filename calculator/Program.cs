
using System.Text;
using calculator;


var cipher = new CaesarCipher();

var message = "АаБбяЯюЮ Введите текст:";


var encryptedText = cipher.Encrypt(message);
Console.WriteLine("Зашифрованное сообщение: {0}", encryptedText);
Console.WriteLine("Расшифрованное сообщение: {0}", cipher.Decrypt(encryptedText));
Console.ReadLine();