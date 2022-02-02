
using System.Text;
using calculator;


var cipher = new CaesarCipher();
Console.Write("Введите текст: ");
var message = Console.ReadLine();
Console.Write("Введите ключ: ");
var secretKey = Convert.ToInt32(Console.ReadLine());
var encryptedText = cipher.Encrypt(message, secretKey);
Console.WriteLine("Зашифрованное сообщение: {0}", encryptedText);
Console.WriteLine("Расшифрованное сообщение: {0}", cipher.Decrypt(encryptedText, secretKey));
Console.ReadLine();