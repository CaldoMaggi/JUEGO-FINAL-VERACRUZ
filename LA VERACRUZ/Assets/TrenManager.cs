using System.Collections;
using UnityEngine;

public class TrenManager : MonoBehaviour
{
    [SerializeField]
    private GameObject tren;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(TrenLoop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TrenLoop()
    {
        tren.SetActive(true);

        yield return new WaitForSeconds(2);
        tren.SetActive(false);
        tren.transform.position = new Vector3(-40f , -5f, 0);
        yield return new WaitForSeconds(1);

       StartCoroutine(TrenLoop());
    }
}
