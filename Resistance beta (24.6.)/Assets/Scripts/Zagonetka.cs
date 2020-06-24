using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zagonetka : MonoBehaviour
{
    public GameObject Tekst;
    public GameObject Kocka;
    // Start is called before the first frame update
    void Start()
    {
        Tekst.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player")
        {
            Tekst.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        Tekst.SetActive(false);
    }
}
