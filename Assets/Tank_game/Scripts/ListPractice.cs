using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{

    [SerializeField] int[] array; //t�mb
    [SerializeField] List<string> list; // lista

    void Start()
    {
        Debug.Log(array.Length);
        Debug.Log(list.Count);

        Debug.Log(array[1]);
        Debug.Log(list[1]);

        // array = a k�sz t�mb m�ret�t nem tudom v�ltoztatni
        // list= v�ltoz� hossz�s�g. 

        list.Add("dsds"); // hozz�ad a list�hoz/t�mbh�z
        list.Remove("d"); // elvesz
        list.RemoveAt(3);
        list.Insert(3, "dsdsdsd"); // addott helyre besz�r�s
        bool isContains = list.Contains("ds"); //tartalmazza-e a megadott lelmet True or falsh
        list.Clear(); // �sszes elem t�rl�se
        list.Sort(); // sorbarendez�s
    }

}
