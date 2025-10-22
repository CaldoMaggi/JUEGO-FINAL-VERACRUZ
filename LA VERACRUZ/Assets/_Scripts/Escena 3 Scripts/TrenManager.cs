using System.Collections;
using UnityEngine;

public class TrenManager : MonoBehaviour
{
    [SerializeField]
    private GameObject tren;
   
    void Start()
    {
        StartCoroutine(TrenLoop());
    }


    IEnumerator TrenLoop()
    {
        tren.SetActive(true);

        yield return new WaitForSeconds(6);
        tren.SetActive(false);
        tren.transform.position = new Vector3(-35.7f , -6.8f, 0);
        yield return new WaitForSeconds(1);

       StartCoroutine(TrenLoop());
    }
}
