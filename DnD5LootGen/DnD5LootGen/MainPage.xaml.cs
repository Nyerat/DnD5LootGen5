using Plugin.SimpleAudioPlayer.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;
using System.IO;

namespace DnD5LootGen
{

    public partial class MainPage : ContentPage
    {
        



        public MainPage()
        {
            InitializeComponent();
            //This sets up all of the click events for all of the buttons on the generator
            cityButton.Clicked += EnvironmentButtonClick;
            dungeonButton.Clicked += EnvironmentButtonClick;
            forestButton.Clicked += EnvironmentButtonClick;
            waterButton.Clicked += EnvironmentButtonClick;
            netherButton.Clicked += EnvironmentButtonClick;
            miscButton.Clicked += EnvironmentButtonClick;

            Humanoids.Clicked += EnemyButtonClick;
            Beasts.Clicked += EnemyButtonClick;
            Demons.Clicked += EnemyButtonClick;
            Celestials.Clicked += EnemyButtonClick;
            Fey.Clicked += EnemyButtonClick;
            Undead.Clicked += EnemyButtonClick;
            Constructs.Clicked += EnemyButtonClick;
            Plants.Clicked += EnemyButtonClick;
            Nether.Clicked += EnemyButtonClick;
            Elementals.Clicked += EnemyButtonClick;
            Treasure.Clicked += EnemyButtonClick;
            Misc.Clicked += EnemyButtonClick;

            bossOption.Clicked += OptionButtonClick;
            questOption.Clicked += OptionButtonClick;
            magicalOption.Clicked += OptionButtonClick;
            potionOption.Clicked += OptionButtonClick;
            equipmentOption.Clicked += OptionButtonClick;
            matsOption.Clicked += OptionButtonClick;
            lockOption.Clicked += OptionButtonClick;

            rollButton.Clicked += Roll;

            clearButton.Clicked += ClearEvent;




        }


        ItemClass itemlist = new ItemClass();


        //Here is where the audio player is created, the audio files can be found in the Solution Explorer
        ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
        string environmentChoice;
        List<string> enemy = new List<string>();
        List<string> option = new List<string>();
        //List<string> treasureList = new List<string>();
        //Nullable<int> 


        //Here are all of the buttons for the Environmental portion of the page
        void EnvironmentButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;



            switch (button.Text)
            {
                case "City":
                    environmentChoice = "City";
                    cityButton.FontSize = 46;
                    EnvrionmentGrid.Opacity = 0.6;
                    EnvironmentFocus();
                    player.Load(GetStreamFromFile("Town.mp3"));
                    player.Play();



                    break;
                case "Dungeon":
                    environmentChoice = "Dungeon";
                    dungeonButton.FontSize = 30;
                    EnvrionmentGrid.Opacity = 0.6;
                    EnvironmentFocus();
                    player.Load(GetStreamFromFile("Creepy Dungeon Ambience Sound  Non Copyrighted Sound Effects.mp3"));
                    player.Play();


                    break;
                case "Forest":
                    environmentChoice = "Forest";
                    forestButton.FontSize = 46;
                    EnvrionmentGrid.Opacity = 0.6;
                    EnvironmentFocus();
                    player.Load(GetStreamFromFile("Jungle Sound Effect.mp3"));
                    player.Play();


                    break;
                case "Aquatic":
                    environmentChoice = "Aquatic";
                    waterButton.FontSize = 46;
                    EnvrionmentGrid.Opacity = 0.6;
                    EnvironmentFocus();
                    player.Load(GetStreamFromFile("Aquatic Sound 01.mp3"));
                    player.Play();


                    break;
                case "Nether":
                    environmentChoice = "Nether";
                    netherButton.FontSize = 46;
                    EnvrionmentGrid.Opacity = 0.6;
                    EnvironmentFocus();
                    player.Load(GetStreamFromFile("Decrepify.mp3"));
                    player.Play();


                    break;
                case "Misc":
                    environmentChoice = "Misc";
                    miscButton.FontSize = 46;
                    EnvrionmentGrid.Opacity = 0.6;
                    EnvironmentFocus();
                    player.Load(GetStreamFromFile("CURSOL_SELECT.wav.mp3"));
                    player.Play();


                    break;
            }

        }

