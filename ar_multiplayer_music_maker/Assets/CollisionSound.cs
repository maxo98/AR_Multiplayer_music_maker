using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    AudioClip sound;
    [SerializeField]AudioSource mySource;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        //base :
        //recup l'id de la collision
        //jouer le son de l'instrument

        mySource.clip = other.gameObject.GetComponent<InstrumentSound>().actualSound;
        mySource.PlayOneShot(mySource.clip);
        

        // Avancé :
        //stocker l'id dans une liste dynamique et par ordre
    }
}
