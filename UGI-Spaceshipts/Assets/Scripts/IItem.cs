using UnityEngine;

public interface IItem 
{
    string Name { get; }
    Sprite UIIcon { get; }
    int Damage { get; }
    int ClipSize { get; }
    int ClipReloadTime { get; }
}
