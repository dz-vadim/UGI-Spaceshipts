using System;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu(fileName ="New Item" ,menuName = "Item")]
public class AssetItem : ScriptableObject, IItem
{    
    public string UIName => _name;
    public Sprite UIIcon => _uiIcon;


    [SerializeField] private string _name;
    [SerializeField] private Sprite _uiIcon;

    [HideInInspector] public int Damage;
    [HideInInspector] public float RateOfFire;
    [HideInInspector] public int ClipSize;
    [HideInInspector] public int ClipReloadTime;
    [HideInInspector] public int EnginePower;
    [HideInInspector] public int DamageResistance;
    [HideInInspector] public int RegenerationValue;
    [HideInInspector] public int PumpingLevel = 1;
    public GameObject ImplementPrefab;


    public enum objectType
    {
        MachineGun,
        MachineGun2x,
        PlasmaCannon,
        СombinationGun2x,
        SmallEngine,
        LargeEngine,
        EnergySheild,
        Machine_Plasma_Shield,
        HPRegenerator
    }

   public objectType ObjectType;
}

