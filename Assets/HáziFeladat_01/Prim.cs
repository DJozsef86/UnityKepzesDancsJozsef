using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int szamlalo = 0; //sz�molja, hogy meglegyen a 100 darab
        int szam = 1; // a sz�m amit ellen�riz

       while (szamlalo != 100) // a 100 darab primig fusson a ciklus
        {

            int osztoszamlalo = 0;  //sz�molja, h�ny oszt�ja van

            for (int i = 2; i < szam; i++)
            
            {

                if (szam % i == 0) 
                
                {
                    osztoszamlalo++;
                }
            }

            if (osztoszamlalo == 0)
                {

                    Debug.Log(szam);
                    szamlalo++;

                }

                szam++;

            }   

        }

    }

