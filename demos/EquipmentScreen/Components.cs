namespace EquipmentScreen;

// TODO: systems
//      ResetActiveStats: per update
//      EquipRing(SmallBeingsRing): flat increase to maxhealth
//      UnequipRing(SmallBeingsRing): flat increase to maxhealth
//      EquipRing(DuskCrownRing): reuse inflict curse's health debuff (but don't kill, and subtract half max health from curr damage so don't instantly die)
//      UnequipRing(DuskCrownRing): reuse inflict curse's health debuff (but don't kill, and subtract half max health from curr damage so don't instantly die)

public class CharacterBaseStatsComponent(Character character)
{
    public Character Character { get; set; } = character;

    public int Vitality { get; set; } = 1;
}

public class CharacterActiveStatsComponent(Character character)
{
    public Character Character { get; set; } = character;

    public int MaxHealth { get; set; } = 1;

    public int CurrDamage { get; set; }
}

public class CharacterGearComponent(Character character)
{
    public Character Character { get; set; } = character;

    public Weapon? Weapon { get; set; }
    public Armor? Armor { get; set; }

    public List<Ring> Rings { get; set; } = [];
}
