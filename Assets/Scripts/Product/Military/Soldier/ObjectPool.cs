using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    public int size;

    private List<GameObject> objectList;
    public Transform BornTransform;

    private void Awake()
    {
        objectList = new List<GameObject>();

        for (int i = 0; i < size; i++)
        {
            GameObject obj = Instantiate(prefab, FindObjectOfType<Canvas>().transform);
            obj.transform.localPosition = BornTransform.localPosition;
            obj.transform.parent = BornTransform;
            obj.SetActive(false);
            objectList.Add(obj);
        }
    }

    public GameObject GetObject()
    {
        foreach (GameObject obj in objectList)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }
        return null;
    }
}
