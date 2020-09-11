using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

//solamente funciona en celular, lo que permite es agarrar y arrastrar al personaje.
    void Update()
    {
        if (Input.touchCount > 0 )
        {

          Touch touch = Input.GetTouch(0);
          Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Moved)

            {
                transform.position = new Vector2 (touchPosition.x, touchPosition.y);
            }


        }

    }
}
