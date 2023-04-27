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
        ProductUýItem.Type Type = Btn.GetComponent<ProductMenuBtn>()._ProductUýItem.WhichBuild;
        switch (Type)
        {

            case ProductUýItem.Type.Barracks:
                _ConCreteFactoryBarrack.GetProduct(_GridElement);
                break;
            case ProductUýItem.Type.PowerPlant:
                _ConCreteFactoryPowerPlant.GetProduct(_GridElement);
                break;
            //case ProductUýItem.Type.Soldier:
            //    _ConCreteFactorySoldier.GetProduct(_GridElement);
            //    break;

            default:
                break;
        }
    }
}
