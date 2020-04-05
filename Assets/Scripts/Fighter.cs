using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fighter : MonoBehaviour
{
    public Button skill1;
    public Button skill2;
    public Button skill3;

    public GameObject panel;

    public bool myTurn = true;

    public Text action;
    private int actionNumber;

    public string[] actions;

    public int h = 100;

    public GameObject owner;

    public void changeHealth(int value)
    {
        h += value;
        checkHealth();
    }

    public void setHealth(int value)
    {
        h = value;
        checkHealth();
    }

    private void checkHealth()
    {
        if (h <= 0) owner.SetActive(false);
    }

    //Start is called before the first frame update
    void Start()
    {
        //skill1 = GameObject.Find("Skill 1").GetComponent<UnityEngine.UI.Button>();
        //skill2 = GameObject.Find("Skill 2").GetComponent<UnityEngine.UI.Button>();
        //skill3 = GameObject.Find("Skill 3").GetComponent<UnityEngine.UI.Button>();

        //panel = GameObject.Find("Panel").GetComponent<GameObject>();
        panel.SetActive(false);
    }

    public void setActions(string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10)
    {
        actions = new string[10];

        actions[0] = a1;
        actions[1] = a2;
        actions[2] = a3;
        actions[3] = a4;
        actions[4] = a5;
        actions[5] = a6;
        actions[6] = a7;
        actions[7] = a8;
        actions[8] = a9;
        actions[9] = a10;

    }

    public void chooseActions()
    {       
        skill1.GetComponentInChildren<Text>().text = actions[Random.Range(0, 10)];
        skill2.GetComponentInChildren<Text>().text = actions[Random.Range(0, 10)];
        skill3.GetComponentInChildren<Text>().text = actions[Random.Range(0, 10)];
    }
}
