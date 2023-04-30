using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
  public  Animator animator1,animator2;
    string[] ani = new string[] { "Dice 1", "Dice 2", "Dice 3", "Dice 4", "Dice 5", "Dice 6" };

    public void Throw()
    {
       
            
            int rand1 = Random.Range(0, ani.Length);
            int rand2 = Random.Range(0, ani.Length);
            animator1.Play(ani[rand1], -1, 0);
            animator2.Play(ani[rand2], -1, 0);
          
    }
}
