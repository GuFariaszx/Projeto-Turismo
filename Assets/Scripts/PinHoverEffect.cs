using UnityEngine;

public class PinHoverEffect : MonoBehaviour
{
    private Vector3 originalScale;
    private Vector3 targetScale;
    private bool isHovered = false;

    [Header("Configurações de Escala")]
    public float scaleMultiplier = 2f;  
    public float scaleSpeed = 5f;        

    private void Start()
    {
        originalScale = transform.localScale;
        targetScale = originalScale;
    }

    private void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * scaleSpeed);
    }

    private void OnMouseEnter()
    {
        targetScale = originalScale * scaleMultiplier;
        isHovered = true;
    }

    private void OnMouseExit()
    {
        targetScale = originalScale;
        isHovered = false;
    }
}
