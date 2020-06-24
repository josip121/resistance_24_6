using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alarm : MonoBehaviour
{
    public DoorController door;
    public string lozinka;
    public int ogranicenjeLozinke;
    public Text tekstLozinke;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip tocnaLozinka;
    public AudioClip netocnaLozinka;

    private void Start()
    {
        tekstLozinke.text = "";
    }

    public void UnosLozinke(string broj)
    {
        if(broj == "Brisanje")
        {
            Brisanje();
            return;
        }
        else if(broj == "Unos")
        {
            Unos();
            return;
        }

        int duzina = tekstLozinke.text.ToString().Length;

        if (duzina < ogranicenjeLozinke)
        {
            tekstLozinke.text = tekstLozinke.text + broj;
            if(tekstLozinke.text == lozinka)
            {
                door.Open();
            }
        }
    }

    public void Brisanje()
    {
        tekstLozinke.text = "";
        tekstLozinke.color = Color.white;
    }

    private void Unos()
    {
        if (tekstLozinke.text == lozinka)
        {
  
            if (audioSource != null)
                audioSource.PlayOneShot(tocnaLozinka);

            tekstLozinke.color = Color.green;
            StartCoroutine(obrisiZaslon());
        }
        else
        {
            if (audioSource != null)
                audioSource.PlayOneShot(netocnaLozinka);

            tekstLozinke.color = Color.red;
            StartCoroutine(obrisiZaslon());
        }
    }

    IEnumerator obrisiZaslon()
    {
        yield return new WaitForSeconds(0.75f);
        Brisanje();
    }
}
