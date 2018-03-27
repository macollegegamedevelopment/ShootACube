using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour 
{
    public Text UIText;
    public int lives = 3;

	private void Start()
	{
        UpdateUI();
	}

	private void OnTriggerEnter(Collider other)
	{
        if (other.tag == "Cube")
        {
            TakeDamage();
        }
	}

    private void TakeDamage()
    {
        lives--;

        UpdateUI();

        if (lives <= 0)
        {
            print("Game Over!");
        }
    }

    private void UpdateUI()
    {
        UIText.text = "Lives: " + lives.ToString();   
    }
}
