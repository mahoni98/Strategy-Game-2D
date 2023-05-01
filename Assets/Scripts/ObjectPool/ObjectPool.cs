using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public Arrow prefab;
    public int size;

    private List<Arrow> objectList;
    public Transform BornTransform;

    private void Awake()
    {
        objectList = new List<Arrow>();

        for (int i = 0; i < size; i++)
        {
            Arrow obj = Instantiate(prefab, FindObjectOfType<Canvas>().transform);
            obj.transform.localPosition = BornTransform.localPosition;
            obj.transform.parent = BornTransform;
            obj.gameObject.SetActive(false);
            objectList.Add(obj);
        }
    }

    public Arrow GetObject()
    {
        foreach (Arrow obj in objectList)
        {
            if (!obj.gameObject.activeInHierarchy)
            {
                obj.gameObject.SetActive(true);
                return obj;
            }
        }
        return null;
    }
}
