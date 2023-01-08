using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjCryptoSJ
{
    public partial class CryptScreen : Form
    // Écran permettant de chiffrer et de déchiffrer des chaînes de caractères en utilisant l'algorithme de chiffrement TripleDES (3DES)
    {
        // Objet permettant de chiffrer et de déchiffrer des chaînes de caractères en utilisant l'algorithme 3DES
        private DotNET dot;
        private Personal pers;

        // Tableaux de bytes représentant le texte chiffré, le vecteur d'initialisation et la clé de chiffrement
        private byte[] cryptedTextAsByte, iv, key;

        private string encrypt;

        // Constructeur initialisant les composants de l'interface utilisateur
        public CryptScreen()
        {
            InitializeComponent();
        }

        private void btnCryptPerso_Click(object sender, EventArgs e)
        {
            pers = new Personal(txtInput.Text);

            txtKey.Text = pers.Key;

            encrypt = txtOutput.Text = pers.Encrypt();

            btnDecryptPerso.Enabled = true;

        }

        private void btnDecryptPerso_Click(object sender, EventArgs e)
        {
            txtReturn.Text = pers.Decrypt(encrypt);
        }

        // Méthode exécutée lorsque l'utilisateur clique sur le bouton de chiffrement
        private void btnCryptNet_Click(object sender, EventArgs e)
        {
            // Création d'un objet TripleDESCryptoServiceProvider
            var TDES = new TripleDESCryptoServiceProvider();

            // Création d'un objet dot de la classe DotNET en lui passant en argument le texte à chiffrer (récupéré dans la zone de texte txtInput)
            dot = new DotNET(txtInput.Text);

            // Récupération du vecteur d'initialisation et de la clé de chiffrement générés par l'objet TDES
            iv = TDES.IV;
            key = TDES.Key;

            // Conversion de la clé de chiffrement en chaîne de caractères encodée en base 64 et affichage dans la zone de texte txtKey
            txtKey.Text = Convert.ToBase64String(key);

            // Chiffrement du texte en utilisant l'objet dot et récupération du texte chiffré sous forme de tableau de bytes
            cryptedTextAsByte = dot.Crypt(key, iv);

            // Conversion du texte chiffré en chaîne de caractères encodée en base 64 et affichage dans la zone de texte txtOutput
            txtOutput.Text = Convert.ToBase64String(cryptedTextAsByte);

            // Activation du bouton de déchiffrement
            btnDecryptNet.Enabled = true;
        }

        // Méthode exécutée lorsque l'utilisateur clique sur le bouton de déchiffrement
        private void btnDecryptNet_Click(object sender, EventArgs e)
        {
            // Déchiffrement du texte en utilisant l'objet dot et récupération du texte déchiffré sous forme de chaîne de caractères
            string decryptedText = dot.Decrypt(cryptedTextAsByte, key, iv);

            // Affichage du texte déchiffré dans la zone de texte txtReturn
            txtReturn.Text = decryptedText;

        }
    }
}
