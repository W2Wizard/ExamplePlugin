using Flax.Build;

public class ExamplePluginTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("ExamplePlugin");
    }
}
