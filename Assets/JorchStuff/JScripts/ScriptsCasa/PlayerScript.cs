using System;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   [SerializeField] private float PlayerSpeed;

   private void FixedUpdate()
   //Movimiento
   {
      Vector2 direction = transform.position.normalized;
      if (Input.GetAxis("Horizontal") > 0)
      {
         direction.x += PlayerSpeed * Time.deltaTime;
      }
      else if (Input.GetAxis("Horizontal") < 0)
         {
         direction.x -= PlayerSpeed * Time.deltaTime;
         }
      //movimiento en x
      if (Input.GetAxis("Horizontal") > 0)
      {
         direction.x += PlayerSpeed * Time.deltaTime;
      }
      else if (Input.GetAxis("Horizontal") < 0)
      {
         direction.x -= PlayerSpeed * Time.deltaTime;
      }
      //movimiento en y
      if (Input.GetAxis("Vertical") > 0)
      {
         direction.y += PlayerSpeed * Time.deltaTime;
      }
      else if (Input.GetAxis("Vertical") < 0)
      {
         direction.y -= PlayerSpeed * Time.deltaTime; 
      }
      
      transform.position = direction;
      
   }
}
