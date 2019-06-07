using System;
using System.Windows;
using System.Speech.Synthesis;
using System.Windows.Controls;

namespace Zadanie___wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hero hero1 = new Hero("Yoda");
        Hero hero2 = new Hero("Vader");

        string variable;
        int turnCounter = 0;
        private int hp1 = 100;
        private int hp2 = 100;
        Random rand = new Random();
        private bool winLock = false;
        SpeechSynthesizer voice = new SpeechSynthesizer();

        

        public MainWindow()
        {
            InitializeComponent();
           
            name1.Text = hero1.getName();
            name2.Text = hero2.getName();
            
            voice.SetOutputToDefaultAudioDevice();
            voice.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);

        }

        //
        //combat
        //
        private void Turn_button_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);
            if (winLock)
            {
                reset();
                turnCounter = 0;
                Turn_Button.Content = "Start";
                return;
            }else Turn_Button.Content = "Kontynuuj"; 

            turnCounter++;
            if((turnCounter % 2) == 0)
            {
                attack(hero2, hero1);
                if (hpCheck(hero1))
                {
                    winLock = true;
                    console.Items.Add(hero2.getName() + " wygrywa!!!");
                    console.Items.Add("");
                }
            }
            else
            {
                attack(hero1, hero2);
                if (hpCheck(hero2))
                {
                    winLock = true;
                    console.Items.Add(hero1.getName() + " wygrywa!!!");
                    console.Items.Add("");
                   
                }
            }
            updateHp();
        }

        //update progress bars and hp counts
        private void updateHp()
        {
            ProgressBar1.Value = hero1.getHp();
            ProgressBar2.Value = hero2.getHp();
            HPcount1.Text = hero1.getHp().ToString();
            HPcount2.Text = hero2.getHp().ToString();
        }

        //reset hp
        private void reset()
        {
            hero1.setHp(hp1);
            hero2.setHp(hp2);
            winLock = false;
            updateHp();
            Turn_Button.Content = "Start";
        }

        //win check
        private bool hpCheck(Hero hero)
        {
            if (hero.getHp() <= 0) return true;
            else return false;
        }

        //attack
        private void attack(Hero Attacker, Hero Defender)
        {
            int dmg = rand.Next(Attacker.getMinDmg(), (Attacker.getMaxDmg()+1));
            Defender.setHp(Defender.getHp() - dmg);

            console.Items.Add(turnCounter + " " + Attacker.getName() + " zadaje: " + dmg + " obrażeń " + Defender.getName());    
        }
        //
        //options
        //
        //names
        private void Bt_name1_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);

            console.Items.Add(hero1.getName() + " zmienia imię na: " + tx_name1.Text);
            hero1.setName(tx_name1.Text);
            name1.Text = hero1.getName();
            reset();
        }

        private void Bt_name2_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);

            console.Items.Add(hero2.getName() + " zmienia imię na: " + tx_name2.Text);
            hero2.setName(tx_name2.Text);
            name2.Text = hero2.getName();
            reset();
        }

        //hp
        private void Bt_hp1_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);
            hp1 = int.Parse(tx_hp1.Text);
            hero1.setHp(hp1);
            console.Items.Add(hero1.getName() + " zmiania hp na: " + hp1);
            ProgressBar1.Maximum = hp1;
            ProgressBar1.Value = hp1;
            HPcount1.Text = hp1.ToString();
            reset();
        }

        private void Bt_hp2_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);

            hp2 = int.Parse(tx_hp2.Text);
            hero1.setHp(hp2);
            console.Items.Add(hero2.getName() + " zmiania hp na: " + hp2);
            ProgressBar2.Maximum = hp2;
            ProgressBar2.Value = hp2;
            HPcount2.Text = hp2.ToString();
            reset();
        }

        //minDmg
        private void Bt_minDmg1_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);

            variable = hero1.getMinDmg().ToString();
            hero1.setMinDmg(int.Parse(tx_minDmg1.Text));
            console.Items.Add(hero1.getName() + " zmiania mininmalny atak z: " + variable + " na: " + hero1.getMinDmg());
            reset();
        }
        
        private void Bt_minDmg2_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);

            variable = hero2.getMinDmg().ToString();
            hero2.setMinDmg(int.Parse(tx_minDmg2.Text));
            console.Items.Add(hero2.getName() + " zmiania minimalny atak z: " + variable + " na: " + hero2.getMinDmg());
            reset();
        }

        //maxDmg
        private void Bt_maxDmg1_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);

            variable = hero1.getMaxDmg().ToString();
            hero1.setMaxDmg(int.Parse(tx_maxDmg1.Text));
            console.Items.Add(hero1.getName() + " zmienia maksymalny atak z: " + variable + " na: " + hero1.getMaxDmg());
            reset();
        }

        private void Bt_maxDmg2_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);

            variable = hero2.getMaxDmg().ToString();
            hero2.setMaxDmg(int.Parse(tx_maxDmg2.Text));
            console.Items.Add(hero2.getName() + " zmienia maksymalny atak z: " + variable + " na: " + hero2.getMaxDmg());
            reset();
        }

        //stats button
        private void Bt_stat_Click(object sender, RoutedEventArgs e)
        {
            VoiceGenerator(sender);
            console.Items.Add("Bohater 1: " + hero1.getName() + " minimalny atak: " + hero1.getMinDmg() + " maksymalny atak: " + hero1.getMaxDmg() + " aktualne HP: " + hero1.getHp() + "pełne HP: " + hp1);
            console.Items.Add("Bohater 2: " + hero2.getName() + " minimalny atak: " + hero2.getMinDmg() + " maksymalny atak: " + hero2.getMaxDmg() + " aktualne HP: " + hero2.getHp() + "pełne HP: " + hp2);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void VoiceGenerator(object sender)
        {
            string s = (sender as Button).Content.ToString();
            voice.Speak(s);

        }
        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            console.Items.Clear();
        }
    }

}
