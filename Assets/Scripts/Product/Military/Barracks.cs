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
    public Barracks AskerUret(string askerTipi)
    {
        switch (askerTipi)
        {
            case "Asker1":
                //return new Soldier1();
            case "Asker2":
                //return new Asker2();
            case "Asker3":
                //return new Asker3();
            default:
                throw new ArgumentException("Geçersiz asker tipi: " + askerTipi);
        }
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
