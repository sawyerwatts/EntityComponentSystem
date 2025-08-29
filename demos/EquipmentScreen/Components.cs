namespace EquipmentScreen;

public class CharacterStatsComponent(Character character)
{
    public Character Character { get; set; } = character;
    public int Experience { get; set; }

    public int BaseMaxHealth { get; set; } = 100;
    public int BaseDefense { get; set; }
    public int BaseAttack { get; set; } = 10;

    public Weapon? Weapon { get; set; }
    public Armor? Armor { get; set; }

    public int MaxHealth { get; set; }
    public int CurrHealth { get; set; }
    public int Defense { get; set; }
    public int Attack { get; set; }

    public List<Ring> Rings { get; set; } = [];
}
