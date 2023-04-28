using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ProductMenuBtn : ProductMenuOperations
{
    [SerializeField] private TextMeshProUGUI BtnNameText;
    [SerializeField] private Image BtnImage;
    void Start()
    {
        GetBtnItem(BtnNameText, BtnImage);
        Button Btn = GetComponent<Button>();
        ClickToCreate ClickFonk = FindObjectOfType<ClickToCreate>();
        GetComponent<Button>().onClick.AddListener(() => ClickFonk.GetProductAtClick(Btn));
    }
}
