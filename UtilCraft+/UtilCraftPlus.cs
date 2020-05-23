using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine;

[ModTitle("Utility Craft +")]
[ModDescription("Adds simple crafting recipies and changed max stack sizes for some advanced gameplay, primarily for farming.")]
[ModAuthor("SWiRaki")]
[ModIconUrl("")]
[ModWallpaperUrl("")]
[ModVersionCheckUrl("")]
[ModVersion("1.0")]
[RaftVersion("11.0")]
[ModIsPermanent(true)]
public class UtilCraftPlus : Mod
{
    private static int _nextTreeSeedOrder;
    private static int _nextFruitSeedOrder;
    private static int _nextFlowerSeedOrder;

    /// <summary>
    /// Mod initialization point.
    /// </summary>
    public void Start()
    {
        RConsole.Log("\"Utility Craft +\" starts loading.");
        RConsole.Log("Adding recipe for tree seeds.");
        CreateTreeSeedRecipe(Items.Seed_Mango, new CostMultiple(new Item_Base[] { Items.Mango }, 1));
        CreateTreeSeedRecipe(Items.Seed_Palm, new CostMultiple(new Item_Base[] { Items.Coconut }, 1));
        RConsole.Log("Adding recipe for fruit seeds.");
        CreateFruitSeedRecipe(Items.Seed_Watermelon, new CostMultiple(new Item_Base[] { Items.Watermelon }, 1));
        CreateFruitSeedRecipe(Items.Seed_Pineapple, new CostMultiple(new Item_Base[] { Items.Pineapple }, 1));
        RConsole.Log("Adding recipe for Flower seeds.");
        CreateFlowerSeedRecipe(Items.Seed_Flower_Red, new CostMultiple(new Item_Base[] { Items.Flower_Red }, 1));
        CreateFlowerSeedRecipe(Items.Seed_Flower_Yellow, new CostMultiple(new Item_Base[] { Items.Flower_Yellow }, 1));
        CreateFlowerSeedRecipe(Items.Seed_Flower_Blue, new CostMultiple(new Item_Base[] { Items.Flower_Blue }, 1));
        CreateFlowerSeedRecipe(Items.Seed_Flower_Black, new CostMultiple(new Item_Base[] { Items.Flower_Black }, 1));
        CreateFlowerSeedRecipe(Items.Seed_Flower_White, new CostMultiple(new Item_Base[] { Items.Flower_White }, 1));
        RConsole.Log("Changing max stack sizes.");
        ChangeItemMaxStackSize(Items.Plastic, 100);
        ChangeItemMaxStackSize(Items.Plank, 100);
        ChangeItemMaxStackSize(Items.Thatch, 100);
        ChangeItemMaxStackSize(Items.Rope, 100);
        ChangeItemMaxStackSize(Items.Scrap, 100);
        ChangeItemMaxStackSize(Items.Nail, 100);
        ChangeItemMaxStackSize(Items.MetalOre, 100);
        ChangeItemMaxStackSize(Items.MetalIngot, 100);
        ChangeItemMaxStackSize(Items.Bolt, 100);
        ChangeItemMaxStackSize(Items.Hinge, 100);
        ChangeItemMaxStackSize(Items.CopperOre, 100);
        ChangeItemMaxStackSize(Items.CopperIngot, 100);
        ChangeItemMaxStackSize(Items.Clay, 100);
        ChangeItemMaxStackSize(Items.Sand, 100);
        ChangeItemMaxStackSize(Items.Glass, 100);
        ChangeItemMaxStackSize(Items.Brick_Dry, 100);
        ChangeItemMaxStackSize(Items.SeaVine, 100);
        ChangeItemMaxStackSize(Items.VineGoo, 100);
        ChangeItemMaxStackSize(Items.Raw_Beet, 250);
        ChangeItemMaxStackSize(Items.Raw_Catfish, 250);
        ChangeItemMaxStackSize(Items.Raw_Drumstick, 250);
        ChangeItemMaxStackSize(Items.Raw_GenericMeat, 250);
        ChangeItemMaxStackSize(Items.Raw_Herring, 250);
        ChangeItemMaxStackSize(Items.Raw_Mackerel, 250);
        ChangeItemMaxStackSize(Items.Raw_Pomfret, 250);
        ChangeItemMaxStackSize(Items.Raw_Potato, 250);
        ChangeItemMaxStackSize(Items.Raw_Salmon, 250);
        ChangeItemMaxStackSize(Items.Raw_Shark, 250);
        ChangeItemMaxStackSize(Items.Raw_Tilapia, 250);
        ChangeItemMaxStackSize(Items.Cooked_Beet, 250);
        ChangeItemMaxStackSize(Items.Cooked_Catfish, 250);
        ChangeItemMaxStackSize(Items.Cooked_Drumstick, 250);
        ChangeItemMaxStackSize(Items.Cooked_GenericMeat, 250);
        ChangeItemMaxStackSize(Items.Cooked_Herring, 250);
        ChangeItemMaxStackSize(Items.Cooked_Mackerel, 250);
        ChangeItemMaxStackSize(Items.Cooked_Pomfret, 250);
        ChangeItemMaxStackSize(Items.Cooked_Potato, 250);
        ChangeItemMaxStackSize(Items.Cooked_Salmon, 250);
        ChangeItemMaxStackSize(Items.Cooked_Shark, 250);
        ChangeItemMaxStackSize(Items.Cooked_Tilapia, 250);
        ChangeItemMaxStackSize(Items.Mango, 250);
        ChangeItemMaxStackSize(Items.Coconut, 250);
        ChangeItemMaxStackSize(Items.Pineapple, 250);
        ChangeItemMaxStackSize(Items.Watermelon, 250);
        ChangeItemMaxStackSize(Items.Seed_Birch, 500);
        ChangeItemMaxStackSize(Items.Seed_Flower_Black, 500);
        ChangeItemMaxStackSize(Items.Seed_Flower_Blue, 500);
        ChangeItemMaxStackSize(Items.Seed_Flower_Red, 500);
        ChangeItemMaxStackSize(Items.Seed_Flower_White, 500);
        ChangeItemMaxStackSize(Items.Seed_Flower_Yellow, 500);
        ChangeItemMaxStackSize(Items.Seed_Grass, 500);
        ChangeItemMaxStackSize(Items.Seed_Mango, 500);
        ChangeItemMaxStackSize(Items.Seed_Palm, 500);
        ChangeItemMaxStackSize(Items.Seed_Pine, 500);
        ChangeItemMaxStackSize(Items.Seed_Pineapple, 500);
        ChangeItemMaxStackSize(Items.Seed_Watermelon, 500);
        ChangeItemMaxStackSize(Items.Arrow_Stone, 1000);
        ChangeItemMaxStackSize(Items.Arrow_Metal, 1000);
        ChangeItemMaxStackSize(Items.Feather, 1000);
        ChangeItemMaxStackSize(Items.Color_Black, 1000);
        ChangeItemMaxStackSize(Items.Color_Blue, 1000);
        ChangeItemMaxStackSize(Items.Color_Red, 1000);
        ChangeItemMaxStackSize(Items.Color_White, 1000);
        ChangeItemMaxStackSize(Items.Color_Yellow, 1000);
        RConsole.Log("UtilCraft+ has been loaded!");
    }

