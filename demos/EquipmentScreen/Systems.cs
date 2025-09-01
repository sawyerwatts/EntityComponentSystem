namespace EquipmentScreen;

public class ResetActiveStatsFromBaseStatsSystem
{
    public void Apply(
        CharacterBaseStatsComponent baseStats,
        CharacterActiveStatsComponent activeStats)
    {
        activeStats.MaxHealth = baseStats.Vitality * 100;
    }
}

public class ApplyGearEffectsToActiveStats
{
    public void Apply(
        CharacterActiveStatsComponent activeStats,
        CharacterGearComponent gear)
    {
        foreach (Ring ring in gear.Rings)
        {
            switch (ring)
            {
                case Ring.SmallBeingsRing:
                    activeStats.MaxHealth += 300;
                    break;
                case Ring.DuskCrownRing:
                    activeStats.MaxHealth /= 2;
                    if (activeStats.CurrDamage > activeStats.MaxHealth)
                        // this math seems sus but idc
                        activeStats.CurrDamage -= activeStats.MaxHealth;
                    break;
            }
        }
    }
}
