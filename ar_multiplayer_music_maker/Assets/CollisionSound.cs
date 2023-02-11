using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    AudioClip sound;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        //base :
        //recup l'id de la collision
        //jouer le son de l'instrument
        sound = collision.gameObject.GetComponent<InstrumentSound>().actualSound;

        // Avancé :
        //stocker l'id dans une liste dynamique et par ordre
    }
}
