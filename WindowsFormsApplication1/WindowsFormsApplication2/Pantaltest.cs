using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using MaterialSkin;
/*Implementacion de BlowFishCS*/
using BlowFishCS;
using MaterialSkin.Controls;
namespace WindowsFormsApplication2
{
    public partial class Pantaltest : MaterialForm
    {
        public Pantaltest()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green800, Primary.Green900,
                Primary.Green500, Accent.LightBlue400,
                TextShade.WHITE
            );
            
            
        }

        private void Pantaltest_Load(object sender, EventArgs e)
        {
            /*Crear */
            BlowFish b = new BlowFish("04B915BA43FEB5B6");

          string plainText = "The quick brown fox jumped over the lazy dog.";
            string cipherText = b.Encrypt_CBC(plainText);
            MessageBox.Show(cipherText);

          
              plainText = b.Decrypt_CBC(cipherText);
              MessageBox.Show(plainText);
        }
    }
}
