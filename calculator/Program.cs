

var key = 1;  // позиция сдвига
var cipher = new CaesarCipher();
var message = "АаБбяЯюЮ Введите текст:";
var encryptedText = cipher.AEncrypt(message, key);
Console.WriteLine("Зашифрованное сообщение A: {0}", encryptedText);
Console.WriteLine("Расшифрованное сообщение: {0}", cipher.ADecrypt(encryptedText, key));

encryptedText = cipher.BEncrypt(message);
Console.WriteLine("Зашифрованное сообщение B: {0}", encryptedText);
Console.WriteLine("Расшифрованное сообщение: {0}", cipher.BDecrypt(encryptedText));
Console.ReadLine();