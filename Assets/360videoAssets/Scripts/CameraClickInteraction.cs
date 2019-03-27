using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClickInteraction : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector2(0.5f, 0.5f));
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit, 100))
            {
                GameObject hitGameObject = hit.collider.gameObject;
                InteractWithHitGameObject(hitGameObject);
            }             
        }
    }

    public void InteractWithHitGameObject(GameObject hitGameObject)
    {
        if(hitGameObject.GetComponent<ObjectSwitchVideo>() != null)
        {
            hitGameObject.GetComponent<ObjectSwitchVideo>().SwitchVideoClip();
        }
    }
}
