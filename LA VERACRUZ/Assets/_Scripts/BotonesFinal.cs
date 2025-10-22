using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonesFinal : MonoBehaviour
{
    public Button botonBueno;
    public Button botonMalo;

    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.F))
        {
            botonBueno.onClick.Invoke();
        }

        
        if (Input.GetKeyDown(KeyCode.G))
        {
            botonMalo.onClick.Invoke();
        }
    }
}
