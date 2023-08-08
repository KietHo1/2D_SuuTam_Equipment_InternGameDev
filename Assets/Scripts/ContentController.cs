using UnityEngine;
using UnityEngine.UI;

public class ContentController : MonoBehaviour
{
    [Header("Icons")]
    private int nIcons = 10;
    [SerializeField] private WeaponIcon weaponIcon;


    [Header("Content")]
    [SerializeField] private ToggleGroup toggleGroup;
    [SerializeField] private Transform contentTransform;



    // Start is called before the first frame update
    void Start()
    {
        SpawnIcons();
    }

    private void SpawnIcons(){
        for (int i = 0; i < nIcons; i++){
            // Spawn Icons underneath the content
            WeaponIcon newIcon = Instantiate(weaponIcon, contentTransform);

            // Assign toggle group for each icon
            newIcon.toggle.group = toggleGroup;

            // Set name and initial properties for each icon
            newIcon.SetInitProperties();
            newIcon.SetInitName("Gun" + i.ToString());
        }
    }
}