    /// <summary>
    /// Function called every single frame.
    /// </summary>
    public void Update()
    {
        
    }

    /// <summary>
    /// Function unloading the mod.
    /// </summary>
    public void OnModUnload()
    {
        RConsole.Log("UtilCraft+ has been unloaded!");
        Destroy(gameObject);
    }

    /// <summary>
    /// Changes the maximum stack size of given item.
    /// </summary>
    /// <param name="pItem">Item to change.</param>
    /// <param name="pMaxStackSize">New maximum stack size.</param>
    public static void ChangeItemMaxStackSize(Item_Base pItem, int pMaxStackSize)
    {
        pItem.settings_Inventory = new ItemInstance_Inventory(pItem.settings_Inventory.Sprite, pItem.settings_Inventory.LocalizationTerm, pMaxStackSize);
    }
    
    /// <summary>
    /// Function creating a new recipe setting with new recipe.
    /// </summary>
    /// <param name="pResultItem">Item resulting from the crafting.</param>
    /// <param name="pSubCategory">Sub category tag.</param>
    /// <param name="pSubCategoryOrder">Order position within the sub category.</param>
    /// <param name="pCosts">Crafting costs.</param>
    public static void CreateRecipe(Item_Base pResultItem, string pSubCategory, int pSubCategoryOrder, params CostMultiple[] pCosts)
    {
        pResultItem.settings_recipe = new ItemInstance_Recipe(CraftingCategory.FoodWater, true, true, pSubCategory, pSubCategoryOrder) { NewCost = pCosts };
    }

    /// <summary>
    /// Function creating a new recipe setting with new recipe for tree seeds.
    /// </summary>
    /// <param name="pResultItem">Item resulting from the crafting.</param>
    /// <param name="pCosts">Crafting costs.</param>
    public static void CreateTreeSeedRecipe(Item_Base pResultItem, params CostMultiple[] pCosts)
    {
        CreateRecipe(pResultItem, "Seed_Tree", _nextTreeSeedOrder, pCosts);
        _nextTreeSeedOrder++;
    }

    /// <summary>
    /// Function creating a new recipe setting with new recipe for fruit seeds.
    /// </summary>
    /// <param name="pResultItem">Item resulting from the crafting.</param>
    /// <param name="pCosts">Crafting costs.</param>
    public static void CreateFruitSeedRecipe(Item_Base pResultItem, params CostMultiple[] pCosts)
    {
        CreateRecipe(pResultItem, "Seed_Fruit", _nextTreeSeedOrder, pCosts);
        _nextFruitSeedOrder++;
    }

