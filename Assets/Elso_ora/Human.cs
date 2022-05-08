using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] string firstName = "NO NAME";
    [SerializeField] string familyName = "NO NAME";
    [SerializeField, Min(1900)] int Born = 1950;
    [SerializeField, Range( 50, 300)] float height = 160;
    [SerializeField] bool isAlive = true;

    [Space]
    [SerializeField] bool Blabla;
    [SerializeField] bool KrixKrax;

    // Blabla
    // �lnie kell
    // Magasabb 165 cm de kisebb 200
    // 2000 vagy az ut�n sz�letett

    // KrikszKrax
    // Kisebb 180cm-n�l, vagy nagyobb 210cm-n�l
    // Ha a keresztneved �s vezet�kneved megegyezik felvesnek.

    private void OnValidate()
    {
        bool highIsRight = height > 165 && height < 200;
        bool ageIsRight = Born >= 1950;

        Blabla = isAlive && highIsRight && ageIsRight;

        highIsRight = height  < 180 && height > 210;
        bool keresztnev = firstName == familyName;
        KrixKrax = highIsRight || keresztnev;
    }
}