
//using System.Text;
//using calculator;

var key = -1;
var cipher = new CaesarCipher();
var message = "АаБбяЯюЮ Введите текст:";
var encryptedText = cipher.AEncrypt(message, key);
Console.WriteLine("Зашифрованное сообщение A: {0}", encryptedText);
Console.WriteLine("Расшифрованное сообщение: {0}", cipher.ADecrypt(encryptedText, key));

encryptedText = cipher.Encrypt(message);
Console.WriteLine("Зашифрованное сообщение B: {0}", encryptedText);
Console.WriteLine("Расшифрованное сообщение: {0}", cipher.Decrypt(encryptedText));
Console.ReadLine();