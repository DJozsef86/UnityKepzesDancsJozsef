using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{

    [SerializeField] int[] array; //tömb
    [SerializeField] List<string> list; // lista

    void Start()
    {
        Debug.Log(array.Length);
        Debug.Log(list.Count);

        Debug.Log(array[1]);
        Debug.Log(list[1]);

        // array = a kész tömb méretét nem tudom változtatni
        // list= változó hosszúság. 

        list.Add("dsds"); // hozzáad a listához/tömbhöz
        list.Remove("d"); // elvesz
        list.RemoveAt(3);
        list.Insert(3, "dsdsdsd"); // addott helyre beszúrás
        bool isContains = list.Contains("ds"); //tartalmazza-e a megadott lelmet True or falsh
        list.Clear(); // összes elem törlése
        list.Sort(); // sorbarendezés
    }

}
