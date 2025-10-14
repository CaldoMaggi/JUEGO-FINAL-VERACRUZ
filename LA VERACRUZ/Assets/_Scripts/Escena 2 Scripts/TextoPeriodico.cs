using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextoPeriodico : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private bool dentro;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player")) dentro = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player")) dentro = true;
    }
    public void Update()
    {
        if (dentro && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F)))
        {
            if (canvas.activeSelf) //desactivar
            {
                canvas.SetActive(false);
            }
            else // activar
            {
                canvas.SetActive(true);
            }
        }
    }
}
  