    /// <summary>
    /// Function creating a new recipe setting with new recipe for flower seeds.
    /// </summary>
    /// <param name="pResultItem">Item resulting from the crafting.</param>
    /// <param name="pCosts">Crafting costs.</param>
    public static void CreateFlowerSeedRecipe(Item_Base pResultItem, params CostMultiple[] pCosts)
    {
        CreateRecipe(pResultItem, "Seed_Flower", _nextTreeSeedOrder, pCosts);
        _nextFlowerSeedOrder++;
    }

    /// <summary>
    /// INI file manager
    /// </summary>
    private static class INI
    {
        private static void RemoveWhiteSpace(ref string pText)
        {
            while (pText[0] == ' ')
                pText = pText.Substring(1);
            while (pText[pText.Length - 1] == ' ')
                pText = pText.Remove(pText.Length - 1);
        }

        public static void SetConfigurationFromINI()
        {
            using (StreamReader stream = new StreamReader(File.OpenRead("\\mods\\config\\utilcraftplus.ini")))
            {
                string currentCategory = "";
                string rawData;
                while (!stream.EndOfStream)
                {
                    rawData = stream.ReadLine();
                    RemoveWhiteSpace(ref rawData);
                    if (rawData == "")
                        continue;
                    if (rawData[0] ==  '[' && rawData[rawData.Length - 1] == ']')
                    {
                        currentCategory = rawData.Substring(1, rawData.Length - 2);
                        if (currentCategory == "Recipes")
                            RConsole.Log("Adding Recipes");
                        if (currentCategory == "Stacks")
                            RConsole.Log("Changing item stack sizes");
                        continue;
                    }
                    else
                    {
                        string[] keyValueData = rawData.Split(new char[] { '=' }, 2);
                        RemoveWhiteSpace(ref keyValueData[0]);
                        RemoveWhiteSpace(ref keyValueData[1]); 
                        if (currentCategory == "Recipes")
                        {
                            string[] costItemAmount = keyValueData[1].Split(new char[] { ',' }, 2);
                            if (keyValueData[0] == "Seed_Palm")
                                CreateTreeSeedRecipe(Items.Seed_Palm, new CostMultiple(new Item_Base[] { ItemManager.GetItemByName(costItemAmount[0]) }, int.Parse(costItemAmount[1])));
                            if (keyValueData[0] == "Seed_Mango")
                                CreateTreeSeedRecipe(Items.Seed_Mango, new CostMultiple(new Item_Base[] { ItemManager.GetItemByName(costItemAmount[0]) }, int.Parse(costItemAmount[1])));
                            if (keyValueData[0] == "Seed_Watermelon")
                                CreateFruitSeedRecipe(Items.Seed_Watermelon, new CostMultiple(new Item_Base[] { ItemManager.GetItemByName(costItemAmount[0]) }, int.Parse(costItemAmount[1])));
                            if (keyValueData[0] == "Seed_Pineapple")
                                CreateFruitSeedRecipe(Items.Seed_Pineapple, new CostMultiple(new Item_Base[] { ItemManager.GetItemByName(costItemAmount[0]) }, int.Parse(costItemAmount[1])));
                            if (keyValueData[0] == "Seed_Flower_Red")
                                CreateFlowerSeedRecipe(Items.Seed_Flower_Red, new CostMultiple(new Item_Base[] { ItemManager.GetItemByName(costItemAmount[0]) }, int.Parse(costItemAmount[1])));
                            if (keyValueData[0] == "Seed_Flower_Yellow")
                                CreateFlowerSeedRecipe(Items.Seed_Flower_Yellow, new CostMultiple(new Item_Base[] { ItemManager.GetItemByName(costItemAmount[0]) }, int.Parse(costItemAmount[1])));
                            if (keyValueData[0] == "Seed_Flower_Blue")
                                CreateFlowerSeedRecipe(Items.Seed_Flower_Blue, new CostMultiple(new Item_Base[] { ItemManager.GetItemByName(costItemAmount[0]) }, int.Parse(costItemAmount[1])));
                            if (keyValueData[0] == "Seed_Flower_Black")
                                CreateFlowerSeedRecipe(Items.Seed_Flower_Black, new CostMultiple(new Item_Base[] { ItemManager.GetItemByName(costItemAmount[0]) }, int.Parse(costItemAmount[1])));
                            if (keyValueData[0] == "Seed_Flower_White")
                                CreateFlowerSeedRecipe(Items.Seed_Flower_White, new CostMultiple(new Item_Base[] { ItemManager.GetItemByName(costItemAmount[0]) }, int.Parse(costItemAmount[1])));
                            continue;
                        }
                        if (currentCategory == "Stacks")
                            ChangeItemMaxStackSize(ItemManager.GetItemByName(keyValueData[0]), int.Parse(keyValueData[1]));
                        continue;
                    }
                }
            }
        }
    }

