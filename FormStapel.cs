using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerStapel
{
    public class FormStapel : Form
    {
        //IntegerStapel stapel = new IntegerStapel();   // Gebruik één van beide stapels
        IntegerListStapel stapel = new IntegerListStapel();
        bool gebruikerWijzigt = true;       // Wordt false als het programma zelf de waarde van udVoegToe wijzigt

        public FormStapel()
        {
            InitializeComponent();
        }

        private void udVoegToe_ValueChanged(object sender, EventArgs e)
        {
            if (gebruikerWijzigt)  // Alleen als de gebruiker de waarde heeft gewijzigd
            {
                stapel.OpStapel(Convert.ToInt32(udVoegToe.Value));
                tbShowContent.Text = stapel.ToString(); // niet in opgave:  Wel als controle
            }
        }

        private void btHaalAf_Click(object sender, EventArgs e)
        {
            gebruikerWijzigt = false;   // Deze methode zal zelf de waarde van udVoegToe wijzigen!
            int? result = stapel.VanStapel();  
            if (!result.HasValue)   // result == NULL => stapel is leeg
                MessageBox.Show("De stapel is leeg");
            else 
                udVoegToe.Value = result.Value;
            tbShowContent.Text = stapel.ToString();   // niet in opgave:  Wel als controle
            gebruikerWijzigt = true; // methode zal waarden upVoegToe niet meer wijzigen
        }
    }
}
