using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle : MonoBehaviour
{
    public GameObject log;

    public Fighter mage;
    public Fighter woman;
    public Fighter man;

    public Fighter rat;
    public Fighter spider;
    public Fighter slime;

    public bool playerPhase;

    // Start is called before the first frame update
    void Start()
    {
        playerPhase = true;

        mage.setActions("fire", "water", "ice", "wind", "earth", "plant", "light", "electro", "cloud", "miracle");
        mage.chooseActions();

    }

    private void newRound()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerPhase)
        {
            if (mage.myTurn)
            {
                mage.panel.SetActive(true);
                if (!mage.myTurn)
                {
                    log.GetComponent<Text>().text += "aaaaaaaaaaaaa";
                }
            }
            else if (man.myTurn)
            {
                man.panel.SetActive(true);
                if (!man.myTurn)
                {
                    log.GetComponent<Text>().text += "cccccccccccccccc";
                }
            }
            else if (woman.myTurn)
            {
                woman.panel.SetActive(true);
                if (!woman.myTurn)
                {
                    log.GetComponent<Text>().text += "bbbbbbbbbbbbbbb";
                    playerPhase = false;
                }
            }           
        }
        else
        {
            //enemy phase

            //auswertung

            if (rat.owner.activeInHierarchy)
            {
                if (man.owner.activeInHierarchy) man.changeHealth(-15);
                else if (woman.owner.activeInHierarchy) woman.changeHealth(-15);
                if (mage.owner.activeInHierarchy) mage.changeHealth(-15);
            }
            if (spider.owner.activeInHierarchy)
            {
                if (man.owner.activeInHierarchy) man.changeHealth(-20);
                else if (woman.owner.activeInHierarchy) woman.changeHealth(-20);
                if (mage.owner.activeInHierarchy) mage.changeHealth(-20);
            }
            if (spider.owner.activeInHierarchy)
            {
                if (man.owner.activeInHierarchy) man.changeHealth(-10);
                else if (woman.owner.activeInHierarchy) woman.changeHealth(-10);
                if (mage.owner.activeInHierarchy) mage.changeHealth(-10);
            }
        }
    }    

}
