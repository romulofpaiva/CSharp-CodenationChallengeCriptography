using System;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        static string strAlfabeto = "abcdefghijklmnopqrstuvwxyz";
        static char[] arrAlfabeto = strAlfabeto.ToCharArray();

        public string Crypt(string message)
        {
            if(message == null)
                throw new ArgumentNullException();

            if(message == System.String.Empty)
                return "";

            string cryptedMessage = "";
            char[] arrMessage = message.ToLower().ToCharArray();
            int indexOrigem = 0;
            int indexDestino = 0;
            foreach (var item in arrMessage)
            {
                if(item >= 'a' && item <= 'z') {
                    indexOrigem = strAlfabeto.IndexOf(item);
                    indexDestino = indexOrigem + 3;
                    if(indexDestino > 25)
                        indexDestino -= 26;

                    cryptedMessage += arrAlfabeto[indexDestino];
                }
                else if (item == ' ' || (item >= '0' && item <= '9'))
                    cryptedMessage += item;
                else
                    throw new ArgumentOutOfRangeException();
            }

            return cryptedMessage;
        }

        public string Decrypt(string cryptedMessage)
        {
            if(cryptedMessage == null)
                throw new ArgumentNullException();

            if(cryptedMessage == System.String.Empty)
                return "";

            string decryptedMessage = "";
            char[] arrMessage = cryptedMessage.ToLower().ToCharArray();
            int indexOrigem = 0;
            int indexDestino = 0;
            foreach (var item in arrMessage)
            {
                if(item >= 'a' && item <= 'z') {
                    indexOrigem = strAlfabeto.IndexOf(item);
                    indexDestino = indexOrigem - 3;
                    if(indexDestino < 0)
                        indexDestino += 26;

                    decryptedMessage += arrAlfabeto[indexDestino];
                }
                else if(item == ' ' || (item >= '0' && item <= '9'))
                    decryptedMessage += item;
                else
                    throw new ArgumentOutOfRangeException();
            }

            return decryptedMessage;
        }
    }
}