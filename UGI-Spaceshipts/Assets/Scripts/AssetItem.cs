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

    [HideInInspector] public int Damage = 0;
    [HideInInspector] public int RateOfFire = 0;
    [HideInInspector] public int ClipSize = 0;
    [HideInInspector] public int ClipReloadTime = 0;
    [HideInInspector] public int EnginePower = 0;
    [HideInInspector] public int DamagResistance = 0;
    [HideInInspector] public int RegenerationValue = 0;


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

[CustomEditor(typeof(AssetItem))]

public class AssetItemEditor : Editor
{
    override public void OnInspectorGUI()
    {
        base.DrawDefaultInspector();
        var assesItem = target as AssetItem;
        
        switch (assesItem.ObjectType)
        {
            case AssetItem.objectType.SmallEngine:
                EditorGUILayout.LabelField("Medium slot", EditorStyles.boldLabel);
                assesItem.EnginePower = EditorGUILayout.IntField("Engine Power", assesItem.EnginePower);
                break;

            case AssetItem.objectType.LargeEngine:
                EditorGUILayout.LabelField("Hard slot", EditorStyles.boldLabel);
                assesItem.EnginePower = EditorGUILayout.IntField("Engine Power", assesItem.EnginePower);
                break;

            case AssetItem.objectType.EnergySheild:
                EditorGUILayout.LabelField("Medium slot", EditorStyles.boldLabel);
                assesItem.DamagResistance = EditorGUILayout.IntField("Damage Resistance", assesItem.DamagResistance);
                break;

            case AssetItem.objectType.Machine_Plasma_Shield:
                EditorGUILayout.LabelField("Hard slot", EditorStyles.boldLabel);
                break;                

            case AssetItem.objectType.HPRegenerator:
                EditorGUILayout.LabelField("Hard slot", EditorStyles.boldLabel);
                assesItem.RegenerationValue = EditorGUILayout.IntField("Regeneration Value", assesItem.RegenerationValue);
                break; 
                
            case AssetItem.objectType.MachineGun2x:
                EditorGUILayout.LabelField("Medium slot", EditorStyles.boldLabel);
                SetGunProperties(assesItem);
                break;
                
            case AssetItem.objectType.СombinationGun2x:
                EditorGUILayout.LabelField("Hard slot", EditorStyles.boldLabel);
                SetGunProperties(assesItem);
                break;                

            default:
                EditorGUILayout.LabelField("Light slot", EditorStyles.boldLabel);
                SetGunProperties(assesItem);
                break;
        }
    }

    public void SetGunProperties(AssetItem item)
    {
        item.Damage = EditorGUILayout.IntField("Damage", item.Damage);
        item.RateOfFire = EditorGUILayout.IntField("RateOfFire", item.RateOfFire);
        item.ClipSize = EditorGUILayout.IntField("ClipSize", item.ClipSize);
        item.ClipReloadTime = EditorGUILayout.IntField("ClipReloadTime", item.ClipReloadTime);
    }
}