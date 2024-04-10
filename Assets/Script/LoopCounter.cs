using UnityEngine;

public class LoopCounter : MonoBehaviour
{
    private const int LOOP_MAX = 10;
    [SerializeField] UnityEngine.UI.Text _textUI;
    private int _counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (!_textUI) _textUI = GetComponentInChildren<UnityEngine.UI.Text>();
        UpdateText();
    }

    public void Increment()
    {
        _counter++;
        _counter %= LOOP_MAX;
        UpdateText();
    }

    public void UpdateText()
    {
        _textUI.text = _counter.ToString();
    }
}
