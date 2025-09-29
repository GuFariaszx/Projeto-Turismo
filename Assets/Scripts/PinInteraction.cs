using UnityEngine;

public class PinInteraction : MonoBehaviour
{
    [Header("Quadro de Informações")]
    public GameObject infoPanel; 

    void Start()
    {
        if (infoPanel != null)
            infoPanel.SetActive(false); 
    }

    private void OnMouseDown()
    {
        ToggleInfo();
    }

    public void ToggleInfo()
    {
        if (infoPanel != null)
            infoPanel.SetActive(!infoPanel.activeSelf);
    }
}
