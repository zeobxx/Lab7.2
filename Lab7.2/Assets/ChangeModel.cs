using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
   public void getAnimatorWalk(){
       this.GetComponent<Animator>().Play("Catwalk Walk Turn 180 Tight");
   }
   public void getAnimatorDance(){
       this.GetComponent<Animator>().Play("Dancing Maraschino Step");
   }
}
