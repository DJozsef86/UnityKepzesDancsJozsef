using UnityEngine;

public class Methdod_p : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    [Space]
    [SerializeField] float max; // maximum
    [SerializeField] float min; // minimum
    [SerializeField] float AbsoluteValue; //abszolut �rt�k
    [SerializeField] float sign; //minusz az �t�k vagy nem
    [SerializeField] float power;
    // MathF.sqrt (n�gyzetgy�kvon�s)
    // MathF.Pow (alap, kitev�) hatv�nyra emel�s pl: (5, 3)== 5*5*5


    void OnValidate()
    {
        max = Mathf.Max(a, b);
        min = Mathf.Min(a, b);
        AbsoluteValue = Mathf.Abs(a);
        sign = Mathf.Sign(a);
        power = Mathf.Pow(a, b);
    }

    float Maximum(float a, float b) 
    {
        if (a > b)
            return a;

        else
            return b; //vagy: return a > b ? a : b; 

    }

    float Abszolutertek (float a) 
    
    {
        if (a > 0)
            return a;

        else
            return -a;  //vagy: return a > 0 ? a : -0;

    }

    float Power(float b, int x) 

    {
        float result = 1;
        for (int i = 0; i < x; i++)
        {
            result *= b;
        }

        return result;
    }
        

}
