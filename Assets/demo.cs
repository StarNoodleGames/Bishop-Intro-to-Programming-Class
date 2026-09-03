using TMPro;
using UnityEngine;

public class demo : MonoBehaviour
{
    public TextMeshProUGUI textbox;

    public void OnClick()
    {
        textbox.text = "I am ready to learn";
    }
}