using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class ProductClickControl : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private GameObject AttackButton;
    private void Start()
    {
        AttackButton.GetComponent<Button>().onClick.AddListener(Attack);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (SoldierMoveManager.Instance._CurrentSoldierAI != null)
            AttackButton.SetActive(true);
    }

    public void Attack()
    {
        SoldierMoveManager.Instance.MoveForAttack(transform);
        AttackButton.SetActive(false);

    }
}
