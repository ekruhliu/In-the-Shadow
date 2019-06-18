using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
   [SerializeField] private Text _level;
   [SerializeField] private GameObject[] spheres;
   private Player _player;

   private void Start()
   {
      _player = this.gameObject.GetComponent<Player>();
      /*spheres[0] = _player.lvl1;
      spheres[1] = _player.lvl2;
      spheres[2] = _player.lvl3;
      spheres[3] = _player.lvl4;
      spheres[4] = _player.lvl5;*/
   }

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
               SceneManager.LoadScene(_hit.collider.name);
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
