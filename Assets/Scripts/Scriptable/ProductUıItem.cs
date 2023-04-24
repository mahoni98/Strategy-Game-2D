using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/ProductData", fileName = "ProductData")]
public class ProductUýItem : ScriptableObject
{
    public Sprite Image;
    public Type WhichBuild;
    public enum Type
    {
        Barracks,
        PowerPlant
    }
}
