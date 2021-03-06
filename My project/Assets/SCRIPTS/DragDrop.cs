using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject Canvas;
    private bool isDragging = false;
    private bool isOverDropZone = false;
    private GameObject dropZone;
    private GameObject StartParent;
    private Vector2 startPosition;

    private void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
            if (isDragging)
        { 
                transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }
    }

       /* public void OnMouseDown()
    {
        
            playerCard.transform.SetParent(dropZone.transform, false);
        
    }*/
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }
    public void StartDrag()
    {
        StartParent = transform.parent.gameObject;
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;

        if (isOverDropZone)
            transform.SetParent(dropZone.transform, false);

        else
        {
            transform.position = startPosition;
            transform.SetParent(StartParent.transform, false);
        }
    }

    
}
