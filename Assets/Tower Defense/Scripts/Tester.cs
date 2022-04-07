using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
          Camera.main.transform.position.z));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
          if (hit.transform.tag == "Enemy")
          {
            hit.transform.GetComponent<Enemy>().Damage();
          }
          else
            print("I'm looking at nothing!");

      }
    }
}
