using UnityEngine;
using UnityEngine.SceneManagement;

public class PinInteraction : MonoBehaviour
{
    [Header("UI a ser mostrada")]
    public GameObject infoCanvas;   
    public GameObject globe;        

    [HideInInspector]
    public bool isInfoOpen = false;

    public void AbrirInfo()
    {
        if (infoCanvas != null)
        {
            infoCanvas.SetActive(true);
            isInfoOpen = true;
        }
    }

    public void FecharInfo()
    {
        if (infoCanvas != null)
        {
            infoCanvas.SetActive(false);
            globe.SetActive(true);
            isInfoOpen = false;
        }
    }

    public void VisualizarParis()
    {
        SceneManager.LoadScene("Teste");
    }

    public void VisualizarGreece()
    {
        SceneManager.LoadScene("Teste2");
    }
}
