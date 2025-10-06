using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LocaleManager : MonoBehaviour
{
    [Header("Local")]
    public string actualPlace;

    public GameObject greciaObject;
    public GameObject parisObject;

    [Header("UI Elements")]
    public Sprite SpriteG1;
    public Sprite SpriteF1;
    public Image BGCard1;
    public TMP_Text titleCard1;
    public TMP_Text textCard1;
    [Space(10)]
    public Sprite SpriteG2;
    public Sprite SpriteF2;
    public Image BGCard2;
    public TMP_Text titleCard2;
    public TMP_Text textCard2;
    [Space(10)]
    public Sprite SpriteG3;
    public Sprite SpriteF3;
    public Image BGCard3;
    public TMP_Text titleCard3;
    public TMP_Text textCard3;
    [Space(10)]
    public Sprite SpriteG4;
    public Sprite SpriteF4;
    public Image BGCard4;
    public TMP_Text titleCard4;
    public TMP_Text textCard4;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(actualPlace == "Grecia")
        {
            greciaObject.SetActive(true);
            parisObject.SetActive(false);

            BGCard1.sprite = SpriteG1;
            titleCard1.text = "Grecia";
            textCard1.text = "Welcome to Greece, the main place to visit old cultures, something, something";

            BGCard2.sprite = SpriteG2;
            titleCard2.text = "Disc�bolo";
            textCard2.text = "O Disc�bolo, criado por M�ron em 450 a.C., retrata um atleta prestes a lan�ar o disco e tornou-se um �cone do esp�rito esportivo e da arte da Gr�cia Antiga.";

            BGCard3.sprite = SpriteG3;
            titleCard3.text = "Arte";
            textCard3.text = "A arte nos vasos da Gr�cia Antiga retratava cenas mitol�gicas, religiosas e do cotidiano, unindo fun��o pr�tica e express�o art�stica, e tornou-se um dos maiores legados culturais gregos.";

            BGCard4.sprite = SpriteG4;
            titleCard4.text = "Culin�ria";
            textCard4.text = "O souvlaki, de origem na Gr�cia Antiga, � um prato popular feito de carne grelhada no espeto ou p�o, s�mbolo da culin�ria de rua grega.";
        }
        else if(actualPlace == "Paris")
        {
            greciaObject.SetActive(false);
            parisObject.SetActive(true);

            BGCard1.sprite = SpriteF1;
            titleCard1.text = "Paris";
            textCard1.text = "Welcome to Paris, the capital city of France, renowned for its iconic landmarks, world-class art, and romantic ambiance.";

            BGCard2.sprite = SpriteF2;
            titleCard2.text = "TorreEiffel";
            textCard2.text = "A Torre Eiffel, constru�da em 1889 para a Exposi��o Universal, � o maior s�mbolo de Paris e da Fran�a moderna.";

            BGCard3.sprite = SpriteF3;
            titleCard3.text = "B�ret";
            textCard3.text = "O b�ret, criado no s�culo XIX e usado por camponeses e soldados, transformou-se em um dos maiores s�mbolos culturais e da moda francesa.";

            BGCard4.sprite = SpriteF4;
            titleCard4.text = "Culin�ria";
            textCard4.text = "O croissant, de origem austr�aca, chegou � Fran�a no s�culo XVIII e em Paris ganhou sua vers�o folhada amanteigada, tornando-se um �cone da cultura dos caf�s parisienses. O queijo � um importante elemento gastron�mico da Fran�a, devido a seus peculiares e fortes sabores.";

        }
    }

    public void BackScene()
    {
       SceneManager.LoadScene("Cena1");
    }
}
