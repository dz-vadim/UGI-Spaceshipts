using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AssetItem))]

public class ItemEditor : Editor
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
                assesItem.DamageResistance = EditorGUILayout.IntField("Damage Resistance", assesItem.DamageResistance);
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
        item.RateOfFire = EditorGUILayout.FloatField("RateOfFire", item.RateOfFire);
        item.ClipSize = EditorGUILayout.IntField("ClipSize", item.ClipSize);
        item.ClipReloadTime = EditorGUILayout.IntField("ClipReloadTime", item.ClipReloadTime);
        item.PumpingLevel = EditorGUILayout.IntField("PumpingLevel", item.PumpingLevel);
    }
}
