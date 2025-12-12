using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healed_text : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    public void Show()
    {
        gameObject.SetActive(true);
        CancelInvoke();
        Invoke(nameof(Hide), 3f);
    }
    void Hide()
    {
        gameObject.SetActive(false);
    }
}
