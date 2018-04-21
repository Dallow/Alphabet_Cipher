	﻿using System;

	namespace Alphabet_Cipher
	{
		class MainClass
		{
			public static void Main (string[] args)
			{
				if (args.Length < 3) {
					Console.Write("-- This program requires 3 arguments (mode, message and key) --");
					return;
				}

				string key = args[1];
				string mes = args[2];

				switch (args[0]) {
				case "-e":
					for (int i = 0; i < mes.Length; i++) {
						Console.Write(EncryptChar(mes[i], key[i % key.Length]));
					}
					break;
				case "-d":
					for (int i = 0; i < mes.Length; i++) {
						Console.Write(DecryptChar(mes[i], key[i % key.Length]));
					}
					break;
				default:
					Console.Write("-- No correct argument given. Type -e to encrypt and -d to decrypt --");
					break;
				}
			}

			static char EncryptChar(char m, char k)
			{
				int c = (m + k - 12) % 26; 			// ('a' + 'a') % 26 = 12
				return (char) (c + 'a');
			}

			static char DecryptChar(char e, char k)
			{
				int i = e - k;
				if (i < 0)
					i += 26;
				return (char)(i + 'a');
			}
		}
	}
