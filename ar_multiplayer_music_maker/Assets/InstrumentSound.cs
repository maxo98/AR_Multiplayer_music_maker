using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentSound : MonoBehaviour
{
    //Avoir le son actuel de l'instrument en variable public
    public AudioClip actualSound;
    public AudioClip[] soundList =  new AudioClip[4];

    //Pouvoir changer le son en fonction de l'orientation de la fiche :

    //On fait en sorte que la valeur ne dépasse pas un certain seuil
    public void ResetAngle()
    {
        float value = transform.eulerAngles.y;
        if (value >= 360)
        {
            value -= 360;
            transform.eulerAngles = new Vector3(0,value,0);
        }
        else if(value <= -360)
        {
            value += 360;
            transform.eulerAngles = new Vector3(0, value, 0);
        }
    }

    private void Update()
    {
        ResetAngle();
    }
    //avoir une liste static de son ~ 4 sons par instrument

}
