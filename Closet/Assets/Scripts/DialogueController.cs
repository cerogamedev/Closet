using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public AudioClip letterSound;

    private string currentText;
    private int currentCharIndex;

    void Start()
    {
        currentText = dialogueText.text;
        dialogueText.text = "";
        currentCharIndex = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentCharIndex < currentText.Length)
            {
                dialogueText.text += currentText[currentCharIndex];
                currentCharIndex++;
                AudioSource.PlayClipAtPoint(letterSound, transform.position);
            }
        }
    }

    public void SetDialogue(string newDialogue)
    {
        currentText = newDialogue;
        dialogueText.text = "";
        currentCharIndex = 0;
    }
}
