using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
   public void getRed(){
       this.GetComponent<Renderer>().material.color= Color.red;
   }

   public void getBlue(){
       this.GetComponent<Renderer>().material.color= Color.blue;
   }

   public void getGreen(){
       this.GetComponent<Renderer>().material.color= Color.green;
   }
}
