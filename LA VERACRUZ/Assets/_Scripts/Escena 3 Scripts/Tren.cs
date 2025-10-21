using System.Collections;
using UnityEngine;

public class Tren : MonoBehaviour
{
    public float velocidad = 5f;
    public bool meMuevo;
    void Update()
    {
            // Mueve el objeto constantemente hacia la derecha (eje X positivo)
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);


    }

}
    

