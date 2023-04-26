
using UnityEngine;
public class Soldier1 : Soldier, IProduct
{

    public void Die()
    {
        throw new System.NotImplementedException();
    }
    void IProduct.Damage()
    {
        throw new System.NotImplementedException();
    }
}
