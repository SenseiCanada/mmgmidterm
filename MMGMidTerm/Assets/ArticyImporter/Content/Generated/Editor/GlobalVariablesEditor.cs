//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Mmgmidterm.GlobalVariables;
using Articy.Unity.Editor.PropertyDrawer;
using System;
using System.Collections;
using UnityEditor;
using UnityEngine;


namespace Articy.Mmgmidterm
{
    
    
    [CustomEditor(typeof(Articy.Mmgmidterm.GlobalVariables.ArticyGlobalVariables))]
    public class GlobalVariablesDrawer : GlobalVariablesEditor
    {
    }
    
    public class GlobalVariablesMenuItems
    {
        
        [UnityEditor.MenuItem("Tools/articy:draft Importer/Advanced/Create GlobalVariables")]
        public static void CreateNewGlobalVariables()
        {
Articy.Unity.Editor.Utils.ArticyEditorUtility.CreateGlobalVariablesClone<Articy.Mmgmidterm.GlobalVariables.ArticyGlobalVariables>();
        }
    }
}