using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;


namespace ProjCryptoSJ
{
    // Classe permettant de chiffrer et de déchiffrer des chaînes de caractères en utilisant l'algorithme de chiffrement TripleDES (3DES)
    class DotNET
    {
        // Champ privé représentant le texte à chiffrer ou à déchiffrer
        private string _cryptText;

        // Propriété publique permettant d'accéder et de modifier la valeur du champ _cryptText
        public string CryptText
        {
            get { return _cryptText; }
            set { _cryptText = value; }
        }

        // Constructeur prenant en argument une chaîne de caractères (Text) et l'assignant à la propriété CryptText
        public DotNET(string Text)
        {
            CryptText = Text;
        }

        // Méthode publique permettant de chiffrer un texte en utilisant l'algorithme 3DES
        // Prend en arguments les tableaux de bytes représentant la clé de chiffrement et le vecteur d'initialisation (key et iv)
        public byte[] Crypt(byte[] key, byte[] iv)
        {
            // Conversion du texte en tableau de bytes en utilisant l'encodage par défaut
            byte[] textAsByte = Encoding.Default.GetBytes(_cryptText);

            // Création d'un objet TripleDESCryptoServiceProvider
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            // Création d'un objet permettant de chiffrer des données en utilisant l'algorithme 3DES
            var encryptor = TDES.CreateEncryptor(key, iv);

            // Chiffrement du texte en utilisant l'objet encryptor et récupération du texte chiffré sous forme de tableau de bytes
            byte[] cryptedTextAsByte = encryptor.TransformFinalBlock(textAsByte, 0, textAsByte.Length);

            // Retourne le texte chiffré sous forme de tableau de bytes
            return cryptedTextAsByte;
        }

        // Méthode publique permettant de déchiffrer un texte chiffré en utilisant l'algorithme 3DES
        // Prend en arguments le texte chiffré sous forme de tableau de bytes (cryptedTextAsByte) et les tableaux de bytes représentant la clé de chiffrement et le vecteur d'initialisation (key et iv)
        public string Decrypt(byte[] cryptedTextAsByte, byte[] key, byte[] iv)
        {
            // Création d'un objet TripleDESCryptoServiceProvider
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            // Création d'un objet permettant de déchiffrer des données en utilisant l'algorithme 3DES
            var decryptor = TDES.CreateDecryptor(key, iv);

            // Déchiffrementdu texte chiffré en utilisant l'objet decryptor et récupération du texte déchiffré sous forme de tableau de bytes

            byte[] decryptedTextAsByte = decryptor.TransformFinalBlock(cryptedTextAsByte, 0, cryptedTextAsByte.Length);

            // Conversion du texte déchiffré en chaîne de caractères en utilisant l'encodage par défaut
            return Encoding.Default.GetString(decryptedTextAsByte);
        }

    }
}