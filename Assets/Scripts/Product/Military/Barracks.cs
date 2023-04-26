using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Barracks : MilitaryProduct, IProduct
{
    public Transform RandomPos;
    private void Start()
    {

    }
    
    public void Die()
    {
        throw new NotImplementedException();
    }

    public void Damage()
    {
        throw new NotImplementedException();
    }

   
}
