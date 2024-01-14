using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public interface Interfaces
{
    void chosenOne();
}
public struct CharStats
{
    public int[] statValue;
    public string[] statName;
}
public abstract class CharDetails : Interfaces
{
    protected string? Name { get; set; }
    protected string? Gender { get; set; }
    protected string? Weight { get; set; }
    protected string? Height { get; set; }
    protected string? Race { get; set; }
    protected string? Class { get; set; }
    protected string? SkinColor { get; set; }
    protected string? HairLength { get; set; }
    protected string? HairStyle { get; set; }
    protected string? HairColor { get; set; }
    protected string? EyeColor { get; set; }
    protected string? UpperClothing { get; set; }
    protected string? ShirtColor { get; set; }
    protected string? LowerClothing { get; set; }
    protected string? Accessories { get; set; }
    protected string? Shoes { get; set; }
    protected string? Bag { get; set; }
    protected string? Weapon { get; set; }
    protected string? Companion { get; set; }
    protected string? Mount { get; set; }

    public abstract void chosenOne();
}
public class Creation : CharDetails
{
    public string? name, chosenGender, chosenWeight, chosenHeight, chosenRace, chosenClass,
        chosenSkinColor, chosenHairLength, chosenHairStyle, chosenHairColor,
        chosenEyeColor, chosenUpperClothing, chosenShirtColor, chosenLowerClothing,
        chosenAccessories, chosenShoes, chosenBag, chosenWeapon, chosenCompanion, chosenMount;
    public string[] gender = { "Male", "Female" };
    public string[] weight = { "Skinny", "Buffed", "Chubby" };
    public string[] height = { "Tall", "Short", "Medium" };
    public string[] race = { "Human", "Elf", "Dwarf", "Fairy", "Undead" };
    public string[] _class = { "Warrior", "Knight", "Archer", "Mage", "Priest", "Necromancer" };
    public string[] skinColor = { "Pale", "Fair", "Brown", "Blue", "Black" };
    public string[] hairLength = { "Short", "Medium", "Long", "Bald" };
    public string[] hairStyle = { "Curly", "Straight", "Braided", "Pony Tail", "Pig Tail", "Bald" };
    public string[] hairColor = { "Red", "Blue", "White", "Purple", "Black", "Brown" };
    public string[] eyeColor = { "Red", "Blue", "Purple", "Black", "Brown" };
    public string[] upperClothing = { "Dress", "Flannel", "Robe", "Armor", "Shirt" };
    public string[] shirtColor = { "Red", "Blue", "Black", "Purple", "White", "Yellow" };
    public string[] lowerClothing = { "Skirt", "Pants", "Shorts" };
    public string[] accessories = { "Hat", "Bracelet", "Earrings", "Piercings", "Rings" };
    public string[] shoes = { "Boots", "Flat Shoes", "Heels", "Rubber Shoes" };
    public string[] bag = { "Side Bag", "Leather Bag", "Backpack" };
    public string[] weapon = { "Scythe", "Staff", "Sword", "Bow", "Claymore", "Spear" };
    public string[] companion = { "Fairy", "Dog", "Cat", "Troll" };
    public string[] mount = { "Horse", "Carriage", "Dragon", "Unicorn" };
    public CharStats statN = new CharStats { statName = new string[] { "Str", "Agi", "Vit", "Int", "Dex", "Luk", "HP", "MP" } };
    public CharStats statV = new CharStats { statValue = new int[] { 1, 1, 1, 1, 1, 1, 90, 45 } };
    public bool isFactionless, boolean;
    public int choice, statQty;

