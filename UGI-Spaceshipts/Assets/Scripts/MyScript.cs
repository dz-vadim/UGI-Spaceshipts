using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class MyScript : MonoBehaviour
{
    public bool hideBool;
    public bool disableBool;
    public int someNumber = 1;
    public Color someColor;
    public String someString;
    
}

[CustomEditor(typeof(MyScript))]
public class MyScriptEditor : Editor
{
    override public void OnInspectorGUI()
    {
        var myScript = target as MyScript;

        myScript.hideBool = EditorGUILayout.Toggle("Hide Fields", myScript.hideBool);
        EditorGUILayout.Space();
        using (var group = new EditorGUILayout.FadeGroupScope(Convert.ToSingle(myScript.hideBool)))
        {
            if (group.visible == false)
            {
                EditorGUI.indentLevel++;
                EditorGUILayout.Space();

               // EditorGUILayout.PrefixLabel("Color");
                EditorGUILayout.Space();

                myScript.someColor = EditorGUILayout.ColorField(myScript.someColor);
                EditorGUILayout.Space();

                //EditorGUILayout.PrefixLabel("Text");
                EditorGUILayout.Space();

                myScript.someString = EditorGUILayout.TextField(myScript.someString);
                EditorGUILayout.Space();

               // EditorGUILayout.PrefixLabel("Number");
                EditorGUILayout.Space();

                myScript.someNumber = EditorGUILayout.IntSlider(myScript.someNumber, 0, 10);
                EditorGUILayout.Space();

                EditorGUI.indentLevel--;
            }
        }

        myScript.disableBool = GUILayout.Toggle(myScript.disableBool, "Disable Fields");

        using (new EditorGUI.DisabledScope(myScript.disableBool))
        {
            myScript.someColor = EditorGUILayout.ColorField("Color", myScript.someColor);
            myScript.someString = EditorGUILayout.TextField("Text", myScript.someString);
            myScript.someNumber = EditorGUILayout.IntField("Number", myScript.someNumber);
        }
    }
}