using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
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

}
