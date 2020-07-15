using System;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu (menuName ="Item")]
public class AssesItem : ScriptableObject, IItem
{
    public string Name => _name;
    public Sprite UIIcon => _uiIcon;

    public int Damage => _damage;
    public int ClipSize => _clipSize;
    public int ClipReloadTime => _clipReloadTime;

    [SerializeField] private int _damage;
    [SerializeField] private int _clipSize;
    [SerializeField] private int _clipReloadTime;

    [SerializeField] private string _name;
    [SerializeField] private Sprite _uiIcon;

    public enum objectType
    {
       MachineGun,
       MachineGun2x,
       PlasmaCannon,
       СombinationGun2x,
       SmallEngine,
       LargeEngine,
       EnergySheild,
       MachinePlasmaShield,
       HPRegenerator
    }


    public void SetObjectProperties()
    {

    }


}

/*

public class AssetEditor : Editor
{
    private AssesItem _assetItem;
    [SerializeField] private AssesItem.objectType _objectType;

    private int mydamage;

    public void OnEnable()
    {
        _assetItem = (AssesItem)target;
    }

    public void SetObjectProperties(IItem item)
    {

        switch (_objectType)
        {
            case AssesItem.objectType.MachineGun:

                mydamage = item.Damage;
                Debug.Log("0");
                break;
        }
    }

    public override void OnInspectorGUI()
    {


    }

    
}
*/
