using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SolicitarIteams : MonoBehaviour
{
    [SerializeField]
    public GameObject[] items;
    [SerializeField]
    public float xBounds, yBounds;
    [SerializeField]
    public float time;
    public bool Viva = true;
    public bool primera = true;
    public bool Colicion = false;
    string Tag = "";
    GameObject iteam;
    AnimacionesPlanta animacion;
    bool Primeros1K = true;
    bool Primeros2K = true;
    bool Primeros3K = true;
    public Jugador p2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
        animacion = GetComponent<AnimacionesPlanta>();
        GameObject prueba = GameObject.Find("Jugador");
        p2 = prueba.GetComponent<Jugador>();
    }


    // Update is called once per frame

    IEnumerator SpawnRandomGameObject()
    {

        float randomTime = Random.Range(time, time * 2);
        yield return new WaitForSeconds(randomTime);
        Dificultad();

        int randomIteam = Random.Range(0, items.Length);

        if (Random.value <= items.Length)
        {

            iteam = Instantiate(items[randomIteam]) as GameObject;

            iteam.transform.position = new Vector2(xBounds, yBounds);
            Tag = iteam.tag;
            Colicion = false;
            yield return new WaitForSeconds(3.5f);


            DestruirOdgeto();
            Tag = "";

            if (Colicion)
            {

            }
            else
            {
                animacion.Marchitar();
                time = 0;
                Viva = false;

            }
        }
        if (Viva)
        {
            StartCoroutine(SpawnRandomGameObject());
        }



    }
    public string ObtenerTag()
    {

        return Tag;
    }
    public void DestruirOdgeto()
    {
        Tag = "";
        Destroy(iteam);
    }

    public void Dificultad()
    {
        if (primera)
        {
            time += 5;
            primera = false;
        }
        if (p2.puntos >= 1000 && Primeros1K)
        {
            Primeros1K = false;
            time -= 4;
        }
        if (p2.puntos >= 2000 && Primeros2K)
        {
            Primeros2K = false;
            time -= 2;
        }
        if (p2.puntos >= 3000 && Primeros3K)
        {
            Primeros3K = false;
            time -= 0.2f;
        }
    }
}