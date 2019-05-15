using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    [SerializeField] private Text _level;

    void Update()
    {
       RaycastHit _hit;
       Ray _ray = new Ray(gameObject.transform.position, gameObject.transform.forward);

       if (Physics.Raycast(_ray, out _hit))
       {
          if (_hit.collider.tag.Equals("Sphere"))
          {
             _level.text = _hit.collider.name;
             if (Input.GetKey("return") && _hit.collider.gameObject.GetComponent<Sphere>().accept)
               Application.LoadLevel(_hit.collider.name);
          }
          else
             _level.text = " ";
       }
       Moves();
    }

   void Moves()
   {
      if (Input.GetKey("left") && gameObject.transform.position.x > -40f)
         gameObject.transform.Translate(-1f,0f,0f);
      if (Input.GetKey("right") && gameObject.transform.position.x < 40f)
         gameObject.transform.Translate(1f,0f,0f);
   }
}
