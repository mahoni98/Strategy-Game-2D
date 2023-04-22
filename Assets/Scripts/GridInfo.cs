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
    public List<Transform> willExplosinGrid;

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
                //Item.DamageText = Item.gridElementScript.DamageText;
                Item.Name = Item.gridElementScript.name;
                Item.Object = Item.gridElementScript.gameObject.transform;
                gridItems.Add(Item);
            }
            Counter += 39;
        }
    }

    //public List<GridElement> FindDamageZoneHorizontal(string Name, bool Open, Collider2D collision, int DamageValue)
    //{
    //    int CurrentSatir = 0;
    //    List<GridElement> list = new List<GridElement>();
    //    foreach (GridItem item in gridItems)
    //    {
    //        if (Name == item.Name)
    //        {
    //            CurrentSatir = item.Satir;
    //        }
    //    }
    //    foreach (GridItem item2 in gridItems)
    //    {
    //        if (item2.Satir == CurrentSatir)
    //        {
    //            SetRedZone(Open, item2, collision, DamageValue);
    //            list.Add(item2.gridElementScript);
    //        }
    //    }
    //    return list;
    //}
    //public List<GridElement> FindDamageZoneVertical(string Name, bool Open, Collider2D collision, int DamageValue)
    //{
    //    int currenSutun = 0;
    //    List<GridElement> list = new List<GridElement>();

    //    foreach (GridItem item in gridItems)
    //    {
    //        if (Name == item.Name)
    //        {
    //            currenSutun = item.Sutun;
    //        }
    //    }
    //    foreach (GridItem item2 in gridItems)
    //    {
    //        if (item2.Sutun == currenSutun)
    //        {
    //            SetRedZone(Open, item2, collision, DamageValue);
    //        }
    //    }
    //    return list;
    //}
    //public List<GridElement> FindDamageZoneEverywhere(string Name, bool Open, Collider2D collision, int DamageValue)
    //{
    //    int CurrentSatir = 0;
    //    int currenSutun = 0;
    //    List<GridElement> list = new List<GridElement>();


    //    foreach (GridItem item in gridItems)
    //    {
    //        if (Name == item.Name)
    //        {
    //            currenSutun = item.Sutun;
    //            CurrentSatir = item.Satir;
    //            SetRedZone(Open, item, collision, DamageValue);

    //            list.Add(item.gridElementScript);
    //        }
    //    }
    //    foreach (GridItem item2 in gridItems)
    //    {
    //        if (item2.Satir == CurrentSatir && item2.Sutun - 1 == currenSutun)
    //        {
    //            SetRedZone(Open, item2, collision, DamageValue);

    //            list.Add(item2.gridElementScript);

    //        }
    //        else if (item2.Satir == CurrentSatir && item2.Sutun + 1 == currenSutun)
    //        {
    //            SetRedZone(Open, item2, collision, DamageValue);

    //            list.Add(item2.gridElementScript);

    //        }
    //        else if (item2.Satir - 1 == CurrentSatir && item2.Sutun == currenSutun)
    //        {
    //            SetRedZone(Open, item2, collision, DamageValue);

    //            list.Add(item2.gridElementScript);
    //        }
    //        else if (item2.Satir + 1 == CurrentSatir && item2.Sutun == currenSutun)
    //        {

    //            SetRedZone(Open, item2, collision, DamageValue);

    //            list.Add(item2.gridElementScript);
    //        }
    //    }
    //    return list;
    //}



    //public EnemyGridInfo FindWillGoPosition(string Name)
    //{
    //    int CurrentSatir = 0;
    //    int CurrentSutun = 0;
    //    EnemyGridInfo _EnemyGridInfo = new EnemyGridInfo();

    //    foreach (GridItem item in gridItems)
    //    {
    //        if (Name == item.Name)
    //        {
    //            CurrentSatir = item.Satir;
    //            CurrentSutun = item.Sutun;
    //            //_EnemyGridInfo.DamageValue = item.gridElementScript.DamageValue;
    //            _EnemyGridInfo._GridElement = item.gridElementScript;
    //        }
    //    }
    //    foreach (GridItem item2 in gridItems)
    //    {
    //        if (item2.Satir == CurrentSatir - 1 && item2.Sutun == CurrentSutun)
    //        {
    //            _EnemyGridInfo.WillGoGrid = item2.gridElementScript;
    //        }
    //    }
    //    if (CurrentSatir == 1)
    //    {
    //        _EnemyGridInfo.EnemyAttack = true;
    //        _EnemyGridInfo.Continue = false;
    //        return _EnemyGridInfo;
    //    }
    //    else
    //    {
    //        _EnemyGridInfo.EnemyAttack = false;
    //    }


    //    for (int i = 1; i < CurrentSatir; i++)
    //    {
    //        foreach (var item in gridItems)
    //        {
    //            if (item.Satir == i && item.Sutun == CurrentSutun)
    //            {
    //                if (item.gridElementScript.ThereAreEnemy == false)
    //                {
    //                    _EnemyGridInfo.Continue = true;
    //                    return _EnemyGridInfo;
    //                }
    //                else
    //                {
    //                    _EnemyGridInfo.Continue = false;
    //                }
    //            }
    //        }
    //    }
    //    return _EnemyGridInfo;
    //}
    public Transform GetClosestGrid(Transform DiceTransform)
    {
        Transform tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = DiceTransform.position;
        foreach (var t in gridItems)
        {
            float dist = Vector3.Distance(t.Object.position, currentPos);
            if (t.gridElementScript.ThereAreSomething == false /*&& t.gridElementScript.ThereAreEnemy == false*/)
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
