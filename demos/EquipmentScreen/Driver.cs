using Spectre.Console;

namespace EquipmentScreen;

// TODO: this demo
//      have a screen to perform various ops (ctl for many chars?)
//          view stats (raw and w/ modifiers)
//              health
//              defense
//              attack
//          un/equip dagger, scimitar, zweihander
//          un/equip none, light, medium, or heavy armor
//          un/equip some rings
//              small being's ring
//              red tearstone
//              ring of blades
//          inflict variable damage (respect armor)
//          heal variable health instantly or gradually
//          apply poison
//              have variable buildup and decay?
//          tick poison
//          cure poison
//      entities
//          character
//          weapons
//          armors
//          rings
//      components
//          base stats: health, def, attack, weight
//          statuses
//          stat modifier, with additive+overrideBool and multiplicative fields per stat
//      systems
//          un/equip equipment
//          inflict variable damage
//          instant or gradual variable healing
//          apply/cure poison
//          tick game on every (non-view stats) action
//              poison
//              gradual healing

public class Driver
{
    public Task RunAsync(CancellationToken cancellationToken)
    {
        // TODO: start coding here
        AnsiConsole.WriteLine("Start coding here");
        return Task.CompletedTask;
    }

    public static void RegisterTo(IHostApplicationBuilder builder)
    {
        builder.Services.AddTransient<Driver>();
    }
}

