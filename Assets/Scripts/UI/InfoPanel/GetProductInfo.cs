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
    [SerializeField] private GameObject UnityCreateButton;


    [Header("Scripts")]
    [SerializeField] private ClickToCreateUnit _ClickToCreateUnit;
    [SerializeField] private Product Product;

    private void Start()
    {
        _ClickToCreateUnit = FindObjectOfType<ClickToCreateUnit>();
        UnityCreateButton.GetComponent<Button>().onClick.AddListener(() => CreateUnit());
    }

    public void SetInfoToPanel(Product _Product)
    {
        Product = _Product;
        ProductArea.SetActive(true);
        NameText.text = Product.Name;
        InfoText.text = Product.ProductInfo;
        ProductImage.sprite = Product.ProductImage;
        if (Product.CanProduce == false) { UnitArea.SetActive(false); return; }
        UnitArea.SetActive(true);
        UnitNameText.text = Product.UnitName;
        UnitInfoText.text = Product.UnitInfo;
        UnitImage.sprite = Product.UnitProducedImage;
        PrepareButton();
    }
    public void PrepareButton()
    {
        if (Product.CanProduce)
        {
            UnityCreateButton.SetActive(true);
        }
    }

    public void CreateUnit()
    {
        _ClickToCreateUnit.GetProductAtClick(Product.ProductType, Product.transform);
    }
}
