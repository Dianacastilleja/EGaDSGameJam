using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public int currentHealth;  // The current health of the player
	public int startingHealth = 100;  // The amount of health the player starts with
	public Slider slider;
	public Gradient gradient;
	public Image fill;
    bool isDead;  // Whether the player is dead
    bool damaged;  // Whether the player has been damaged

	public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;

		fill.color = gradient.Evaluate(1f);
	}

    public void SetHealth(int health)
	{
		slider.value = health;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}
	 public void TakeDamage (int amount)
    {
        // If the player is already dead, exit the function
        if (isDead)
           return;
           //make monster play dead animation

        // Reduce the player's health by the damage amount
        currentHealth -= amount;
        // Update the UI slider to reflect the new health value
        slider.value = currentHealth;

        // Set the damaged flag to true to flash the damage image in the Update function
        damaged = true;

        // If the player's health is zero or less, call the Death function
        if (currentHealth <= 0)
        {
            Death ();
        }
    }
	public void RestoreHealth(int restoreAmount)
    {
        restoreAmount = 100; 
        currentHealth += restoreAmount; // add the restore amount to the player's current health

        if (currentHealth > startingHealth)
        {
            currentHealth = startingHealth; // if the player's current health is greater than the maximum health, set it to the maximum health
             slider.value = currentHealth;
        }
    }

    void Death ()
    {
        // Set the dead flag to true
        isDead = true;

        // TODO: Add any death effects or animations here
            
        // Disable the player GameObject so they can't move or take further damage
        gameObject.SetActive(false);
    }

}