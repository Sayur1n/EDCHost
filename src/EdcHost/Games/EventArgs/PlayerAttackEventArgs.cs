namespace EdcHost.Games;

public class PlayerAttackEventArgs : EventArgs
{
    /// <summary>
    /// The player that moved.
    /// </summary>
    public IPlayer Player { get; }

    public int Strength { get; }

    /// <summary>
    /// The position the player attack.
    /// </summary>
    public IPosition<float> Position { get; }

    public PlayerAttackEventArgs(IPlayer player, int strength, IPosition<float> position)
    {
        Player = player;
        Strength = strength;
        Position = position;
    }
}
