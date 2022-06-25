using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Damagable : MonoBehaviour
{
    public int health = 3;
    [SerializeField] TMP_Text healtText;
    [SerializeField] GameObject gameOverSreen;

    int startHealth;

    private void Start()
    {
        startHealth = health;
        UpdateText();
    }
    public void DoDamage(int damage)

    {
        if (health <= 0)
            return;

        if (health >= damage)
            health -= damage;
        else
            health = 0;

        UpdateText();

        if (gameOverSreen != null)
        {
            if (health <= 0)
                gameOverSreen.SetActive(true);
        }
    }

    void UpdateText()
    {
            if (healtText != null)
             healtText.text = $"Health: {health}";
    }

    public void RestartDamagable()
    {
        health = startHealth;
        gameOverSreen.SetActive(false);
        UpdateText();
    }
}
