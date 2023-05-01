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
        ProductUýItem.Type Type = Btn.GetComponent<ProductMenuBtn>()._ProductUýItem.WhichBuild;
        GameManager.Instance.UpdateState(GameState.BuildPlacement);

        switch (Type)
        {
            case ProductUýItem.Type.Barracks:
                _ConCreteFactoryBarrack.GetProduct(_GridElement);
                break;
            case ProductUýItem.Type.PowerPlant:
                _ConCreteFactoryPowerPlant.GetProduct(_GridElement);
                break;
            case ProductUýItem.Type.OtherBuild:
                _ConCreteFactoryOtherBuilds.GetProduct(_GridElement);
                break;

            default:
                break;
        }
    }
}
