using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipt : MonoBehaviour
{
    public int HitPoints { get; } = 100;
    [Range(1, 10)]
    public int level = 1;
    public int numberOfSlots = 3;
    public int moveSpeed = 1;
    public int levelOfSlot = 1;
}
