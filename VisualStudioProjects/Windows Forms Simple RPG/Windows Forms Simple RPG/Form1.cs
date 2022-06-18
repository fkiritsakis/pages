using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Windows_Forms_Simple_RPG.Scripts;

namespace Windows_Forms_Simple_RPG
{
    public partial class Form1 : Form
    {
        //Creating and Initializing the player Entity
        Player player = new Player();

        //Creating the first enemy
        Enemy enemy = new Enemy();

        //Creating a local for Enemy Types
        EnemyTypes enemyTypes = new EnemyTypes();
        
        string messageText = "The Save button should save the game in a txt file and say 'Game Saved'.";

        public Form1()
        {
            InitializeComponent();

            //Setting the message text label to nothing so it is clear on game start
            clearMessages();

            //Setting All the labels and texts to show the correct stats
            //Player Stat Display
            txt_PlayerHP.Text = player.getHealth().ToString();
            txt_PlayerStrength.Text = player.getStrength().ToString();
            txt_PlayerDefense.Text = player.getDefense().ToString();

            //Enemy Stat Display
            txt_EnemyName.Text = enemy.getName();
            txt_EnemyHP.Text = enemy.getHealth().ToString();
            txt_EnemyStrength.Text = enemy.getStrength().ToString();
            txt_EnemyDefense.Text = enemy.getDefense().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TBD Display messages according to what is happeining in the game
            MessagesText.Text = messageText;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            generateEnemy();
            UpdateDisplay();
            MessagesText.Text = "A new Enemy has been generated with the stats: \nName: " + enemy.getName() + "\nHealth: " + enemy.getHealth().ToString() + "\nStrength: " + enemy.getStrength().ToString() + "\nDefense: " + enemy.getDefense().ToString();
            
        }

        //Clear the Message Box
        private void clearMessages() 
        {
            MessagesText.Text = " ";
        }

        private void generateEnemy() 
        {
            // Setting the enemy to a generated new one
            enemy = enemyTypes.getEnemy();
        }


        //Update The Stat displays
        public void UpdateDisplay()
        {
            //Player Stat Display
            txt_PlayerHP.Text = player.getHealth().ToString();
            txt_PlayerStrength.Text = player.getStrength().ToString();
            txt_PlayerDefense.Text = player.getDefense().ToString();

            //Enemy Stat Display
            txt_EnemyName.Text = enemy.getName();
            txt_EnemyHP.Text = enemy.getHealth().ToString();
            txt_EnemyStrength.Text = enemy.getStrength().ToString();
            txt_EnemyDefense.Text = enemy.getDefense().ToString();
        }

        
    }
}
