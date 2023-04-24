using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProductMenuOperations : ProductUI
{

    public void GetBtnItem(TextMeshProUGUI BtnNameText, Image BtnImage)
    {
        BtnNameText.text = BtnName;
        BtnImage.sprite = _ProductUıItem.Image;
    }

}
