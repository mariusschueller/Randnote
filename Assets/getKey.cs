using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getKey : MonoBehaviour
{
    public Text key;
    private int keyNum;
    int temp;

    public Button major;
    public Button minor;
    public Button getKeyButton;

    // Start is called before the first frame update
    void Start()
    {
        keyNum = -1;
        major.interactable = true;
        minor.interactable = true;
    }

    // Update is called once per frame
    /*void Update()
    {
    }*/

    public void majorButton()
    {
        if (major.interactable)
        {
            major.interactable = false;
        }
        else
        {
            major.interactable = true;
        }
            

        if (!(major.interactable || minor.interactable))
        {
            getKeyButton.interactable = false;
        }

        else if (!getKeyButton.interactable)
            getKeyButton.interactable = true;
    }

    public void minorButton()
    {
        if (minor.interactable)
            minor.interactable = false;
        else
            minor.interactable = true;

        if (!(major.interactable || minor.interactable))
        {
            getKeyButton.interactable = false;
        }

        else if(!getKeyButton.interactable)
            getKeyButton.interactable = true;
    }


    public void getNewKey()
    {
        temp = keyNum;

        if (major.interactable == true && minor.interactable == true)
        {
            keyNum = Random.Range(1, 31);

            while (keyNum == temp)
            {
                keyNum = Random.Range(1, 31);
            }

            identifyKey();
        }

        else if (major.interactable == true && minor.interactable == false)
        {
            keyNum = Random.Range(1, 16);

            while (keyNum == temp)
            {
                keyNum = Random.Range(1, 16);
            }

            identifyKey();
        }

        else 
        {
            keyNum = Random.Range(16, 31);

            while (keyNum == temp)
            {
                keyNum = Random.Range(16, 31);
            }

            identifyKey();
        }

    }

    void identifyKey()
    {
        if (keyNum == 1)
        {
            key.text = "C";
        }

        else if (keyNum == 2)
        {
            key.text = "G";
        }

        else if (keyNum == 3)
        {
            key.text = "D";
        }

        else if (keyNum == 4)
        {
            key.text = "A";
        }

        else if (keyNum == 5)
        {
            key.text = "E";
        }

        else if (keyNum == 6)
        {
            key.text = "B";
        }

        else if (keyNum == 7)
        {
            key.text = "F#";
        }

        else if (keyNum == 8)
        {
            key.text = "C#";
        }

        else if (keyNum == 9)
        {
            key.text = "F";
        }

        else if (keyNum == 10)
        {
            key.text = "Bb";
        }

        else if (keyNum == 11)
        {
            key.text = "Eb";
        }

        else if (keyNum == 12)
        {
            key.text = "Ab";
        }

        else if (keyNum == 13)
        {
            key.text = "Db";
        }

        else if (keyNum == 14)
        {
            key.text = "Gb";
        }

        else if (keyNum == 15)
        {
            key.text = "Cb";
        }

        else if (keyNum == 16)
        {
            key.text = "Am";
        }

        else if (keyNum == 17)
        {
            key.text = "Em";
        }

        else if (keyNum == 18)
        {
            key.text = "Bm";
        }

        else if (keyNum == 19)
        {
            key.text = "F#m";
        }

        else if (keyNum == 20)
        {
            key.text = "C#m";
        }

        else if (keyNum == 21)
        {
            key.text = "G#m";
        }

        else if (keyNum == 22)
        {
            key.text = "D#m";
        }

        else if (keyNum == 23)
        {
            key.text = "A#m";
        }

        else if (keyNum == 24)
        {
            key.text = "Dm";
        }

        else if (keyNum == 25)
        {
            key.text = "Gm";
        }

        else if (keyNum == 26)
        {
            key.text = "Cm";
        }

        else if (keyNum == 27)
        {
            key.text = "Fm";
        }

        else if (keyNum == 28)
        {
            key.text = "Bbm";
        }

        else if (keyNum == 29)
        {
            key.text = "Ebm";
        }

        else if (keyNum == 30)
        {
            key.text = "Abm";
        }
    }
}
