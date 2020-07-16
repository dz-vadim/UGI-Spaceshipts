using System;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu(menuName = "Item")]
public class AssesItem : ScriptableObject, IItem
{
    public string Name => _name;
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

[CustomEditor(typeof(AssesItem))]

public class AssetItemEditor : Editor
{
    override public void OnInspectorGUI()
    {
        base.DrawDefaultInspector();
        var assesItem = target as AssesItem;
        
        switch (assesItem.ObjectType)
        {
            case AssesItem.objectType.SmallEngine:
                EditorGUILayout.LabelField("Medium slot", EditorStyles.boldLabel);
                assesItem.EnginePower = EditorGUILayout.IntField("Engine Power", assesItem.EnginePower);
                break;

            case AssesItem.objectType.LargeEngine:
                EditorGUILayout.LabelField("Hard slot", EditorStyles.boldLabel);
                assesItem.EnginePower = EditorGUILayout.IntField("Engine Power", assesItem.EnginePower);
                break;

            case AssesItem.objectType.EnergySheild:
                EditorGUILayout.LabelField("Medium slot", EditorStyles.boldLabel);
                assesItem.DamagResistance = EditorGUILayout.IntField("Damage Resistance", assesItem.DamagResistance);
                break;

            case AssesItem.objectType.Machine_Plasma_Shield:
                EditorGUILayout.LabelField("Hard slot", EditorStyles.boldLabel);
                break;                

            case AssesItem.objectType.HPRegenerator:
                EditorGUILayout.LabelField("Hard slot", EditorStyles.boldLabel);
                assesItem.RegenerationValue = EditorGUILayout.IntField("Regeneration Value", assesItem.RegenerationValue);
                break; 
                
            case AssesItem.objectType.MachineGun2x:
                EditorGUILayout.LabelField("Medium slot", EditorStyles.boldLabel);
                SetGunProperties(assesItem);
                break;
                
            case AssesItem.objectType.СombinationGun2x:
                EditorGUILayout.LabelField("Hard slot", EditorStyles.boldLabel);
                SetGunProperties(assesItem);
                break;                

            default:
                EditorGUILayout.LabelField("Light slot", EditorStyles.boldLabel);
                SetGunProperties(assesItem);
                break;
        }
    }

    public void SetGunProperties(AssesItem item)
    {
        item.Damage = EditorGUILayout.IntField("Damage", item.Damage);
        item.RateOfFire = EditorGUILayout.IntField("RateOfFire", item.RateOfFire);
        item.ClipSize = EditorGUILayout.IntField("ClipSize", item.ClipSize);
        item.ClipReloadTime = EditorGUILayout.IntField("ClipReloadTime", item.ClipReloadTime);
    }
}

