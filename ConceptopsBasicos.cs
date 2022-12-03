using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    public int myInteger = 5;
    public float myFloat = 3.5f;
    public bool myBool = true;
    public string myString = "Hello World";

    // Esta funcion se va ejecutar cuando un script esta adjuntado como componente (es la primera llamada)
    //cuando se activa un objeto en la escena
    private void Awake() {
        Debug.Log("I'm attached as component of an object in the scene! ");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Valor del estero = " + this.myInteger);
        myInteger += 5;
        Debug.Log("Valor despues de la suma: " + this.myInteger);

        string result = IsEven(this.myInteger) ? "Es par" : "No es par";

        Debug.Log(result);

        //la funcion GetComponent nos optinene el componente del objeto
        SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>();

        if(mySpriteRenderer == null) Debug.Log("Is null!!");
        else{
            //Optener el primer objeto de la escena que tenga un componente SpriteRenderer
            GameObject anObjectWithSpriteRenderer = FindObjectOfType<SpriteRenderer>().gameObject;

            //Buscar un objeto que tenga el tag pasado como argumento
            GameObject anObjectWithTag = GameObject.FindWithTag("Player");

            //Buscar un objeto con el nombre pasado en el argumento
            GameObject anObjectWithName = GameObject.FindWithTag("Whatever name you now");

            //componentes
            if(mySpriteRenderer != null) mySpriteRenderer.enabled = false;

            //objetos
            if(anObjectWithTag != null) anObjectWithTag.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    bool IsEven(int num)
	{
		return num % 2 == 0;
	}
}
