namespace EquipmentScreen;

public class CharacterStatsComponent(Character character)
{
    public Character Character { get; set; } = character;
    public int BaseHealth { get; set; }
    public int BaseDefense { get; set; }
    public int BaseAttack { get; set; }

    public Weapon? Weapon { get; set; }
    public ArmorSet? Armor { get; set; }

    public List<Ring> Rings { get; set;  } = [];
}
