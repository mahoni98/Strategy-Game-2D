using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class GridElement : MonoBehaviour, IPointerEnterHandler
{
    public bool ThereAreSomething = false;
    public Image RedImage;
    //[SerializeField] private List<DiceSetRedZone> Counter;


    bool OneTime = false;


    private void Start()
    {
        //GameManager.Instance.OnAttack += BoxOnAttack;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //if (collision.GetComponent<DiceSetRedZone>() != null)
        //{
        //    if (DragManager.Instance.Entry != false)
        //    {
        //        ThereAreDice = true;
        //    }
        //    collision.GetComponent<DiceSetRedZone>().ZarType(true, name, collision);
        //}
        //else if (collision.GetComponent<EnemyController>() != null)
        //{
        //    collision.GetComponent<EnemyController>().CurrentGridElemet(name);
        //    ThereAreEnemy = true;
        //}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.GetComponent<DiceSetRedZone>() != null)
        //{
        //    ThereAreDice = false;
        //    collision.GetComponent<DiceSetRedZone>().ZarType(false, name, collision);
        //}
        //else if (collision.GetComponent<EnemyController>() != null)
        //{
        //    ThereAreEnemy = false;
        //}
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //if (DragManager.Instance.Entry == true) return;
        //if (ThereAreDice == false && ThereAreEnemy == false)
        //{
        //    //DragManager.Instance.SetPosition(transform);
        //    //DragManager.Instance.CurrentGrid = transform;
        //}
    }
    public void BoxOnAttack()
    {
        //if (DamageValue != 0)
        //{
        //    Instantiate(Fire, transform.position, transform.rotation, transform);
        //}
        //ThereAreDice = false;
    }
    public void TriggerCounter(Collider2D collision, int _DamageValue)
    {
        //int a = Counter.IndexOf(collision.GetComponent<DiceSetRedZone>());
        //if (a == -1)
        //{
        //    Counter.Add(collision.GetComponent<DiceSetRedZone>());
        //    DamageValueSet(_DamageValue);
        //}
        //else if (Counter.Count == 1)
        //{
        //    DamageText.text = "" + Counter[0]._DiceAttack.DiceValue;
        //    //DamageText.text = "" + DamageValue;
        //    //DamageValueSet(_DamageValue);
        //    //if (DamageValue != _DamageValue)
        //    //{
        //    //    DamageValue = 0;
        //    //    DamageValueSet(_DamageValue);
        //    //}
        //    DamageValueSet(DamageText.text.ToInt());
        //}
        //else if (Counter.Count == 2)
        //{

        //    int AttackValue = 0;

        //    foreach (var item in Counter)
        //    {
        //        AttackValue += item._DiceAttack.DiceValue;
        //        DamageText.text = "" + AttackValue;
        //    }
        //    DamageValueSet(AttackValue);

        //    //DamageValueSet(_DamageValue);
        //    //if (DamageValue != _DamageValue)
        //    //{
        //    //    DamageValue = 0;
        //    //    DamageValueSet(_DamageValue);
        //    //}
        //}
        //else if (Counter.Count == 3)
        //{
        //    int AttackValue = 0;

        //    foreach (var item in Counter)
        //    {
        //        AttackValue += item._DiceAttack.DiceValue;
        //        DamageText.text = "" + AttackValue;
        //    }
        //    DamageValueSet(AttackValue);
        //    //DamageValueSet(_DamageValue);
        //    //if (DamageValue != _DamageValue)
        //    //{
        //    //    DamageValue = 0;
        //    //    DamageValueSet(_DamageValue);
        //    //}
        //}

        //DamageText.text = "" + DamageValue;
    }
    public void TriggerNegativeCounter(Collider2D collision, int DamageValue)
    {
        //Counter.Remove(collision.GetComponent<DiceSetRedZone>());
        //DamageValueSet(-DamageValue);
    }
    public void SetRedImageOpacity()
    {
        //var tempColor = RedImage.color;
        //tempColor.a = 0.30f * Counter.Count;
        //RedImage.color = tempColor;
    }
    void DamageValueSet(int Value)
    {
        //DamageValue = Value;
        //if (DamageValue > 0)
        //{
        //    DamageText.text = "" + DamageValue;
        //}
        //else
        //{
        //    DamageText.text = "";
        //    DamageValue = 0;
        //}
    }
}
