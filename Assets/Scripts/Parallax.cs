using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform cameraTransform;  // A refer�ncia � c�mera
    public float rotationSpeed = 20f;  // A velocidade de rota��o

    private Vector3 lastCameraPosition;
    private float rotationFactor;

    void Start()
    {
        lastCameraPosition = cameraTransform.position; // Guarda a posi��o inicial da c�mera
    }

    void Update()
    {
        // Calcula a diferen�a de movimento da c�mera
        Vector3 cameraMovement = cameraTransform.position - lastCameraPosition;

        // Faz o objeto girar proporcionalmente ao movimento da c�mera
        rotationFactor = cameraMovement.magnitude * rotationSpeed;

        // Aplica a rota��o ao redor do eixo Y (ou qualquer outro eixo que voc� queira)
        transform.Rotate(Vector3.up, rotationFactor);

        // Atualiza a posi��o da c�mera para a pr�xima compara��o
        lastCameraPosition = cameraTransform.position;
    }
}
