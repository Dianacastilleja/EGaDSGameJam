using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
  public int HP=100;

  public void TakeDamage(int damageAmount)
  {
    HP-=damageAmount;
    if(HP<=0)
    {
        //play death animation
        Destroy(gameObject);	
    }
  }
}
