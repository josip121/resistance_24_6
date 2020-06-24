using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tipka : MonoBehaviour
{
    public string tipka;

    public void PosaljiTipku()
    {
        this.transform.GetComponentInParent<Alarm>().UnosLozinke(tipka);
    }

    void OnMouseDown()
    {
        PosaljiTipku();
    }
}
