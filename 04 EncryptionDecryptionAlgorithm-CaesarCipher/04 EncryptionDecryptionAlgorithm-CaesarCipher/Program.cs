using System;

namespace _04_EncryptionDecryptionAlgorithm_CaesarCipher
{
    class Program
    {
		static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		static void Main(string[] args)
        {
			while(true)
			{
				Console.Clear();
				int index = 0;
				Console.WriteLine("Wybierz opcje\n1. Szyfruj tekst\n2. Deszyfruj tekst\n3.Wyjdz");
				index = ReadInt();
				switch(index)
				{

					case 1:
						{
							Console.WriteLine("Wprowadz tekst do zaszyfrowania");
							string text = Console.ReadLine();
							Console.WriteLine("Wprowadz wartosc przesuniecia w prawo");
							int offset = ReadInt();
							Console.WriteLine(Encrypt(text, offset));
							break;
						}
					case 2:
						{
							Console.WriteLine("Wprowadz zaszyfrowany tekst");
							string text = Console.ReadLine();
							Console.WriteLine("Wprowadz wartosc przesuniecia w prawo");
							int offset = ReadInt();
							Console.WriteLine(Decrypt(text, offset));
							
							break;
						}
					case 3:
						{
							return;
						}
				}
				Console.WriteLine("Wcisnij dowolny klawisz");
				Console.ReadKey();
			}
		}
		static string Encrypt(string text, int offset)
		{
			string encryptedText = "";
			text = text.ToUpper();
			for(int i = 0;i<text.Length;i++)
			{
				
				int letterPos = alphabet.IndexOf(text[i]);
				if (letterPos == -1)
				{
					encryptedText += text[i];
					continue;
				}
				int pos = letterPos + offset;
				if (pos < 0)
				{
					pos += 26;
				}
				if(pos>25)
				{
					pos -= 26;
				}
				encryptedText += alphabet[pos % alphabet.Length];
				
				
			}
			return encryptedText;
		}
		static string Decrypt(string text, int offset)
		{
			string decryptedText = "";
			text = text.ToUpper();
			for (int i = 0; i < text.Length; i++)
			{

				int letterPos = alphabet.IndexOf(text[i]);
				if (letterPos == -1)
				{
					decryptedText += text[i];
					continue;
				}
				int pos = letterPos - offset;
				if (pos < 0)
				{
					pos += 26;
				}
				if (pos > 25)
				{
					pos -= 26;
				}
				decryptedText += alphabet[pos % alphabet.Length];


			}
			return decryptedText;
		}
		static int ReadInt()
		{
			return int.Parse(Console.ReadLine());
		}
	}
}