    /// <summary>
    /// Structure containing all vanilla items as constants
    /// </summary>
    private struct Items
    {
        public static readonly Item_Base Block_Floor_Wood = ItemManager.GetItemByIndex(1);
        public static readonly Item_Base Block_Foundation = ItemManager.GetItemByIndex(2);
        public static readonly Item_Base Block_Stair = ItemManager.GetItemByIndex(3);
        public static readonly Item_Base Block_Wall_Wood = ItemManager.GetItemByIndex(4);
        public static readonly Item_Base Placeable_Anchor_Stationary = ItemManager.GetItemByIndex(6);
        public static readonly Item_Base Placeable_Chair = ItemManager.GetItemByIndex(7);
        public static readonly Item_Base Placeable_ItemNet = ItemManager.GetItemByIndex(8);
        public static readonly Item_Base Repair = ItemManager.GetItemByIndex(9);
        public static readonly Item_Base Coconut = ItemManager.GetItemByIndex(10);
        public static readonly Item_Base Cooked_Beet = ItemManager.GetItemByIndex(11);
        public static readonly Item_Base Cooked_Mackerel = ItemManager.GetItemByIndex(12);
        public static readonly Item_Base Cooked_Potato = ItemManager.GetItemByIndex(13);
        public static readonly Item_Base Cooked_Shark = ItemManager.GetItemByIndex(14);
        public static readonly Item_Base Raw_Beet = ItemManager.GetItemByIndex(15);
        public static readonly Item_Base Raw_Mackerel = ItemManager.GetItemByIndex(16);
        public static readonly Item_Base Raw_Potato = ItemManager.GetItemByIndex(17);
        public static readonly Item_Base Raw_Shark = ItemManager.GetItemByIndex(18);
        public static readonly Item_Base MetalOre = ItemManager.GetItemByIndex(19);
        public static readonly Item_Base Nail = ItemManager.GetItemByIndex(20);
        public static readonly Item_Base Plank = ItemManager.GetItemByIndex(21);
        public static readonly Item_Base Rope = ItemManager.GetItemByIndex(22);
        public static readonly Item_Base Scrap = ItemManager.GetItemByIndex(23);
        public static readonly Item_Base SeaVine = ItemManager.GetItemByIndex(24);
        public static readonly Item_Base Thatch = ItemManager.GetItemByIndex(25);
        public static readonly Item_Base Barrel = ItemManager.GetItemByIndex(26);
        public static readonly Item_Base DropItem = ItemManager.GetItemByIndex(27);
        public static readonly Item_Base Seed_Palm = ItemManager.GetItemByIndex(31);
        public static readonly Item_Base Axe = ItemManager.GetItemByIndex(32);
        public static readonly Item_Base FishingRod = ItemManager.GetItemByIndex(33);
        public static readonly Item_Base Hammer = ItemManager.GetItemByIndex(34);
        public static readonly Item_Base Hook_Plastic = ItemManager.GetItemByIndex(35);
        public static readonly Item_Base Hook_Scrap = ItemManager.GetItemByIndex(36);
        public static readonly Item_Base Spear_Scrap = ItemManager.GetItemByIndex(37);
        public static readonly Item_Base PlasticCup_Empty = ItemManager.GetItemByIndex(38);
        public static readonly Item_Base PlasticCup_Water = ItemManager.GetItemByIndex(39);
        public static readonly Item_Base PlasticCup_SaltWater = ItemManager.GetItemByIndex(40);
        public static readonly Item_Base Placeable_Storage_Medium = ItemManager.GetItemByIndex(42);
        public static readonly Item_Base Placeable_CookingStand_Food_One = ItemManager.GetItemByIndex(43);
        public static readonly Item_Base Placeable_Cropplot_Small = ItemManager.GetItemByIndex(45);
        public static readonly Item_Base Placeable_Cropplot_Large = ItemManager.GetItemByIndex(46);
        public static readonly Item_Base Placeable_Lantern = ItemManager.GetItemByIndex(47);
        public static readonly Item_Base Placeable_Table = ItemManager.GetItemByIndex(48);
        public static readonly Item_Base Stone = ItemManager.GetItemByIndex(50);
        public static readonly Item_Base Placeable_GiantClam = ItemManager.GetItemByIndex(51);
        public static readonly Item_Base Spear_Plank = ItemManager.GetItemByIndex(52);
        public static readonly Item_Base Plastic = ItemManager.GetItemByIndex(53);
        public static readonly Item_Base SharkBait = ItemManager.GetItemByIndex(54);
        public static readonly Item_Base Placeable_Anchor_Throwable = ItemManager.GetItemByIndex(56);
        public static readonly Item_Base ThrowableAnchor = ItemManager.GetItemByIndex(57);
        public static readonly Item_Base Block_Wall_Thatch = ItemManager.GetItemByIndex(59);
        public static readonly Item_Base Flipper = ItemManager.GetItemByIndex(63);
        public static readonly Item_Base OxygenBottle = ItemManager.GetItemByIndex(64);
        public static readonly Item_Base Clay = ItemManager.GetItemByIndex(65);
        public static readonly Item_Base Sand = ItemManager.GetItemByIndex(66);
        public static readonly Item_Base Glass = ItemManager.GetItemByIndex(67);
        public static readonly Item_Base MetalIngot = ItemManager.GetItemByIndex(70);
        public static readonly Item_Base Placeable_CookingStand_Smelter = ItemManager.GetItemByIndex(71);
        public static readonly Item_Base Placeable_Brick_Wet = ItemManager.GetItemByIndex(72);
        public static readonly Item_Base Brick_Dry = ItemManager.GetItemByIndex(73);
        public static readonly Item_Base Placeable_CookingStand_Food_Two = ItemManager.GetItemByIndex(77);
        public static readonly Item_Base Placeable_CookingStand_Purifier_Two = ItemManager.GetItemByIndex(78);
        public static readonly Item_Base PlasticBottle_Empty = ItemManager.GetItemByIndex(79);
        public static readonly Item_Base PlasticBottle_SaltWater = ItemManager.GetItemByIndex(80);
        public static readonly Item_Base PlasticBottle_Water = ItemManager.GetItemByIndex(81);
        public static readonly Item_Base Block_Wall_Window_Wood = ItemManager.GetItemByIndex(82);
        public static readonly Item_Base Block_Wall_Window_Thatch = ItemManager.GetItemByIndex(83);
        public static readonly Item_Base Block_Pillar_Wood = ItemManager.GetItemByIndex(84);
        public static readonly Item_Base Block_Wall_Fence_Plank = ItemManager.GetItemByIndex(85);
        public static readonly Item_Base Block_Wall_Fence_Rope = ItemManager.GetItemByIndex(86);
        public static readonly Item_Base Block_Wall_Door_Wood = ItemManager.GetItemByIndex(88);
        public static readonly Item_Base Block_Wall_Door_Thatch = ItemManager.GetItemByIndex(89);
        public static readonly Item_Base Placeable_CookingStand_Purifier_One = ItemManager.GetItemByIndex(91);
        public static readonly Item_Base Placeable_Bed_Hammock = ItemManager.GetItemByIndex(92);
        public static readonly Item_Base Placeable_Bed_Simple = ItemManager.GetItemByIndex(93);
        public static readonly Item_Base Placeable = ItemManager.GetItemByIndex(94);
        public static readonly Item_Base Feather = ItemManager.GetItemByIndex(95);
        public static readonly Item_Base Block_FoundationArmor = ItemManager.GetItemByIndex(96);
        public static readonly Item_Base Egg = ItemManager.GetItemByIndex(97);
        public static readonly Item_Base Raw_Drumstick = ItemManager.GetItemByIndex(98);
        public static readonly Item_Base Cooked_Drumstick = ItemManager.GetItemByIndex(99);
        public static readonly Item_Base Placeable_Scarecrow = ItemManager.GetItemByIndex(100);
        public static readonly Item_Base Placeable_BirdNest = ItemManager.GetItemByIndex(101);
        public static readonly Item_Base Paddle = ItemManager.GetItemByIndex(103);
        public static readonly Item_Base Color_Red = ItemManager.GetItemByIndex(104);
        public static readonly Item_Base Color_Blue = ItemManager.GetItemByIndex(105);
        public static readonly Item_Base Color_Yellow = ItemManager.GetItemByIndex(106);
        public static readonly Item_Base Color_White = ItemManager.GetItemByIndex(107);
        public static readonly Item_Base Color_Black = ItemManager.GetItemByIndex(108);
        public static readonly Item_Base PaintBrush = ItemManager.GetItemByIndex(109);
        public static readonly Item_Base Placeable_ScrapMechanic = ItemManager.GetItemByIndex(110);
        public static readonly Item_Base Placeable_ResearchTable = ItemManager.GetItemByIndex(113);
        public static readonly Item_Base Flower_Black = ItemManager.GetItemByIndex(114);
        public static readonly Item_Base Flower_Red = ItemManager.GetItemByIndex(115);
        public static readonly Item_Base Flower_Yellow = ItemManager.GetItemByIndex(116);
        public static readonly Item_Base Flower_Blue = ItemManager.GetItemByIndex(117);
        public static readonly Item_Base Flower_White = ItemManager.GetItemByIndex(118);
        public static readonly Item_Base Seed_Flower_Black = ItemManager.GetItemByIndex(119);
        public static readonly Item_Base Seed_Flower_White = ItemManager.GetItemByIndex(120);
        public static readonly Item_Base Seed_Flower_Red = ItemManager.GetItemByIndex(121);
        public static readonly Item_Base Seed_Flower_Yellow = ItemManager.GetItemByIndex(122);
        public static readonly Item_Base Seed_Flower_Blue = ItemManager.GetItemByIndex(123);
        public static readonly Item_Base Placeable_PaintMill = ItemManager.GetItemByIndex(124);
        public static readonly Item_Base VineGoo = ItemManager.GetItemByIndex(125);
        public static readonly Item_Base Placeable_Sail = ItemManager.GetItemByIndex(126);
        public static readonly Item_Base Head_Shark = ItemManager.GetItemByIndex(127);
        public static readonly Item_Base Placeable_SharkTrophy = ItemManager.GetItemByIndex(128);
        public static readonly Item_Base Raw_Catfish = ItemManager.GetItemByIndex(129);
        public static readonly Item_Base Raw_Salmon = ItemManager.GetItemByIndex(130);
        public static readonly Item_Base Raw_Herring = ItemManager.GetItemByIndex(131);
        public static readonly Item_Base Raw_Pomfret = ItemManager.GetItemByIndex(132);
        public static readonly Item_Base Cooked_Salmon = ItemManager.GetItemByIndex(133);
        public static readonly Item_Base Cooked_Pomfret = ItemManager.GetItemByIndex(134);
        public static readonly Item_Base Cooked_Catfish = ItemManager.GetItemByIndex(135);
        public static readonly Item_Base Cooked_Herring = ItemManager.GetItemByIndex(136);
        public static readonly Item_Base Cooked_Tilapia = ItemManager.GetItemByIndex(137);
        public static readonly Item_Base Raw_Tilapia = ItemManager.GetItemByIndex(138);
        public static readonly Item_Base Placeable_Cropplot_Shoe = ItemManager.GetItemByIndex(139);
        public static readonly Item_Base Placeable_Storage_Small = ItemManager.GetItemByIndex(140);
        public static readonly Item_Base Placeable_Streamer = ItemManager.GetItemByIndex(142);
        public static readonly Item_Base Block_HalfFloor_Wood = ItemManager.GetItemByIndex(143);
        public static readonly Item_Base Block_HalfWall_Wood = ItemManager.GetItemByIndex(144);
        public static readonly Item_Base Block_HalfStair = ItemManager.GetItemByIndex(145);
        public static readonly Item_Base Block_HalfPillar_Wood = ItemManager.GetItemByIndex(146);
        public static readonly Item_Base Block_HalfWall_Thatch = ItemManager.GetItemByIndex(147);
        public static readonly Item_Base Block_Roof_Straight_Wood = ItemManager.GetItemByIndex(148);
        public static readonly Item_Base Block_Roof_Straight_Thatch = ItemManager.GetItemByIndex(149);
        public static readonly Item_Base Block_Roof_Corner_Wood = ItemManager.GetItemByIndex(150);
        public static readonly Item_Base Block_Roof_Corner_Thatch = ItemManager.GetItemByIndex(151);
        public static readonly Item_Base Block_Wall_Slope_Wood = ItemManager.GetItemByIndex(152);
        public static readonly Item_Base Block_Wall_Slope_Thatch = ItemManager.GetItemByIndex(153);
        public static readonly Item_Base Bolt = ItemManager.GetItemByIndex(154);
        public static readonly Item_Base Hinge = ItemManager.GetItemByIndex(155);
        public static readonly Item_Base Placeable_LuckyCat = ItemManager.GetItemByIndex(156);
        public static readonly Item_Base Placeable_GlassCandle = ItemManager.GetItemByIndex(157);
        public static readonly Item_Base Placeable_Rug = ItemManager.GetItemByIndex(158);
        public static readonly Item_Base Placeable_Clock = ItemManager.GetItemByIndex(159);
        public static readonly Item_Base Block_Roof_InvCorner_Wood = ItemManager.GetItemByIndex(160);
        public static readonly Item_Base Block_Roof_InvCorner_Thatch = ItemManager.GetItemByIndex(161);
        public static readonly Item_Base Placeable_Cropplot_Medium = ItemManager.GetItemByIndex(162);
        public static readonly Item_Base Watermelon = ItemManager.GetItemByIndex(163);
        public static readonly Item_Base Mango = ItemManager.GetItemByIndex(164);
        public static readonly Item_Base Pineapple = ItemManager.GetItemByIndex(165);
        public static readonly Item_Base Seed_Watermelon = ItemManager.GetItemByIndex(166);
        public static readonly Item_Base Seed_Mango = ItemManager.GetItemByIndex(167);
        public static readonly Item_Base Seed_Pineapple = ItemManager.GetItemByIndex(168);
        public static readonly Item_Base FishingRod_Metal = ItemManager.GetItemByIndex(169);
        public static readonly Item_Base Binoculars = ItemManager.GetItemByIndex(170);
        public static readonly Item_Base Placeable_Calendar = ItemManager.GetItemByIndex(171);
        public static readonly Item_Base Placeable_Sign = ItemManager.GetItemByIndex(172);
        public static readonly Item_Base Placeable_Reciever = ItemManager.GetItemByIndex(173);
        public static readonly Item_Base Placeable_Reciever_Antenna = ItemManager.GetItemByIndex(175);
        public static readonly Item_Base Battery = ItemManager.GetItemByIndex(176);
        public static readonly Item_Base CopperIngot = ItemManager.GetItemByIndex(177);
        public static readonly Item_Base CircuitBoard = ItemManager.GetItemByIndex(178);
        public static readonly Item_Base CopperOre = ItemManager.GetItemByIndex(179);
        public static readonly Item_Base Blueprint_Reciever = ItemManager.GetItemByIndex(181);
        public static readonly Item_Base Blueprint_Antenna = ItemManager.GetItemByIndex(182);
        public static readonly Item_Base BeachBall = ItemManager.GetItemByIndex(183);
        public static readonly Item_Base Block_Ladder = ItemManager.GetItemByIndex(184);
        public static readonly Item_Base Bow = ItemManager.GetItemByIndex(185);
        public static readonly Item_Base Arrow_Stone = ItemManager.GetItemByIndex(186);
        public static readonly Item_Base Placeable_Shelf = ItemManager.GetItemByIndex(187);
        public static readonly Item_Base Axe_Stone = ItemManager.GetItemByIndex(188);
        public static readonly Item_Base Block_Foundation_Triangular_Wood = ItemManager.GetItemByIndex(189);
        public static readonly Item_Base Block_Floor_Triangular_Wood = ItemManager.GetItemByIndex(191);
        public static readonly Item_Base Block_Roof_Wood_Corner_Triangular = ItemManager.GetItemByIndex(192);
        public static readonly Item_Base Block_HalfFloor_Triangular_Wood = ItemManager.GetItemByIndex(193);
        public static readonly Item_Base Placeable_CookingPot = ItemManager.GetItemByIndex(194);
        public static readonly Item_Base Placeable_TrophyBoard_Large = ItemManager.GetItemByIndex(195);
        public static readonly Item_Base Placeable_TrophyBoard_Medium = ItemManager.GetItemByIndex(196);
        public static readonly Item_Base Placeable_TrophyBoard_Small = ItemManager.GetItemByIndex(197);
        public static readonly Item_Base CaveMushroom = ItemManager.GetItemByIndex(198);
        public static readonly Item_Base Claybowl_Empty = ItemManager.GetItemByIndex(199);
        public static readonly Item_Base Berries_Red = ItemManager.GetItemByIndex(200);
        public static readonly Item_Base SilverAlgae = ItemManager.GetItemByIndex(201);
        public static readonly Item_Base Claybowl_RootVegetableSoup = ItemManager.GetItemByIndex(202);
        public static readonly Item_Base Claybowl_Leftover = ItemManager.GetItemByIndex(203);
        public static readonly Item_Base Placeable_Recipe_VegetableSoup = ItemManager.GetItemByIndex(204);
        public static readonly Item_Base Head_Screecher = ItemManager.GetItemByIndex(205);
        public static readonly Item_Base Head_PoisonPuffer = ItemManager.GetItemByIndex(206);
        public static readonly Item_Base Arrow_Metal = ItemManager.GetItemByIndex(207);
        public static readonly Item_Base Claybowl_SimpleFishStew = ItemManager.GetItemByIndex(208);
        public static readonly Item_Base ClayPlate_CatfishDeluxe = ItemManager.GetItemByIndex(209);
        public static readonly Item_Base Claybowl_CoconutChicken = ItemManager.GetItemByIndex(210);
        public static readonly Item_Base ClayPlate_DrumstickWithJam = ItemManager.GetItemByIndex(211);
        public static readonly Item_Base Claybowl_Headbroth = ItemManager.GetItemByIndex(212);
        public static readonly Item_Base ClayPlate_MushroomOmelette = ItemManager.GetItemByIndex(213);
        public static readonly Item_Base ClayPlate_SalmonSalad = ItemManager.GetItemByIndex(214);
        public static readonly Item_Base ClayPlate_SharkDinner = ItemManager.GetItemByIndex(215);
        public static readonly Item_Base Claybowl_FishStew = ItemManager.GetItemByIndex(216);
        public static readonly Item_Base ClayPlate_FruitCompot = ItemManager.GetItemByIndex(217);
        public static readonly Item_Base Placeable_Recipe_SimpleFishStew = ItemManager.GetItemByIndex(218);
        public static readonly Item_Base Placeable_Recipe_CatfishDeluxe = ItemManager.GetItemByIndex(219);
        public static readonly Item_Base Placeable_Recipe_CoconutChicken = ItemManager.GetItemByIndex(220);
        public static readonly Item_Base Placeable_Recipe_DrumstickWithJam = ItemManager.GetItemByIndex(221);
        public static readonly Item_Base Placeable_Recipe_HeadBroth = ItemManager.GetItemByIndex(222);
        public static readonly Item_Base Placeable_Recipe_MushroomOmelette = ItemManager.GetItemByIndex(223);
        public static readonly Item_Base Placeable_Recipe_SalmonSalad = ItemManager.GetItemByIndex(224);
        public static readonly Item_Base Placeable_Recipe_SharkDinner = ItemManager.GetItemByIndex(225);
        public static readonly Item_Base Placeable_Recipe_FishStew = ItemManager.GetItemByIndex(226);
        public static readonly Item_Base Placeable_Recipe_FruitCompot = ItemManager.GetItemByIndex(227);
        public static readonly Item_Base Placeable_Recipe = ItemManager.GetItemByIndex(228);
        public static readonly Item_Base PilotHelmet = ItemManager.GetItemByIndex(235);
        public static readonly Item_Base Seed_Grass = ItemManager.GetItemByIndex(236);
        public static readonly Item_Base Placeable_Cropplot_Grass = ItemManager.GetItemByIndex(237);
        public static readonly Item_Base Shovel = ItemManager.GetItemByIndex(238);
        public static readonly Item_Base Dirt = ItemManager.GetItemByIndex(239);
        public static readonly Item_Base Bucket = ItemManager.GetItemByIndex(240);
        public static readonly Item_Base Bucket_Milk = ItemManager.GetItemByIndex(241);
        public static readonly Item_Base Shear = ItemManager.GetItemByIndex(242);
        public static readonly Item_Base Wool = ItemManager.GetItemByIndex(243);
        public static readonly Item_Base NetGun = ItemManager.GetItemByIndex(244);
        public static readonly Item_Base NetCanister = ItemManager.GetItemByIndex(245);
        public static readonly Item_Base Leather = ItemManager.GetItemByIndex(246);
        public static readonly Item_Base ExplosiveGoo = ItemManager.GetItemByIndex(247);
        public static readonly Item_Base HealingSalve = ItemManager.GetItemByIndex(248);
        public static readonly Item_Base Equipment_LetherHelmet = ItemManager.GetItemByIndex(249);
        public static readonly Item_Base Equipment_LeatherChest = ItemManager.GetItemByIndex(250);
        public static readonly Item_Base Equipment_LeatherLegs = ItemManager.GetItemByIndex(251);
        public static readonly Item_Base Backpack = ItemManager.GetItemByIndex(252);
        public static readonly Item_Base Head_Boar = ItemManager.GetItemByIndex(253);
        public static readonly Item_Base ExplosivePowder = ItemManager.GetItemByIndex(254);
        public static readonly Item_Base Block_Wall_Gate_Wood = ItemManager.GetItemByIndex(255);
        public static readonly Item_Base Block_Wall_Gate_Thatch = ItemManager.GetItemByIndex(256);
        public static readonly Item_Base Placeable_Nametag = ItemManager.GetItemByIndex(257);
        public static readonly Item_Base Placeable_Sprinkler = ItemManager.GetItemByIndex(259);
        public static readonly Item_Base Placeable_Figurine_Llama = ItemManager.GetItemByIndex(260);
        public static readonly Item_Base Placeable_Figurine_Chicken = ItemManager.GetItemByIndex(261);
        public static readonly Item_Base Placeable_Figurine_Goat = ItemManager.GetItemByIndex(262);
        public static readonly Item_Base Placeable_Radio = ItemManager.GetItemByIndex(263);
        public static readonly Item_Base CaptainsHat = ItemManager.GetItemByIndex(264);
        public static readonly Item_Base Placeable_MotorWheel = ItemManager.GetItemByIndex(265);
        public static readonly Item_Base Placeable_SteeringWheel = ItemManager.GetItemByIndex(268);
        public static readonly Item_Base Blueprint_HeadLight = ItemManager.GetItemByIndex(270);
        public static readonly Item_Base HeadLight = ItemManager.GetItemByIndex(271);
        public static readonly Item_Base Blueprint_MotorWheel = ItemManager.GetItemByIndex(272);
        public static readonly Item_Base Blueprint_SteeringWheel = ItemManager.GetItemByIndex(273);
        public static readonly Item_Base Placeable_BiofuelExtractor = ItemManager.GetItemByIndex(274);
        public static readonly Item_Base Machete = ItemManager.GetItemByIndex(275);
        public static readonly Item_Base Jar_Honey = ItemManager.GetItemByIndex(276);
        public static readonly Item_Base Placeable_Pipe = ItemManager.GetItemByIndex(277);
        public static readonly Item_Base Placeable_FuelTank = ItemManager.GetItemByIndex(278);
        public static readonly Item_Base Blueprint_Machete = ItemManager.GetItemByIndex(279);
        public static readonly Item_Base Blueprint_Pipe = ItemManager.GetItemByIndex(280);
        public static readonly Item_Base Blueprint_Fueltank = ItemManager.GetItemByIndex(281);
        public static readonly Item_Base Blueprint_BiofuelExtractor = ItemManager.GetItemByIndex(282);
        public static readonly Item_Base Seed_Pine = ItemManager.GetItemByIndex(283);
        public static readonly Item_Base Seed_Birch = ItemManager.GetItemByIndex(284);
        public static readonly Item_Base Head_Bear = ItemManager.GetItemByIndex(285);
        public static readonly Item_Base BioFuel = ItemManager.GetItemByIndex(286);
        public static readonly Item_Base Head_MamaBear = ItemManager.GetItemByIndex(287);
        public static readonly Item_Base Cooked_GenericMeat = ItemManager.GetItemByIndex(288);
        public static readonly Item_Base Raw_GenericMeat = ItemManager.GetItemByIndex(289);
        public static readonly Item_Base Placeable_BeeHive = ItemManager.GetItemByIndex(290);
        public static readonly Item_Base SweepNet = ItemManager.GetItemByIndex(291);
        public static readonly Item_Base Jar_Bee = ItemManager.GetItemByIndex(292);
        public static readonly Item_Base HoneyComb = ItemManager.GetItemByIndex(294);
        public static readonly Item_Base HealingSalve_Good = ItemManager.GetItemByIndex(295);
    }
}
