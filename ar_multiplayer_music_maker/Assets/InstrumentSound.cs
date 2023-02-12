using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentSound : MonoBehaviour
{
    //Avoir le son actuel de l'instrument en variable public
    public AudioClip actualSound;
    public AudioClip[] soundList =  new AudioClip[4];

    [SerializeField]float myEulerAngle;

    //Pouvoir changer le son en fonction de l'orientation de la fiche :

    //On fait en sorte que la valeur ne dépasse pas un certain seuil
    public void ResetAngle()
    {
        myEulerAngle = transform.eulerAngles.y;
        if (myEulerAngle >= 360)
        {
            myEulerAngle -= 360;
            transform.eulerAngles = new Vector3(0, myEulerAngle, 0);
        }
        else if(myEulerAngle <= -360)
        {
            myEulerAngle += 360;
            transform.eulerAngles = new Vector3(0, myEulerAngle, 0);
        }
    }

    public void ChooseAudio()
    {
        if (myEulerAngle >= 0 && myEulerAngle <=90)
        {
            actualSound = soundList[0];
        }
        else if(myEulerAngle > 90 && myEulerAngle <=180)
        {
            actualSound = soundList[1];
        }
        else if (myEulerAngle > 180 && myEulerAngle <= 270)
        {
            actualSound = soundList[2];
        }
        else if (myEulerAngle > 270 && myEulerAngle < 360)
        {
            actualSound = soundList[3];
        }
    }
    private void Update()
    {
        ResetAngle();
        ChooseAudio();
    }
    //avoir une liste static de son ~ 4 sons par instrument

}
