using System;
using System.Collections.Generic;
using System.Text;

namespace DnD5LootGen
{
    class ItemClass
    {
        //The list of items availiable to acquire, the Roll method pulls from multuple lists to decide the given loot
        public List<string> Weapons { get; set; } = new List<string>() { "Shortsword", "Longsword", "Spear", "Hatchet", "Battleaxe", "Dagger", "Partizan", "Sling", "Longbow", "Shortbow", "Hand Crossbow", "Heavy Crossbow", "Flail", "Glaive", "Halbred", "Lance", "Maul", "Morningstar", "Rapier", "Scimitar", "Warhammer", "Net" }; //Humanoids, Demons, Celestials, Fey, Undead, Treasure, Misc
        public List<string> Armor { get; set; } = new List<string>() { "Padded Armor", "Leather Armor", "Studded Leather", "Hide Armor", "Chain Shirt", "Scale Mail", "Breastplate", "Half Plate", "Ring Mail", "Chain Mail", "Splint Armor", "Plate Armor", "Round Shield", "Kite Shield"};  //Humanoids, Demons, Celestials, Fey, Undead, Treasure, Plants, Misc
        public List<string> Food { get; set; } = new List<string>() { "Mystery Meat", "Spoiled Meat", "Good Meat", "Spoiled Meat", "Good Meat", "Spoiled Meat", "Good Meat", "Fine Meat", "Great Meat"}; //Beasts
        public List<string> Crystals { get; set; } = new List<string>() { "Nail-sized fragment", "Nail-sized fragment", "Nail-sized fragment", "Nail-sized fragment", "Nail-sized fragment", "Nail-sized fragment", "Nail-sized fragment", "Nail-sized fragment", "Finger-sized shard", "Finger-sized shard", "Finger-sized shard", "Finger-sized shard", "Palm-sized crystal", "Palm-sized crystal", "Head-sized chunk", "Lighting Crystal", "Fire Crystal", "Ice Crystal", "Dark Crystal", "Light Crystal"}; //Demons, Elementals, Constructs, Treasure, Misc
        public List<string> Elven { get; set; } = new List<string>() { "Elven Ration", "Elven Ration", "Elven Ration", "Elven Bow", "Elven Sword", "Elven Hood", "Elven Leather", "Elven Metal", "Elven Arrows", "Elven Wood"}; //Celestials, Fey, Constructs, Treasure, Misc
        public List<string> Ore { get; set; } = new List<string>() { "Brass", "Iron", "Bronze", "Lead", "Tin", "Brass", "Iron", "Bronze", "Lead", "Tin", "Brass", "Iron", "Bronze", "Lead", "Tin", "Copper", "Gold", "Electrum", "Gold", "Adamantine", "Mithral", "Platinum" }; //Constructs, Misc
        public List<string> Wands { get; set; } = new List<string>() { "Wand of Acid Arrow", "Wand of Aid", "Wand of Alarm", "Wand of Animal Friendship", "Wand of Booming Blade", "Wand of Chill Touch", "Wand of Chromatic Orb", "Wand of Command", "Wand of Create of Destroy Water", "Wand of Disguise Self", "Wand of Fairie Fire", "Wand of Fireball", "Wand of Grease", "Wand of Ice Storm", "Wand of Jump", "Wand of Knock", "Wand of Light", "Wand of Mage Armor", "Wand of Phantasmal Force", "Wand of Raise Dead", "Wand of Scorching Ray", "Wand of Shatter", "Wand of Shield", "Wand of Teleport", "Wand of Timestop", "Wand of Wall of Fire", "Wand of Wall of ice", "Wand of Wrathful Smite", "Wand of Zone of truth", "Unlisted Wand"}; //Celestials, Fey, Treasure, Misc

        public List<string> Nether { get; set; } = new List<string>() { "Nether-rock", "Nether-rock", "Nether-rock", "Nether-rock", "Nether-rock", "Nether-rock", "Nether-incrusted ring", "Nether-incrusted pendant", "Nether-blade", "Nether-cloak", "Nether-plate", "Nether-incrusted Lockbox"}; //Demons, Nether


