using UnityEngine;

public class ControlStructurs : MonoBehaviour



{
    [SerializeField] int a;

    [SerializeField] string Eredmény;

    void Start()
    {
        
        for (int i =1; i <= 100; i++)
        {
            Debug.Log(i);
        }
        

    
    }

    void WhileLoop()
    {
        int i = 1;
        int count = 0;

        while (i <= 10)
        {
            if (i % 3 == 0 && i % 7 == 0);
            {
                Debug.Log(i);
                count++;
            }
            i++;
        }
    }

    void OnValidate()
    {

    }
}