    public Creation()
    {
        try
        {
            while (!boolean)
            {
                name = GetValidName();
                this.Name = name;
                boolean = true;
            }
            string GetValidName()
            {
                do
                {
                    Console.Write("Enter your character name: ");
                    name = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(name) || ContainsSpace(name))
                    {
                        Console.WriteLine("Invalid name. Please enter a valid name.");
                    }
                } while (string.IsNullOrWhiteSpace(name) || ContainsSpace(name));

                return name;
            }

            bool ContainsSpace(string input)
            {
                return Regex.IsMatch(input, @"\s");
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            new Creation();
        }
    }
    public void selectGender()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character gender:");
                for (int i = 1; i <= gender.Length; i++)
                {
                    Console.WriteLine(i + ". " + gender[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= gender.Length && choice > 0)
                {
                    chosenGender = gender[choice - 1];
                    this.Gender = chosenGender;
                    Console.WriteLine("Gender: " + this.Gender);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectGender();
        }
    }
    public void selectWeight()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character weight:");
                for (int i = 1; i <= weight.Length; i++)
                {
                    Console.WriteLine(i + ". " + weight[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= weight.Length && choice > 0)
                {
                    chosenWeight = weight[choice - 1];
                    this.Weight = chosenWeight;
                    Console.WriteLine("Weight: " + this.Weight);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectWeight();
        }
    }
    public void selectHeight()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character height:");
                for (int i = 1; i <= height.Length; i++)
                {
                    Console.WriteLine(i + ". " + height[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= height.Length && choice > 0)
                {
                    chosenHeight = height[choice - 1];
                    this.Height = chosenHeight;
                    Console.WriteLine("Height: " + this.Height);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectHeight();
        }
    }
    public void selectRace()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character race:");
                for (int i = 1; i <= race.Length; i++)
                {
                    Console.WriteLine(i + ". " + race[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= race.Length && choice > 0)
                {
                    chosenRace = race[choice - 1];
                    this.Race = chosenRace;
                    Console.WriteLine("Race: " + this.Race);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectRace();
        }
    }
    public void selectClass()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character class:");
                for (int i = 1; i <= _class.Length; i++)
                {
                    Console.WriteLine(i + ". " + _class[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= _class.Length && choice > 0)
                {
                    chosenClass = _class[choice - 1];
                    this.Class = chosenClass;
                    Console.WriteLine("Class: " + this.Class);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectClass();
        }
    }
    public void editStats()
    {
        try
        {
            int statPoints = 20;
            boolean = true;
            while (boolean && statPoints != 0)
            {
                Console.WriteLine("\nChoose where you want to allocate your stat points:");
                for (int i = 1; i <= statN.statName.Length - 2; i++)
                {
                    Console.WriteLine(i + ". " + statN.statName[i - 1]);
                }
                Console.WriteLine("Stat Points: " + statPoints);
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= statN.statName.Length - 2 && choice > 0)
                {
                    Console.Write("How many stats to put: ");
                    int.TryParse(Console.ReadLine(), out statQty);
                    if (statQty <= statPoints && statQty >= 0)
                    {
                        statV.statValue[choice - 1] = statV.statValue[choice - 1] + statQty;
                        Console.WriteLine("You have added " + statQty + " stat points to " + statN.statName[choice - 1]);
                        statPoints = statPoints - statQty;
                    }
                    else
                    {
                        throw new InvalidInputException("Invalid Input!! Try Again!!");
                    }
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
            Console.WriteLine("No more stat points to allocate!");

            statV.statValue[6] = statV.statValue[6] + 10 * statV.statValue[2];//HP computation
            statV.statValue[7] = statV.statValue[7] + 5 * statV.statValue[3];//MP computation
            Console.WriteLine("\nTotal Stats: ");
            for (int i = 0; i < statN.statName.Length; i++)
            {
                Console.WriteLine(statN.statName[i] + " " + statV.statValue[i]);
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            statV = new CharStats { statValue = new int[] { 1, 1, 1, 1, 1, 1, 90, 45 } };
            editStats();
        }
    }
    public void selectSkinColor()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character skin color:");
                for (int i = 1; i <= skinColor.Length; i++)
                {
                    Console.WriteLine(i + ". " + skinColor[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= skinColor.Length && choice > 0)
                {
                    chosenSkinColor = skinColor[choice - 1];
                    this.SkinColor = chosenSkinColor;
                    Console.WriteLine("Skin Color: " + this.SkinColor);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectSkinColor();
        }
    }
    public void selectHair()
    {
        try
        {
            string hLength = "", hStyle = "", hColor = "";
            boolean = true;
            while (boolean)
            {
                Console.Write("\nDo You Want to Change Hair Style?\n1. Yes\n2. No\nChoice: ");
                int option; int.TryParse(Console.ReadLine(), out option);
                if (option == 1)
                {
                    Console.WriteLine("\nSelect character hair length:");
                    for (int i = 1; i <= hairLength.Length; i++)
                    {
                        Console.WriteLine(i + ". " + hairLength[i - 1]);
                    }
                    Console.Write("Choice: ");
                    int.TryParse(Console.ReadLine(), out choice);
                    if (choice <= hairLength.Length && choice > 0)
                    {
                        hLength = hairLength[choice - 1];
                        chosenHairLength = hLength;
                    }
                    else
                    {
                        throw new InvalidInputException("Invalid Input!! Try Again!!");
                    }
                    Console.WriteLine("\nSelect character hair style:");
                    for (int i = 1; i <= hairStyle.Length; i++)
                    {
                        Console.WriteLine(i + ". " + hairStyle[i - 1]);
                    }
                    Console.Write("Choice: ");
                    int.TryParse(Console.ReadLine(), out choice);
                    if (choice <= hairStyle.Length && choice > 0)
                    {
                        hStyle = hairStyle[choice - 1];
                        chosenHairStyle = hStyle;
                    }
                    else
                    {
                        throw new InvalidInputException("Invalid Input!! Try Again!!");
                    }
                    Console.WriteLine("\nSelect character hair color:");
                    for (int i = 1; i <= hairColor.Length; i++)
                    {
                        Console.WriteLine(i + ". " + hairColor[i - 1]);
                    }
                    Console.Write("Choice: ");
                    int.TryParse(Console.ReadLine(), out choice);
                    if (choice <= hairColor.Length && choice > 0)
                    {
                        hColor = hairColor[choice - 1];
                        chosenHairColor = hColor;
                        boolean = false;
                    }
                    else
                    {
                        throw new InvalidInputException("Invalid Input!! Try Again!!");
                    }
                    Hair(hLength, hStyle, hColor);
                }
                else if (option == 2)
                {
                    Hair();
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectHair();
        }
    }
    public void Hair()
    {
        if (this.Gender == "Male")
        {
            chosenHairStyle = "Straight";
            this.HairStyle = chosenHairStyle;
            chosenHairColor = "Black";
            this.HairColor = chosenHairColor;
            chosenHairLength = "Short";
            this.HairLength = chosenHairLength;
            Console.WriteLine("Default Hair");
            Console.WriteLine("Style: " + this.HairStyle);
            Console.WriteLine("Color: " + this.HairColor);
            Console.WriteLine("Length: " + this.HairLength);
            Console.WriteLine();
        }
        else
        {
            chosenHairStyle = "Straight";
            this.HairStyle = chosenHairStyle;
            chosenHairColor = "Black";
            this.HairColor = chosenHairColor;
            chosenHairLength = "Long";
            this.HairLength = chosenHairLength;
            Console.WriteLine("Default Hair");
            Console.WriteLine("Style: " + this.HairStyle);
            Console.WriteLine("Color: " + this.HairColor);
            Console.WriteLine("Length: " + this.HairLength);
            Console.WriteLine();
        }
    }
    public void Hair(string length, string style, string color)
    {
        if (this.Gender == "Male")
        {
            this.HairStyle = style;
            this.HairColor = color;
            this.HairLength = length;
            Console.WriteLine();
            Console.WriteLine("New Hair");
            Console.WriteLine("Style: " + this.HairStyle);
            Console.WriteLine("Color: " + this.HairColor);
            Console.WriteLine("Length: " + this.HairLength);
            Console.WriteLine();
        }
        else
        {
            this.HairStyle = style;
            this.HairColor = color;
            this.HairLength = length;
            Console.WriteLine();
            Console.WriteLine("New Hair");
            Console.WriteLine("Style: " + this.HairStyle);
            Console.WriteLine("Color: " + this.HairColor);
            Console.WriteLine("Length: " + this.HairLength);
            Console.WriteLine();
        }
    }
    public void selectEyeColor()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character eye color:");
                for (int i = 1; i <= eyeColor.Length; i++)
                {
                    Console.WriteLine(i + ". " + eyeColor[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= eyeColor.Length && choice > 0)
                {
                    chosenEyeColor = eyeColor[choice - 1];
                    this.EyeColor = chosenEyeColor;
                    Console.WriteLine("Eye Color: " + this.EyeColor);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectEyeColor();
        }
    }
    public void selectUpperClothing()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character upper body clothing:");
                for (int i = 1; i <= upperClothing.Length; i++)
                {
                    Console.WriteLine(i + ". " + upperClothing[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= upperClothing.Length && choice > 0)
                {
                    chosenUpperClothing = upperClothing[choice - 1];
                    this.UpperClothing = chosenUpperClothing;
                    Console.WriteLine("Upper Body Clothing: " + this.UpperClothing);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectUpperClothing();
        }
    }
    public void selectShirtColor()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character clothing color:");
                for (int i = 1; i <= shirtColor.Length; i++)
                {
                    Console.WriteLine(i + ". " + shirtColor[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= shirtColor.Length && choice > 0)
                {
                    chosenShirtColor = shirtColor[choice - 1];
                    this.ShirtColor = chosenShirtColor;
                    Console.WriteLine("Clothing Color: " + chosenShirtColor);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectShirtColor();
        }
    }
    public void selectLowerClothing()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character lower body clothing:");
                for (int i = 1; i <= lowerClothing.Length; i++)
                {
                    Console.WriteLine(i + ". " + lowerClothing[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= lowerClothing.Length && choice > 0)
                {
                    chosenLowerClothing = lowerClothing[choice - 1];
                    this.LowerClothing = chosenLowerClothing;
                    Console.WriteLine("Lower Body Clothing: " + chosenLowerClothing);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectLowerClothing();
        }
    }
    public void selectAccessories()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character accessories:");
                for (int i = 1; i <= accessories.Length; i++)
                {
                    Console.WriteLine(i + ". " + accessories[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= accessories.Length && choice > 0)
                {
                    chosenAccessories = accessories[choice - 1];
                    this.Accessories = chosenAccessories;
                    Console.WriteLine("Accessory: " + chosenAccessories);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectAccessories();
        }
    }
    public void selectShoes()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character shoes:");
                for (int i = 1; i <= shoes.Length; i++)
                {
                    Console.WriteLine(i + ". " + shoes[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= shoes.Length && choice > 0)
                {
                    chosenShoes = shoes[choice - 1];
                    this.Shoes = chosenShoes;
                    Console.WriteLine("Shoes: " + chosenShoes);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectShoes();
        }
    }
    public void selectBag()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character bag:");
                for (int i = 1; i <= bag.Length; i++)
                {
                    Console.WriteLine(i + ". " + bag[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= bag.Length && choice > 0)
                {
                    chosenBag = bag[choice - 1];
                    this.Bag = chosenBag;
                    Console.WriteLine("Bag: " + chosenBag);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectBag();
        }
    }
    public void selectWeapon()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character weapon:");
                for (int i = 1; i <= weapon.Length; i++)
                {
                    Console.WriteLine(i + ". " + weapon[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= weapon.Length && choice > 0)
                {
                    chosenWeapon = weapon[choice - 1];
                    this.Weapon = chosenWeapon;
                    Console.WriteLine("Weapon: " + chosenWeapon);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectWeapon();
        }
    }
    public void selectCompanion()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character companion:");
                for (int i = 1; i <= companion.Length; i++)
                {
                    Console.WriteLine(i + ". " + companion[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= companion.Length && choice > 0)
                {
                    chosenCompanion = companion[choice - 1];
                    this.Companion = chosenCompanion;
                    Console.WriteLine("Companion: " + chosenCompanion);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectCompanion();
        }
    }
    public void selectMount()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nSelect character mount:");
                for (int i = 1; i <= mount.Length; i++)
                {
                    Console.WriteLine(i + ". " + mount[i - 1]);
                }
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= mount.Length && choice > 0)
                {
                    chosenMount = mount[choice - 1];
                    this.Mount = chosenMount;
                    Console.WriteLine("Mount: " + chosenMount);
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectMount();
        }
    }
    public void selectFaction()
    {
        try
        {
            boolean = true;
            while (boolean)
            {
                Console.WriteLine("\nDo you wish your character to have a faction?\n1. Yes\n2. No");
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice == 1)
                {
                    Console.WriteLine("You have chosen to join the faction!!");
                    isFactionless = false;
                    boolean = false;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You have chosen to be factionless!!");
                    isFactionless = true;
                    boolean = false;
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!");
                }
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
            selectFaction();
        }
    }
    public override void chosenOne()
    {
        Console.WriteLine("\nCharacter Details: ");
        Console.WriteLine("Name: " + this.Name);
        Console.WriteLine("Gender: " + this.Gender);
        Console.WriteLine("Weight: " + this.Weight);
        Console.WriteLine("Height: " + this.Height);
        Console.WriteLine("Race: " + this.Race);
        Console.WriteLine("Class: " + this.Class);
        Console.WriteLine("Skin Color: " + this.SkinColor);
        Console.WriteLine("Hair Length: " + this.HairLength);
        Console.WriteLine("Hair Style: " + this.HairStyle);
        Console.WriteLine("Hair Color: " + this.HairColor);
        Console.WriteLine("Eye Color: " + this.EyeColor);
        Console.WriteLine("Upper Body Clothing: " + this.UpperClothing);
        Console.WriteLine("Shirt Color: " + this.ShirtColor);
        Console.WriteLine("Lower Body Clothing: " + this.LowerClothing);
        Console.WriteLine("Accessory: " + this.Accessories);
        Console.WriteLine("Shoes: " + this.Shoes);
        Console.WriteLine("Bag: " + this.Bag);
        Console.WriteLine("Weapon: " + this.Weapon);
        Console.WriteLine("Companion: " + this.Companion);
        Console.WriteLine("Mount: " + this.Mount);
        Console.WriteLine("\nTotal Stats: ");
        for (int i = 0; i < statV.statValue.Length; i++)
        {
            Console.WriteLine(statN.statName[i] + " " + statV.statValue[i]);
        }
    }
    public void faction()
    {
        if (isFactionless == false)
        {
            Console.WriteLine("\nWelcome, honored adventurer " + name + "! By joining the prestigious faction, you have gained access to the Faction Headquarters. " +
                "\nHere, you can embark on noble quests such as gathering rare herbs,protecting traveling merchants, and bravely hunting down menacing monsters threatening our lands. " +
                "\nYour actions will earn you renown and rewards, and you'll be a beacon of hope for our faction!");
            Console.WriteLine("May your journey with the faction be filled with glory and triumph!\n");
        }
        else
        {
            Console.WriteLine("\nGreetings, wanderer " + name + ". As a fearless factionless soul, you find solace and challenges within the clandestine realm of the Underground Assassin's Guild." +
                "\nHere, your skills are put to the test with quests such as cunning thefts from traveling merchants, executing discreet assassinations of noblemen, and hunting down wanted players like yourself. " +
                "\nYour success will bring you notoriety among the shadows.");
            Console.WriteLine("Navigate these shadowy waters wisely, for your choices will shape your destiny.\n");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int choice;
        bool bull, bullyan;
        SqlConnection ConnectedSuccessfully;
        string dbConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\USERS\DDVEN\ONEDRIVE\DOCUMENTS\LA 2ND SEM\COMPROG C#\COMPROG_CODE\TASKPERFORMANCE\DATABASE1.MDF"";Integrated Security=True;";
        ConnectedSuccessfully = new SqlConnection(dbConnectionString);

        Console.Write("Main Menu:\n1. Create Character\n2. View All Characters\n3. Delete Character\n4. Exit\nChoice: ");
        int.TryParse(Console.ReadLine(), out choice);
        bullyan = true;
        while (bullyan)
        {
            try
            {
                if (choice == 1)
                {
                    Console.WriteLine();
                    Creation obj = new Creation();

                    obj.selectGender();
                    obj.selectWeight();
                    obj.selectHeight();
                    obj.selectRace();
                    obj.selectClass();
                    obj.editStats();
                    obj.selectHair();
                    obj.selectSkinColor();
                    obj.selectEyeColor();
                    obj.selectUpperClothing();
                    obj.selectShirtColor();
                    obj.selectLowerClothing();
                    obj.selectAccessories();
                    obj.selectShoes();
                    obj.selectBag();
                    obj.selectWeapon();
                    obj.selectCompanion();
                    obj.selectMount();
                    obj.selectFaction();
                    obj.chosenOne();
                    obj.faction();

                    ConnectedSuccessfully.Open();
                    string insertToDatabase = $"INSERT INTO dbo.CHAR_INFO (Name, Gender, Weight, Height, Race, Class, [Skin Color], [Hair Length], [Hair Style], [Hair Color], [Eye Color], [Upper Clothing], [Lower Clothing], Accessories, Shoes, Bag, Weapon, Companion, Mount, Faction, STR, AGI, INT, VIT, DEX, LUK, HP, MP) VALUES('{obj.name}', '{obj.chosenGender}', '{obj.chosenWeight}', '{obj.chosenHeight}', '{obj.chosenRace}', '{obj.chosenClass}', '{obj.chosenSkinColor}', '{obj.chosenHairLength}', '{obj.chosenHairStyle}', '{obj.chosenHairColor}', '{obj.chosenEyeColor}', '{obj.chosenUpperClothing}', '{obj.chosenLowerClothing}', '{obj.chosenAccessories}', '{obj.chosenShoes}', '{obj.chosenBag}', '{obj.chosenWeapon}', '{obj.chosenCompanion}', '{obj.chosenMount}', '{!obj.isFactionless}',{obj.statV.statValue[0]}, {obj.statV.statValue[1]}, {obj.statV.statValue[2]}, {obj.statV.statValue[3]}, {obj.statV.statValue[4]}, {obj.statV.statValue[5]}, {obj.statV.statValue[6]}, {obj.statV.statValue[7]})";
                    SqlCommand insertMoTo = new SqlCommand(insertToDatabase, ConnectedSuccessfully);
                    insertMoTo.ExecuteNonQuery();
                    ConnectedSuccessfully.Close();
                    Main(args);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("-----------------------------");
                    ConnectedSuccessfully.Open();
                    SqlCommand LoadCheck = new SqlCommand("SELECT ID FROM dbo.CHAR_INFO", ConnectedSuccessfully);
                    string checker = LoadCheck.ExecuteScalar()?.ToString();
                    if (checker != null)
                    {
                        string selectFromDatabase = "SELECT * FROM dbo.CHAR_INFO";
                        SqlCommand selectMoTo = new SqlCommand(selectFromDatabase, ConnectedSuccessfully); using (SqlDataReader daer = selectMoTo.ExecuteReader())
                        {
                            while (daer.Read())
                            {
                                for (int i = 0; i < daer.FieldCount; i++)
                                {
                                    string columnName = daer.GetName(i);
                                    string columnValue = daer[i].ToString();
                                    Console.WriteLine($"{columnName}: {columnValue}");
                                }
                                Console.WriteLine("-----------------------------");
                            }
                            ConnectedSuccessfully.Close();
                        }
                    }
                    else
                    {
                        throw new Exception("No Character found!!\n");
                    }
                    Main(args);
                }
                else if (choice == 3)
                {
                    ConnectedSuccessfully.Open();
                    SqlCommand LoadCheck = new SqlCommand("SELECT ID FROM dbo.CHAR_INFO", ConnectedSuccessfully);
                    string checker = LoadCheck.ExecuteScalar()?.ToString();
                    if (checker != null)
                    {
                        Console.Write("Enter the character ID to delete: ");
                        int charIdToDelete;
                        if (int.TryParse(Console.ReadLine(), out charIdToDelete))
                        {
                            string deleteQuery = $"DELETE FROM dbo.CHAR_INFO WHERE ID = {charIdToDelete}";
                            string deleteName = $"SELECT Name FROM dbo.CHAR_INFO WHERE ID = {charIdToDelete}";

                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, ConnectedSuccessfully);
                            SqlCommand deletedName = new SqlCommand(deleteName, ConnectedSuccessfully);
                            string deletedCharacterName = deletedName.ExecuteScalar()?.ToString();

                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine($"Successfully deleted character {deletedCharacterName}!!\n");
                                Main(args);
                            }
                            else
                            {
                                throw new Exception($"No character found for ID {charIdToDelete}!!\n");
                            }
                        }
                        else
                        {
                            throw new Exception("Invalid Input!! Try Again!!\n");
                        }
                    }
                    else
                    {
                        throw new Exception("No Character found!!\n");
                    }

                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thank you!! \nGoodbye!!\n");
                    Environment.Exit(0);
                }
                else
                {
                    throw new InvalidInputException("Invalid Input!! Try Again!!\n");
                }
                bullyan = false;
            }
            catch (InvalidInputException ie)
            {
                Console.WriteLine(ie.Message);
                Main(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Main(args);
            }
            finally
            {
                ConnectedSuccessfully.Close();
            }
        }

    }
}
public class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base(message)
    {
    }
}
public class DatabaseException : Exception
{
    public DatabaseException(string message) : base(message)
    {
    }
}