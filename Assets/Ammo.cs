using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ammo : MonoBehaviour
{
    [SerializeField] int ammoAmount = 60;
    public Text text;


    private void Update()
    {
        text.text = ammoAmount.ToString();

    }

    public int GetCurrentAmmo()
    {
        return ammoAmount;
    }

    public void ReduceCurrentAmmo()
    {
        ammoAmount--;
    }


  


}

