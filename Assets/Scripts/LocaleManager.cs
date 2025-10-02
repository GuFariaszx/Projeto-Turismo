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
            titleCard2.text = "Teste2";
            textCard2.text = "Welcome to Greece, the main place to visit old cultures, something, something2";

            BGCard3.sprite = SpriteG3;
            titleCard3.text = "Teste3";
            textCard3.text = "Welcome to Greece, the main place to visit old cultures, something, something3";

            BGCard4.sprite = SpriteG4;
            titleCard4.text = "Teste4";
            textCard4.text = "Welcome to Greece, the main place to visit old cultures, something, something4";
        }
        else if(actualPlace == "Paris")
        {
            greciaObject.SetActive(false);
            parisObject.SetActive(true);

            BGCard1.sprite = SpriteF1;
            titleCard1.text = "Paris";
            textCard1.text = "Welcome to Paris, the capital city of France, renowned for its iconic landmarks, world-class art, and romantic ambiance.";

            BGCard2.sprite = SpriteF2;
            titleCard2.text = "Teste2";
            textCard2.text = "Welcome to Paris, the capital city of France, renowned for its iconic landmarks, world-class art, and romantic ambiance.2";

            BGCard3.sprite = SpriteF3;
            titleCard3.text = "Teste3";
            textCard3.text = "Welcome to Paris, the capital city of France, renowned for its iconic landmarks, world-class art, and romantic ambiance.3";

            BGCard4.sprite = SpriteF4;
            titleCard4.text = "Teste4";
            textCard4.text = "Welcome to Paris, the capital city of France, renowned for its iconic landmarks, world-class art, and romantic ambiance.4";

        }
    }

    public void BackScene()
    {
       SceneManager.LoadScene("Cena1");
    }
}