        public List<string> BossItems { get; set; } = new List<string>() { "Boss weapon", "Boss weapon", "Boss armor", "Boss trinket"};
        public List<string> QuestItems { get; set; } = new List<string>() { "Arcanist's Pocket Lab", "Drake Egg", "Scryer's Orb", "Death's Deal", "Poster of Rook", "Barracuda Warrior Fin", "Map of Funen Isle", "Treasure Map", "Treasure Map", "Treasure Map", "Treasure Map", "Treasure Map", };
        public List<string> MagicalItems { get; set; } = new List<string>() { "Sickle Coin", "Sickle Coin", "Sickle Coin", "Sickle Coin", "Sickle Coin", "Sickle Coin", "Sickle Coin", "Sickle Coin", "Sickle Coin", "Alchemist Blade", "Barbarian Club", "Beacon Bow", "Battlecry", "Blesk Blade", "Captain's Sword: Wraith", "Captain's Sword: Knight's Fall", "Captain's Sword: Bloodquencher", "Captain's Sword: Storm-Weaver", "Cataract", "Chaos Blade", "Charge Blade", "Coin Cannon", "Dagger of Whistleblowing", "Destin", "Ebony", "Elemental Axe", "Ember Seed", "Fiery Bars", "Frost's Bite", "Fume Greatsword", "Halfhit", "Illogical Weapon", "Immortal Scimitar", "It Which Shatters", "Ironic Pacifist", "Kori Blade", "Mage Blade", "Monk's Bow", "Nimi", "Noroki", "Onyx Blade", "Orcsbane", "Pick of Charging", "Quakestone Hammer", "River Needle", "Shamisen Sword", "Slime", "Spark Rod", "Sword of Lifestealing", "Tailmaril", "Thunder Sword", "Townshed's Cudgel", "Vowedge", "Wind Cutter", "Wo Dao", "Yeoui", "Animated Shield", "Efreeti Chain", "Immovable Rod", "Immovable Rod", "Immovable Rod", "Immovable Rod"
        , "Javelin of Lightning", "Sun Blade", "Alchemy Jug", "Driftglobe", "Eversmoking Bottle", "Rina's bag of escape", "Headband of Intellect", "Pearl of Power", "Rope of climbing", "Bag of beans", "Bead of Force", "Boots of speed", "Cube of force", "Horn of Blasting", "Wings of Flying", "Efreeti Bottle", "Adamantine Armor", "Mariner's Armor", "Mithral Armor", "Demon Armor" };
        public List<string> Potions { get; set; } = new List<string>() { "Potion of Animal Friendship", "Potion of Clairvoyance", "Potion of Climbing", "Potion of Diminution", "Potion of Flying", "Potion of Gaseous Form", "Potion of Giant Strength (Hill Giant)", "Potion of Growth", "Potion of Healing (Common)", "Potion of Heroism", "Potion of Invisibility", "Potion of Mind Reading", "Potion of Poison", "Potion of Resistance (Acid)", "Potion of Resistance (Fire)", "Potion of Speed", "Potion of Water Breathing", "Restorative Ointment", "Potion of Healing (Common)", "Alchemist Fire", "Potion of Knowledge", "Potion of Charisma", "Potion of Healing (Rare)"};
        public List<string> OldEquipment { get; set; } = new List<string>() { "Frail Weapon", "Frail Armor", "Rations" };
        public List<string> Materials { get; set; } = new List<string>() { "Brass", "Iron", "Bronze", "Lead", "Tin", "Brass", "Iron", "Bronze", "Lead", "Tin", "Brass", "Iron", "Bronze", "Lead", "Tin", "Copper", "Gold", "Electrum", "Gold", "Adamantine", "Mithral", "Platinum", "Timber", "Elven-wood", "Parchment", "Ink", "Arcane Components", "Arcane Components", "Arcane Components", "Arcane Components", "Arcane Components", "Divination Components", "Divination Components", "Divination Components" };
        public List<string> Lockboxes { get; set; } = new List<string>() { "Broken Lockbox", "Broken Lockbox", "Broken Lockbox", "Weak Lockbox (DC 10)", "Weak Lockbox (DC 10)", "Decent Lockbox (DC 15)", "Strong Lockbox (DC 20)", "Broken Lockbox", "Broken Lockbox", "Weak Lockbox (DC 10)", "Weak Lockbox (DC 10)", "Decent Lockbox (DC 15)", "Strong Lockbox (DC 20)", "Superior Lockbox (DC 25)", "Unfair Lockbox (DC 30)" };

        

        



    }


}
