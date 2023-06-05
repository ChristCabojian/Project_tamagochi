using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamaGochi_christ
{
    public partial class frm_tamagochi : Form
    {
        private bool _message = true;               // private bool aagemaakt
        private int _score;                         // private int aagemaakt
        private bool _statusscore = false;          // private bool aagemaakt

        public frm_tamagochi()
        {
            InitializeComponent();
        }


        private void btnEten_Click(object sender, EventArgs e)
        {
            try                                         // probeert deze code en als het niet lukt geeft ie een foutmelding
            {
                barFood.Value = barFood.Value + 5;          // de code als je op de knop drinken drukt dat er +5 bij komt in de bar van eten
            }
            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);             // foutmelding
            }
        }

        private void btnDrinken_Click(object sender, EventArgs e)
        {
            try                                     // probeert deze code en als het niet lukt geeft ie een foutmelding
            {
                barDrinken.Value = barDrinken.Value + 5;        // de code als je op de knop drinken drukt dat er +5 bij komt in de bar van drinken
            }
            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);             // foutmelding
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barDrinken.Increment(-1);                                    // als er niet op een knop wordt gedrukt gaat er -1 af van de bar drinken
            barFood.Increment(-1);                                      // als er niet op een knop wordt gedrukt gaat er -1 af van de bar eten

            if (barFood.Value < 1 || barDrinken.Value < 1)
            {
                barGezondheid.Increment(-1);                                    // als beiden bars op zijn gaat er -1 af van de bar gezondheid
            }

            if (barGezondheid.Value > 75)                                       // als de bar gezondheid boven de 75 is komt de volgende afbeelding in beeld
            {
                pbFoto.Image = Properties.Resources.Happy;
                pbFoto.Refresh();
            }
            else if (barGezondheid.Value < 75 && barGezondheid.Value > 50)      // als de bar gezondheid onder de 75 is en boven de 50 komt de volgende afbeelding in beeld
            {
                pbFoto.Image = Properties.Resources.mid;
                pbFoto.Refresh();
            }
            else if (barGezondheid.Value < 50 && barGezondheid.Value > 25)      // als de bar gezondheid onder de 50 is en boven de 25 komt de volgende afbeelding in beeld
            {
                pbFoto.Image = Properties.Resources.sad;
                pbFoto.Refresh();
            }
            else if (barGezondheid.Value < 25 && barGezondheid.Value > 1)       // als de bar gezondheid onder de 25 is en boven 1 komt de volgende afbeelding in beeld
            {
                pbFoto.Image = Properties.Resources.very_sad;
                pbFoto.Refresh();
            }
            else if (barGezondheid.Value == 0)                                  // als de bar gezondheid boven op 0 is komt de volgende afbeelding in beeld
            {
                pbFoto.Image = Properties.Resources.dead;
                _statusscore = true;
                if (_message)

                {
                    _message = false;
                    MessageBox.Show("je score is:" + _score);                 // print score in beeld    
                    Application.Exit();

                }
                pbFoto.Refresh();
            }

            if (_statusscore != true)
            {
                lblScore.Text = _score++.ToString();        // zorgt dat de score omhoog gaat als je nog niet af bent
            }
        }

        private void frm_tamagochi_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
