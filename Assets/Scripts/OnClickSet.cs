using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickSet : MonoBehaviour
{
    public Fighter fighter;
   

    public void SetAction(Text t)
    {
        fighter.action = t;
        Debug.Log(fighter.action);
        fighter.myTurn = false;
        fighter.panel.SetActive(false);
    }
}
