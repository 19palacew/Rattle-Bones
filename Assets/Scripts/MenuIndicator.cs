using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuIndicator : MonoBehaviour, IPointerEnterHandler
{
    public GameObject indicator;
    public GameObject newIndicatorPos;

    //Button
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        indicator.transform.position = newIndicatorPos.transform.position;
    }

}
