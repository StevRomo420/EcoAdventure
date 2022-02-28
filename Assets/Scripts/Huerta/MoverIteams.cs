using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MoverIteams : MonoBehaviour, IDragHandler
{
    public float z = 0.0f;
    public Vector3 posicionInicio = new Vector3(0, 0, 0);

    void Start()
    {
        posicionInicio = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosicion = Input.mousePosition;
        mousePosicion.z = z;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosicion);
    }
    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            transform.position = posicionInicio;
        }

    }

}
