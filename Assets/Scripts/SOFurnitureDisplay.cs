using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="FurnitureDisplay", menuName="Furniture Display Asset")]
public class SOFurnitureDisplay : ScriptableObject
{
    [Tooltip("Furniture Prefab")]
    public GameObject prefab;

    [Tooltip("Title of Asset")]
    public string title;

    [Tooltip("Decsription of Asset")]
    public string description;

}
