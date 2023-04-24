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
    [SerializeField] private GameObject UnitArea;
    [SerializeField] private GameObject ProductArea;


    public void SetInfoToPanel(Product Product)
    {
        ProductArea.SetActive(true);
        NameText.text = Product.name;
        InfoText.text = Product.ProductInfo;
        ProductImage.sprite = Product.ProductImage;
        if (Product.CanProduce == false) { UnitArea.SetActive(false); return; }
        UnitArea.SetActive(true);
        UnitNameText.text = Product.UnitName;
        UnitInfoText.text = Product.UnitInfo;
        UnitImage.sprite = Product.UnitProducedImage;
    }
}
