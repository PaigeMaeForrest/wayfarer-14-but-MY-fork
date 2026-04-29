using System.Numerics;
using Robust.Shared.GameStates;
using Robust.Shared.Utility;

namespace Content.Shared.Clothing;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(HelmetAccessoriesSystem))]

public sealed partial class HelmetAccessoriesComponent : Component
{
    [DataField, AutoNetworkedField]
    public SpriteSpecifier.Rsi Rsi;

    [DataField, AutoNetworkedField]
    public SpriteSpecifier.Rsi? HatRsi;

    [DataField, AutoNetworkedField]
    public SpriteSpecifier.Rsi? ToggledRsi;

    [DataField, AutoNetworkedField]
    public SpriteSpecifier.Rsi? HatToggledRsi;

    [DataField, AutoNetworkedField]
    public Vector2 Offset;
}
