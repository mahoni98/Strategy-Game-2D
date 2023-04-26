using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTarget : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;

    public Transform Create()
    {
        GameObject Target = Instantiate(Prefab, FindObjectOfType<Canvas>().transform);
        //Target.transform.localPosition = CreatePos.localPosition;
        return Target.transform;
    }

}
