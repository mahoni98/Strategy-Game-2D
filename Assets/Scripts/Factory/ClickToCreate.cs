using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToCreate : MonoBehaviour
{
    public Transform _GridElement;
    public ConCreteFactoryBarrack _ConCreteFactoryBarrack;
    public ConCreteFactoryPowerPlant _ConCreteFactoryPowerPlant;
    public ConCreteFactoryOtherBuilds _ConCreteFactoryOtherBuilds;


    public void GetProductAtClick(Button Btn)
    {
        if (PopUpControl.Instance.StateControl() == false) return;
        ProductU�Item.Type Type = Btn.GetComponent<ProductMenuBtn>()._ProductU�Item.WhichBuild;
        GameManager.Instance.UpdateState(GameState.BuildPlacement);

        switch (Type)
        {
            case ProductU�Item.Type.Barracks:
                _ConCreteFactoryBarrack.GetProduct(_GridElement);
                break;
            case ProductU�Item.Type.PowerPlant:
                _ConCreteFactoryPowerPlant.GetProduct(_GridElement);
                break;
            case ProductU�Item.Type.OtherBuild:
                _ConCreteFactoryOtherBuilds.GetProduct(_GridElement);
                break;

            default:
                break;
        }
    }
}
