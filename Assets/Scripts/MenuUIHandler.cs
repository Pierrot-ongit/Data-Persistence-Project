using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] GameObject inputField;
    InputField input;
    // Start is called before the first frame update


    void Start()
    {
        input = inputField.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        input.onEndEdit.AddListener(SubmitName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        if(!string.IsNullOrWhiteSpace(input.text))
        {
            SceneManager.LoadScene(1);
        }
    }

    private void SubmitName(string arg0)
    {
        GameManager.Instance.currentPlayerName = arg0;
    }
}
