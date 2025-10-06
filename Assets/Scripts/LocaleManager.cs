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
            titleCard2.text = "Discóbolo";
            textCard2.text = "O Discóbolo, criado por Míron em 450 a.C., retrata um atleta prestes a lançar o disco e tornou-se um ícone do espírito esportivo e da arte da Grécia Antiga.";

            BGCard3.sprite = SpriteG3;
            titleCard3.text = "Arte";
            textCard3.text = "A arte nos vasos da Grécia Antiga retratava cenas mitológicas, religiosas e do cotidiano, unindo função prática e expressão artística, e tornou-se um dos maiores legados culturais gregos.";

            BGCard4.sprite = SpriteG4;
            titleCard4.text = "Culinária";
            textCard4.text = "O souvlaki, de origem na Grécia Antiga, é um prato popular feito de carne grelhada no espeto ou pão, símbolo da culinária de rua grega.";
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
            textCard2.text = "A Torre Eiffel, construída em 1889 para a Exposição Universal, é o maior símbolo de Paris e da França moderna.";

            BGCard3.sprite = SpriteF3;
            titleCard3.text = "Béret";
            textCard3.text = "O béret, criado no século XIX e usado por camponeses e soldados, transformou-se em um dos maiores símbolos culturais e da moda francesa.";

            BGCard4.sprite = SpriteF4;
            titleCard4.text = "Culinária";
            textCard4.text = "O croissant, de origem austríaca, chegou à França no século XVIII e em Paris ganhou sua versão folhada amanteigada, tornando-se um ícone da cultura dos cafés parisienses. O queijo é um importante elemento gastronômico da França, devido a seus peculiares e fortes sabores.";

        }
    }

    public void BackScene()
    {
       SceneManager.LoadScene("Cena1");
    }
}
