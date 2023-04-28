using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//using Manager.Singleton;
using TMPro;

public class GridInfo : SingletonManager<GridInfo>
{
    public List<GridItem> gridItems;

    int Counter = 0;
    private void Start()
    {
        int Size = transform.childCount;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < 39; j++)
            {
                GridItem Item = new GridItem();
                Item.Satir = i + 1;
                Item.Sutun = j + 1;
                Item.gridElementScript = transform.GetChild(j + Counter).GetComponent<GridElement>();
                Item.Name = Item.gridElementScript.name;
                Item.Object = Item.gridElementScript.gameObject.transform;
                gridItems.Add(Item);
            }
            Counter += 39;
        }
    }
   
    public Transform GetClosestGrid(Transform Transform)
    {
        Transform tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = Transform.position;
        foreach (var t in gridItems)
        {
            float dist = Vector3.Distance(t.Object.position, currentPos);
            if (t.gridElementScript.ThereAreSomething == false)
            {
                if (dist < minDist)
                {
                    tMin = t.Object;
                    minDist = dist;
                }
            }
        }
        return tMin;
    }

    [Serializable]
    public class GridItem
    {
        public string Name;
        public int Satir;
        public int Sutun;
        public GridElement gridElementScript;
        public Transform Object;
    }
}
