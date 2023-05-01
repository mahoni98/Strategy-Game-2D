using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GetProductInfo : SingletonManager<GetProductInfo>
{

    [Header("Product")]
    [SerializeField] private TextMeshProUGUI NameText;
    [SerializeField] private TextMeshProUGUI InfoText;
    [SerializeField] private Image ProductImage;



    [Header("Unit Produced")]
    [SerializeField] private TextMeshProUGUI UnitNameText;
    [SerializeField] private TextMeshProUGUI UnitInfoText;
    [SerializeField] private Image UnitImage;


    [Header("GameObjects")]
    [SerializeField] private GameObject UnitsArea;
    [SerializeField] private GameObject ProductArea;
    [SerializeField] private Transform Content;



    [Header("Scripts")]
    [NonReorderable] private Product Product;


   

    public void SetInfoToPanel(Product _Product)
    {
        Product = _Product;
        ProductArea.SetActive(true);
        NameText.text = Product.Name;
        InfoText.text = Product.ProductInfo;
        ProductImage.sprite = Product.ProductImage;
        if (Product.CanProduce == false) { UnitsArea.SetActive(false); return; }
        UnitsArea.SetActive(true);
        _Product.CreateUnitBtn(Product.transform, Content);
    }
   
}
