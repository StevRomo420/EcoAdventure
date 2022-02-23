using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MoverIteamRegadera : MonoBehaviour, IDragHandler
{
    public float z = 0.0f;
    public Vector3 posicionInicio = new Vector3(0, 0, 0);
    public RegaderaAnimacion Animacion;
    void Start()
    {

        Animacion = GetComponent<RegaderaAnimacion>();
        posicionInicio = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (Animacion.quieto == false)
        {
            Vector3 mousePosicion = Input.mousePosition;
            mousePosicion.z = z;
            transform.position = Camera.main.ScreenToWorldPoint(mousePosicion);
        }


    }
    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine(Example());
        }

    }
    IEnumerator Example()
    {
        if (Animacion.quieto == false)
        {
            yield return new WaitForSeconds(2.2f);
            transform.position = posicionInicio;
        }
        else
        {

            transform.position = posicionInicio;
        }


    }
}