        //Here are all of the buttons for the Enemy portion of the page
        void EnemyButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "Humanoids":
                    if (Humanoids.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Humanoids");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Humanoids.BackgroundColor = Color.LightGreen;
                    }
                    else if (Humanoids.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Humanoids");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Humanoids.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Beasts":
                    if (Beasts.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Beasts");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Beasts.BackgroundColor = Color.LightGreen;
                    }
                    else if (Beasts.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Beasts");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Beasts.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Demons":
                    if (Demons.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Demons");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Demons.BackgroundColor = Color.LightGreen;
                    }
                    else if (Demons.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Demons");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Demons.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Celestials":
                    if (Celestials.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Celestials");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Celestials.BackgroundColor = Color.LightGreen;
                    }
                    else if (Celestials.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Celestials");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Celestials.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Fey":
                    if (Fey.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Fey");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Fey.BackgroundColor = Color.LightGreen;
                    }
                    else if (Fey.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Fey");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Fey.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Undead":
                    if (Undead.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Undead");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Undead.BackgroundColor = Color.LightGreen;
                    }
                    else if (Undead.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Undead");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Undead.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Elementals":
                    if (Elementals.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Elementals");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Elementals.BackgroundColor = Color.LightGreen;
                    }
                    else if (Elementals.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Elementals");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Elementals.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Constructs":
                    if (Constructs.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Constructs");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Constructs.BackgroundColor = Color.LightGreen;
                    }
                    else if (Constructs.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Constructs");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Constructs.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Plants":
                    if (Plants.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Plants");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Plants.BackgroundColor = Color.LightGreen;
                    }
                    else if (Plants.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Plants");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Plants.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Nether":
                    if (Nether.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Nether");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Nether.BackgroundColor = Color.LightGreen;
                    }
                    else if (Nether.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Nether");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Nether.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Treasure":
                    if (Treasure.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Treasure");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Treasure.BackgroundColor = Color.LightGreen;
                    }
                    else if (Treasure.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Treasure");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Treasure.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Misc":
                    if (Misc.BackgroundColor == Color.Salmon)
                    {
                        enemy.Add("Misc");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        Misc.BackgroundColor = Color.LightGreen;
                    }
                    else if (Misc.BackgroundColor == Color.LightGreen)
                    {
                        enemy.Remove("Misc");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        Misc.BackgroundColor = Color.Salmon;
                    }
                    break;
            }
        }

        //Here are all of the buttons for the Optional portion of the page
        void OptionButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "Boss Encounter":
                    if (bossOption.BackgroundColor == Color.Salmon)
                    {
                        option.Add("Boss Encounter");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        bossOption.BackgroundColor = Color.LightGreen;
                    }
                    else if (bossOption.BackgroundColor == Color.LightGreen)
                    {
                        option.Remove("Boss Encounter");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        bossOption.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Quest Items":
                    if (questOption.BackgroundColor == Color.Salmon)
                    {
                        option.Add("Quest Items");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        questOption.BackgroundColor = Color.LightGreen;
                    }
                    else if (questOption.BackgroundColor == Color.LightGreen)
                    {
                        option.Remove("Quest Items");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        questOption.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Magical Items":
                    if (magicalOption.BackgroundColor == Color.Salmon)
                    {
                        option.Add("Magical Items");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        magicalOption.BackgroundColor = Color.LightGreen;
                    }
                    else if (magicalOption.BackgroundColor == Color.LightGreen)
                    {
                        option.Remove("Magical Items");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        magicalOption.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Potions":
                    if (potionOption.BackgroundColor == Color.Salmon)
                    {
                        option.Add("Potions");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        potionOption.BackgroundColor = Color.LightGreen;
                    }
                    else if (potionOption.BackgroundColor == Color.LightGreen)
                    {
                        option.Remove("Potions");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        potionOption.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Old Equipment":
                    if (equipmentOption.BackgroundColor == Color.Salmon)
                    {
                        option.Add("Old Equipment");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        equipmentOption.BackgroundColor = Color.LightGreen;
                    }
                    else if (equipmentOption.BackgroundColor == Color.LightGreen)
                    {
                        option.Remove("Old Equipment");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        equipmentOption.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Materials":
                    if (matsOption.BackgroundColor == Color.Salmon)
                    {
                        option.Add("Materials");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        matsOption.BackgroundColor = Color.LightGreen;
                    }
                    else if (matsOption.BackgroundColor == Color.LightGreen)
                    {
                        option.Remove("Materials");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        matsOption.BackgroundColor = Color.Salmon;
                    }
                    break;
                case "Lockboxes":
                    if (lockOption.BackgroundColor == Color.Salmon)
                    {
                        option.Add("Lockboxes");
                        player.Load(GetStreamFromFile("CURSOL_OK.wav.mp3"));
                        player.Play();
                        lockOption.BackgroundColor = Color.LightGreen;
                    }
                    else if (lockOption.BackgroundColor == Color.LightGreen)
                    {
                        option.Remove("Lockboxes");
                        player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
                        player.Play();
                        lockOption.BackgroundColor = Color.Salmon;
                    }
                    break;
            }
        }

        //This method rolls a random number number, and applies a treasure ratio to decide which type of loot is given, certain loot is given higher priority based on rarity
        void Roll(object sender, EventArgs e)
        {

            LootResults.Text = "";


            int challenge = challengeRating.SelectedIndex;
            int ratio = treasureRatio.SelectedIndex;
            int randomInt;
            int BroadRNG;
            int FinesseRNG;
            int result = 0;
            List<string> rewards = new List<string>();
            Nullable<int> gold = null;
            Nullable<int> silver = null;
            Nullable<int> copper = null;
            Nullable<double> currencyAmount = null;
            Nullable<double> treasureAmount = null;

            Random rng = new Random();
            int treasureRating = rng.Next(-3, 4) + challenge;

            
            if (ratio == 4 || ratio == 3 || ratio == 2 || ratio == 1 || ratio == 0)
            {
                gold = 0;
                silver = 0;
                copper = 0;
                currencyAmount = 0;
                treasureAmount = 0;
                if (ratio == 4)
                {
                    currencyAmount = treasureRating;
                }
                if (ratio == 3)
                {
                    treasureAmount = treasureRating / 3;
                    currencyAmount += (treasureRating / 3) * 2;
                }
                if (ratio == 2)
                {
                    treasureAmount = treasureRating / 2;
                    currencyAmount += treasureRating / 2;
                }
                if (ratio == 1)
                {
                    treasureAmount = (treasureRating / 3) * 2;
                    currencyAmount += treasureRating / 3;
                }
                if (ratio == 0)
                {
                    treasureAmount = treasureRating;
                }








                Math.Round((double)treasureAmount);
                Math.Round((double)currencyAmount);
                if (currencyAmount != 0)
                {

                    for (int amount = 0; amount < currencyAmount; amount++)
                    {
                        randomInt = rng.Next(1, 6);
                        switch (randomInt)
                        {
                            case 1:
                                gold += rng.Next(4, 14);
                                break;
                            case 2:
                                silver += rng.Next(40, 140);
                                break;
                            case 3:
                                copper += rng.Next(40, 140);
                                break;
                            case 4:
                                gold += rng.Next(8, 25);
                                break;
                            case 5:
                                silver += rng.Next(120, 290);
                                break;
                        }
                    }
                }
                while (treasureAmount > 0)
                {
                    BroadRNG = rng.Next(1, 101);
                    FinesseRNG = rng.Next(1, 51);

                    //Environment
                    //Enemies
                    //Options



                    if (BroadRNG <= 15 && BroadRNG >= 0)
                    {
                        if (environmentChoice != "Misc" && FinesseRNG >= 46 && FinesseRNG <= 50)
                            switch (FinesseRNG)
                            {
                                case 50:
                                    LootResults.Text += $"\nMassive Boon of {environmentChoice}";
                                    break;
                                case 49:
                                    LootResults.Text += $"\nMinor Boon of {environmentChoice}";
                                    break;
                                case 48:
                                    LootResults.Text += $"\nMinor Boon of {environmentChoice}";
                                    break;
                                case 47:
                                    LootResults.Text += $"\nMinor Boon of {environmentChoice}";
                                    break;
                                case 46:
                                    LootResults.Text += $"\nPrisoner of {environmentChoice}";
                                    break;
                                default:
                                    break;
                            }
                        else if (environmentChoice == "Misc" && FinesseRNG >= 46 && FinesseRNG <= 50)
                        {
                            LootResults.Text += $"\nBoon of choice from Misc.";
                        }
                        else if (FinesseRNG <= 45 && FinesseRNG >= 25)
                        {
                            LootResults.Text += $"\nTreasure related to {environmentChoice}";
                        }
                        else if (FinesseRNG <= 24 && FinesseRNG >= 0)
                        {
                            if (environmentChoice == "City")
                            {
                                if (FinesseRNG <= 16)
                                {
                                    result = rng.Next(itemlist.Weapons.Count);
                                    LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                }
                                else
                                    result = rng.Next(itemlist.Armor.Count);
                                LootResults.Text += $"\n{itemlist.Armor[result]}";
                            }
                            else if (environmentChoice == "Dungeon")
                            {
                                if (FinesseRNG <= 16)
                                {
                                    result = rng.Next(itemlist.Potions.Count);
                                    LootResults.Text += $"\n{itemlist.Potions[result]}";
                                }
                                else
                                    result = rng.Next(itemlist.Weapons.Count);
                                LootResults.Text += $"\n{itemlist.Weapons[result]}";
                            }
                            else if (environmentChoice == "Forest")
                            {
                                if (FinesseRNG <= 16)
                                {
                                    result = rng.Next(itemlist.Elven.Count);
                                    LootResults.Text += $"\n{itemlist.Elven[result]}";
                                }
                                else
                                    result = rng.Next(itemlist.Weapons.Count);
                                LootResults.Text += $"\n{itemlist.Weapons[result]}";
                            }
                            else if (environmentChoice == "Aquatic")
                            {
                                if (FinesseRNG <= 16)
                                {
                                    result = rng.Next(itemlist.Crystals.Count);
                                    LootResults.Text += $"\n{itemlist.Crystals[result]}";
                                }
                                else
                                    LootResults.Text += $"\nBarnacle encrusted chest";
                            }
                            else if (environmentChoice == $"\nNether")
                            {
                                if (FinesseRNG <= 16)
                                {
                                    result = rng.Next(itemlist.Nether.Count);
                                    LootResults.Text += $"\n{itemlist.Nether[result]}";
                                }
                                else
                                    LootResults.Text += $"\nObsidian";
                            }
                            else if (environmentChoice == "Misc")
                            {
                                LootResults.Text += $"\nBase off of situation (Misc.)";
                            }
                        }

                        treasureAmount -= 1;
                    }
                    else if (BroadRNG <= 75 && BroadRNG >= 16)
                    {
                        result = rng.Next(enemy.Count);

                        if (enemy.Count != 0)
                        {
                            switch (enemy[result])
                            {
                                case "Humanoids":
                                    if (FinesseRNG <= 30)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                    }
                                    else if (FinesseRNG <= 45)
                                    {
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Food.Count);
                                        LootResults.Text += $"\n{itemlist.Food[result]}";
                                    }
                                    break;
                                case "Beasts":
                                    if (FinesseRNG <= 45)
                                    {
                                        result = rng.Next(itemlist.Food.Count);
                                        LootResults.Text += $"\n{itemlist.Food[result]}";
                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Food.Count);
                                        LootResults.Text += $"\n{itemlist.Food[result]}";
                                        result = rng.Next(itemlist.Food.Count);
                                        LootResults.Text += $"\n{itemlist.Food[result]}";
                                    }
                                    break;
                                case "Demons":
                                    if (FinesseRNG <= 30)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                    }
                                    else if (FinesseRNG <= 48)
                                    {
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Nether.Count);
                                        LootResults.Text += $"\n{itemlist.Nether[result]}";
                                    }
                                    break;
                                case "Celestials":
                                    if (FinesseRNG <= 25)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                    }
                                    else if (FinesseRNG <= 45)
                                    {
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Crystals.Count);
                                        LootResults.Text += $"\n{itemlist.Crystals[result]}";
                                    }
                                    break;
                                case "Fey":
                                    if (FinesseRNG <= 20)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                    }
                                    else if (FinesseRNG <= 40)
                                    {
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    }
                                    else if (FinesseRNG <= 45)
                                    {
                                        result = rng.Next(itemlist.Crystals.Count);
                                        LootResults.Text += $"\n{itemlist.Crystals[result]}";
                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Elven.Count);
                                        LootResults.Text += $"\n{itemlist.Elven[result]}";
                                    }
                                    break;
                                case "Undead":
                                    if (FinesseRNG <= 25)
                                    {
                                        result = rng.Next(itemlist.OldEquipment.Count);
                                        LootResults.Text += $"\n{itemlist.OldEquipment[result]}";
                                    }
                                    else if (FinesseRNG <= 45)
                                    {
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                    }
                                    break;
                                case "Elementals":
                                    if (FinesseRNG <= 35)
                                    {
                                        result = rng.Next(itemlist.Crystals.Count);
                                        LootResults.Text += $"\n{itemlist.Crystals[result]}";
                                    }
                                    else if (FinesseRNG <= 45)
                                    {
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Materials.Count);
                                        LootResults.Text += $"\n{itemlist.Materials[result]}";
                                    }
                                    break;
                                case "Constructs":
                                    if (FinesseRNG <= 38)
                                    {
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                    }
                                    break;
                                case "Plants":
                                    result = rng.Next(itemlist.Armor.Count);
                                    LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    result = rng.Next(itemlist.Armor.Count);
                                    LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    break;
                                case "Nether":
                                    if (FinesseRNG <= 35)
                                    {
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Nether.Count);
                                        LootResults.Text += $"\n{itemlist.Nether[result]}";
                                    }
                                    break;
                                case "Treasure":
                                    if (FinesseRNG <= 10)
                                    {
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                        result = rng.Next(itemlist.Materials.Count);
                                        LootResults.Text += $"\n{itemlist.Materials[result]}";
                                        result = rng.Next(itemlist.Materials.Count);
                                        LootResults.Text += $"\n{itemlist.Materials[result]}";
                                    }
                                    else if (FinesseRNG <= 20)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                        result = rng.Next(itemlist.MagicalItems.Count);
                                        LootResults.Text += $"\n{itemlist.MagicalItems[result]}";
                                    }
                                    else if (FinesseRNG <= 30)
                                    {
                                        result = rng.Next(itemlist.Potions.Count);
                                        LootResults.Text += $"\n{itemlist.Potions[result]}";
                                        result = rng.Next(itemlist.Potions.Count);
                                        LootResults.Text += $"\n{itemlist.Potions[result]}";
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    }
                                    else if (FinesseRNG <= 40)
                                    {
                                        result = rng.Next(itemlist.Lockboxes.Count);
                                        LootResults.Text += $"\n{itemlist.Lockboxes[result]}";
                                    }
                                    else if (FinesseRNG <= 45)
                                    {
                                        result = rng.Next(itemlist.MagicalItems.Count);
                                        LootResults.Text += $"\n{itemlist.MagicalItems[result]}";
                                        result = rng.Next(itemlist.MagicalItems.Count);
                                        LootResults.Text += $"\n{itemlist.MagicalItems[result]}";

                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Nether.Count);
                                        LootResults.Text += $"\n{itemlist.Nether[result]}";
                                    }
                                    break;
                                case "Misc":
                                    if (FinesseRNG <= 2)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                    }
                                    else if (FinesseRNG <= 4)
                                    {
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    }
                                    else if (FinesseRNG <= 6)
                                    {
                                        result = rng.Next(itemlist.Food.Count);
                                        LootResults.Text += $"\n{itemlist.Food[result]}";
                                    }
                                    else if (FinesseRNG <= 8)
                                    {
                                        result = rng.Next(itemlist.OldEquipment.Count);
                                        LootResults.Text += $"\n{itemlist.OldEquipment[result]}";
                                    }
                                    else if (FinesseRNG <= 10)
                                    {
                                        result = rng.Next(itemlist.Potions.Count);
                                        LootResults.Text += $"\n{itemlist.Potions[result]}";
                                    }
                                    else if (FinesseRNG <= 12)
                                    {
                                        result = rng.Next(itemlist.Materials.Count);
                                        LootResults.Text += $"\n{itemlist.Materials[result]}";
                                    }
                                    else if (FinesseRNG <= 14)
                                    {
                                        result = rng.Next(itemlist.Lockboxes.Count);
                                        LootResults.Text += $"\n{itemlist.Lockboxes[result]}";
                                    }
                                    else if (FinesseRNG <= 16)
                                    {
                                        result = rng.Next(itemlist.QuestItems.Count);
                                        LootResults.Text += $"\n{itemlist.QuestItems[result]}";
                                    }
                                    else if (FinesseRNG <= 18)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    }
                                    else if (FinesseRNG <= 20)
                                    {
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                    }
                                    else if (FinesseRNG <= 22)
                                    {
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                    }
                                    else if (FinesseRNG <= 24)
                                    {
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                    }
                                    else if (FinesseRNG <= 26)
                                    {
                                        result = rng.Next(itemlist.Ore.Count);
                                        LootResults.Text += $"\n{itemlist.Ore[result]}";
                                        result = rng.Next(itemlist.Materials.Count);
                                        LootResults.Text += $"\n{itemlist.Materials[result]}";
                                    }
                                    else if (FinesseRNG <= 28)
                                    {
                                        LootResults.Text += $"\nFound Nothing";
                                    }
                                    else if (FinesseRNG <= 30)
                                    {
                                        LootResults.Text += $"\nFound Nothing";
                                    }
                                    else if (FinesseRNG <= 32)
                                    {
                                        LootResults.Text += $"\nFound Nothing";
                                    }
                                    else if (FinesseRNG <= 34)
                                    {
                                        LootResults.Text += $"\nFound Nothing";
                                    }
                                    else if (FinesseRNG <= 36)
                                    {
                                        LootResults.Text += $"\nFound Nothing";
                                    }
                                    else if (FinesseRNG <= 38)
                                    {
                                        LootResults.Text += $"\nFound Nothing";
                                    }
                                    else if (FinesseRNG <= 40)
                                    {
                                        LootResults.Text += $"\nFound Nothing";
                                    }
                                    else if (FinesseRNG <= 45)
                                    {
                                        result = rng.Next(itemlist.Weapons.Count);
                                        LootResults.Text += $"\n{itemlist.Weapons[result]}";

                                    }
                                    else if (FinesseRNG <= 50)
                                    {
                                        result = rng.Next(itemlist.Armor.Count);
                                        LootResults.Text += $"\n{itemlist.Armor[result]}";
                                    }
                                    break;
                                case "":

                                    break;
                                default:
                                    {
                                        
                                    }
                                    break;
                            }


                        }
                        else
                        {
                            treasureAmount += 1;
                        }
                            treasureAmount -= 1;
                        

                    }
                    else if (BroadRNG <= 100 && BroadRNG >= 76)
                    {
                        string choice;
                        result = rng.Next(option.Count);
                        if (option.Count != 0)
                        {
                            choice = option[result];

                            if (choice == "Boss Encounter")
                            {
                                result = rng.Next(itemlist.BossItems.Count);
                                LootResults.Text += $"\n{itemlist.BossItems[result]}";
                            }
                            else if (choice == "Quest Items")
                            {
                                result = rng.Next(itemlist.QuestItems.Count);
                                LootResults.Text += $"\n{itemlist.QuestItems[result]}";

                            }
                            else if (choice == "Magical Items")
                            {
                                result = rng.Next(itemlist.MagicalItems.Count);
                                LootResults.Text += $"\n{itemlist.MagicalItems[result]}";

                            }
                            else if (choice == "Potions")
                            {
                                result = rng.Next(itemlist.Potions.Count);
                                LootResults.Text += $"\n{itemlist.Potions[result]}";

                            }
                            else if (choice == "Old Equipment")
                            {
                                result = rng.Next(itemlist.OldEquipment.Count);
                                LootResults.Text += $"\n{itemlist.OldEquipment[result]}";
                                result = rng.Next(itemlist.OldEquipment.Count);
                                LootResults.Text += $"\n{itemlist.OldEquipment[result]}";

                            }
                            else if (choice == "Materials")
                            {
                                result = rng.Next(itemlist.Materials.Count);
                                LootResults.Text += $"\n{itemlist.Materials[result]}";
                                result = rng.Next(itemlist.Materials.Count);
                                LootResults.Text += $"\n{itemlist.Materials[result]}";
                                result = rng.Next(itemlist.Materials.Count);
                                LootResults.Text += $"\n{itemlist.Materials[result]}";

                            }
                            else if (choice == "Lockboxes")
                            {
                                result = rng.Next(itemlist.Lockboxes.Count);
                                LootResults.Text += $"\n{itemlist.Lockboxes[result]}";
                            }
                            else
                            {
                                treasureAmount += 2;
                            }
                        }
                        else
                        {
                            treasureAmount += 2;
                        }
                        

                            
                        
                        treasureAmount -= 2;
                    }



                }
            }
           
        
    
            
            if (gold != null)
            {
                LootResults.Text += $"\n\n\nYour currency results are: {gold} gold, {silver} silver, {copper} copper";
            }
        }

        //This will simply clear out the current entries
        void ClearEvent (object sender, EventArgs e)
        {
            

            Clear();

            player.Load(GetStreamFromFile("CURSOL_CANCEL.wav.mp3"));
            player.Play();
        }

        //This is how the audio player finds the correct file
        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("DnD5LootGen." + filename);
            
            return stream;

        }

        //These are the control values
        public void Clear()
        {
            EnvrionmentGrid.IsEnabled = true;
            EnvrionmentGrid.Opacity = 1;
            cityButton.FontSize = 24;
            dungeonButton.FontSize = 24;
            forestButton.FontSize = 24;
            waterButton.FontSize = 24;
            netherButton.FontSize = 24;
            miscButton.FontSize = 24;
            OptionGrid.IsVisible = false;
            EnemyGrid.IsVisible = false;
            Humanoids.BackgroundColor = Color.Salmon;
            Beasts.BackgroundColor = Color.Salmon;
            Demons.BackgroundColor = Color.Salmon;
            Celestials.BackgroundColor = Color.Salmon;
            Fey.BackgroundColor = Color.Salmon;
            Undead.BackgroundColor = Color.Salmon;
            Constructs.BackgroundColor = Color.Salmon;
            Plants.BackgroundColor = Color.Salmon;
            Nether.BackgroundColor = Color.Salmon;
            Elementals.BackgroundColor = Color.Salmon;
            Treasure.BackgroundColor = Color.Salmon;
            Misc.BackgroundColor = Color.Salmon;
            bossOption.BackgroundColor = Color.Salmon;
            questOption.BackgroundColor = Color.Salmon;
            magicalOption.BackgroundColor = Color.Salmon;
            potionOption.BackgroundColor = Color.Salmon;
            equipmentOption.BackgroundColor = Color.Salmon;
            matsOption.BackgroundColor = Color.Salmon;
            lockOption.BackgroundColor = Color.Salmon;

            rollButton.IsEnabled = false;

            LootResults.Text = "After selecting your options and pressing roll your results will be posted here, feel free to edit them in this box if needed.";
            enemy.Clear();
            option.Clear();
            challengeRating.SelectedIndex = 0;
            treasureRatio.SelectedIndex = 2;
        }

        
        public void EnvironmentFocus()
        {
            EnvrionmentGrid.IsEnabled = false;
            OptionGrid.IsVisible = true;
            EnemyGrid.IsVisible = true;
            rollButton.IsEnabled = true;
        }


        
    }
}
