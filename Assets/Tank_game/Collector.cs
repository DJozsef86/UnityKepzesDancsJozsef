using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collector : MonoBehaviour
{
    [SerializeField] int collectedValue;
    [SerializeField] TMP_Text CoinText;

    void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.GetComponent<Collectable>();
        if (collectable != null)

        { 
            collectedValue+= collectable.value;
            collectable.Collect();

            UpdateText();
        }


    }
    void UpdateText()
    {
        if (CoinText != null)
            CoinText.text = $"Score: {collectedValue}";
    }

    public void RestartCollactable()
    {
        collectedValue = 0;
    }
}
