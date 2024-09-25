using System.ComponentModel;
using Unity.VisualScripting;

#region enums

public enum Quality : byte
{
    Low = 0,
    Average = 1,
    High = 2,
    Ultra = 3
}

public enum Complexity : byte
{
    Easy = 0,
    Average = 1,
    Hard = 2
}

public enum Startkit : byte
{
    None = 0,
    Civil = 1,
    Military = 2,
    Premium = 3
}

public enum Language : byte
{
    Russian = 0
}

public enum BiomType : byte
{
    // handmaded
    Road = 0,
    Railroad = 1,
    // terrain
    Desert = 1,
    Wasteland = 2,
    Field = 1,
    Tundra = 4,
    Mountain = 6,
    // forest
    Forest = 7,
    // water
    Bridge = 1,
    Sea = 9,
    FreshLake = 10,
    SaltLake = 11,
    River = 12,
    Shore = 13,
    Swamp = 14
}

public enum BiomEffects : byte
{
    Radioactive = 0,
    Destroyed = 1
}
#endregion

#region interfaces
public interface Biom
{

}
#endregion

#region structures
[Description("int x, int y")]
internal struct PlayerPosition
{
    internal int x;
    internal int y;
    internal PlayerPosition(int _x, int _y){
        x = _x;
        y = _y;
    }
}

[Description("int x, int y")]
internal struct AccuratePosition
{
    internal float x { get; set; }
    internal float y { get; set; }
    internal AccuratePosition(float _x, float _y)
    {
        x = _x;
        y = _y;
    }
}
#endregion

#region classes
[Description("biomEffects, ushort[][] colliderCoordinates")]
internal class Chunk
{
    internal byte x { get; set; }
    internal byte y { get; set; }
    internal _Biom[] biomCoordinates {get; set;}
    internal Chunk(byte x, byte y, _Biom[] biomCoordinates)
    {
        this.x = x;
        this.y = y;
        this.biomCoordinates = biomCoordinates;
    }
}
internal class RequiredChunks
{
    internal Chunk[] chunks { get; set; }
}
internal class _Biom
{
    internal byte biom { get; set;}
    internal byte[] effects { get; set;}
    internal AccuratePosition[] colliderCoordinates { get; set;}
    internal _Biom(byte biom, byte[] effects, AccuratePosition[] colliderCoordinates)
    {
        this.biom = biom;
        this.effects = effects;
        this.colliderCoordinates = colliderCoordinates;
    }
}
#endregion
