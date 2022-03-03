using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
       Debug.Log("OnPointerClick");
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
       Debug.Log("OnBeginDrag");
       // throw new System.NotImplementedException();
    }
    public void OnEndDrag(PointerEventData eventData)
    {
       Debug.Log("OnEndDrag");
       // throw new System.NotImplementedException();
    }
    public void OnDrag(PointerEventData eventData)
    {
       Debug.Log(" OnDrag");
       // throw new System.NotImplementedException();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
