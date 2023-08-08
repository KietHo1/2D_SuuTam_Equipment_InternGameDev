using UnityEngine;
using UnityEngine.UI;

public class ScrollBarController : MonoBehaviour
{
    [SerializeField] private Scrollbar scrollbar;

    private void Start() {
        SetInitSize();
    }

    public void SetInitSize(){
        scrollbar.value = 0.001f;
        scrollbar.size = 0.1f;
    }
}
