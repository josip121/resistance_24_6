using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorController : MonoBehaviour
{
	// Referenca na razini klase
	public bool lockedByDoor = false;
	public Animator anim;
	void Start()
	{
		// Spremim referencu na komponentu
		// start funkcija se poziva samo jednom pa će se i dohvaćanje komponente dogoditi samo jednom
		anim = GetComponentInChildren<Animator>();
	}

	// Ova funkcija se stalno poziva sve dok igrač stoji u prostoru collidera
	// pa zato nije dobro da u svakoj iteraciji dohvaća komponentu s kojom možda niti neće ništa napraviti
	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{
			if (Input.GetKeyDown(KeyCode.E) && !lockedByDoor)
				anim.SetTrigger("OpenClose");
		}
	}

	public void Open()
	{
		anim.SetTrigger("OpenClose");
	}
}