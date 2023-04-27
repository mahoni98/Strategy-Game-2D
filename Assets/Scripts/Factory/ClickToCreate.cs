using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToCreate : MonoBehaviour
{
    public Transform _GridElement;
    public ConCreteFactoryBarrack _ConCreteFactoryBarrack;
    public ConCreteFactoryPowerPlant _ConCreteFactoryPowerPlant;
    public ConCreteFactorySoldier _ConCreteFactorySoldier;

    public void GetProductAtClick(Button Btn)
    {
        // check click with raycast
        ProductU�Item.Type Type = Btn.GetComponent<ProductMenuBtn>()._ProductU�Item.WhichBuild;
        switch (Type)
        {

            case ProductU�Item.Type.Barracks:
                _ConCreteFactoryBarrack.GetProduct(_GridElement);
                break;
            case ProductU�Item.Type.PowerPlant:
                _ConCreteFactoryPowerPlant.GetProduct(_GridElement);
                break;
            //case ProductU�Item.Type.Soldier:
            //    _ConCreteFactorySoldier.GetProduct(_GridElement);
            //    break;

            default:
                break;
        }
    }
}
