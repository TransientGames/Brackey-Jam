using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _interactText;

    public void UpdateTargetText(string txt)
    {
        _interactText.text = txt;
    }
}
