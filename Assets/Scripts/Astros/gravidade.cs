using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gravidade : MonoBehaviour
{
    public GameObject Nave;
    private float escalaAstro;
    // Start is called before the first frame update
    void Start()
    {
        escalaAstro = transform.localScale.x * 5;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position,Nave.transform.position);
        Vector3 distancia = transform.position - Nave.transform.position;
        float vel = transform.localScale.x / (100*dist);
        if (dist < escalaAstro)
        {
            Nave.transform.Translate(distancia*vel*Time.deltaTime);
        }
    }
}
