using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform cameraTransform;  // A referência à câmera
    public float rotationSpeed = 20f;  // A velocidade de rotação

    private Vector3 lastCameraPosition;
    private float rotationFactor;

    void Start()
    {
        lastCameraPosition = cameraTransform.position; // Guarda a posição inicial da câmera
    }

    void Update()
    {
        // Calcula a diferença de movimento da câmera
        Vector3 cameraMovement = cameraTransform.position - lastCameraPosition;

        // Faz o objeto girar proporcionalmente ao movimento da câmera
        rotationFactor = cameraMovement.magnitude * rotationSpeed;

        // Aplica a rotação ao redor do eixo Y (ou qualquer outro eixo que você queira)
        transform.Rotate(Vector3.up, rotationFactor);

        // Atualiza a posição da câmera para a próxima comparação
        lastCameraPosition = cameraTransform.position;
    }
}
