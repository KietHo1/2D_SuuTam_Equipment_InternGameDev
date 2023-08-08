using UnityEngine;
using UnityEngine.UI;

public class InfoBoard : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] private Text txtName;
    [SerializeField] private Text txtDamage;
    [SerializeField] private Text txtDispersion;
    [SerializeField] private Text txtRateOfFire;
    [SerializeField] private Text txtReloadSpeed;
    [SerializeField] private Text txtAmmunition;

    [Header("Screen")]
    [SerializeField] private GameObject purchaseScreen;

    // Static instance property
    public static InfoBoard Ins {get; private set; }

    private void Start() {
        Ins = this;
    }

    public void ShowOnBoard(WeaponIcon icon){
        txtName.text = icon.Name;
        txtDamage.text = icon.Damage.ToString();
        txtDispersion.text = icon.Dispersion.ToString();
        txtRateOfFire.text = icon.RateOfFire.ToString() + "RPM";
        txtReloadSpeed.text = icon.ReloadSpeed.ToString() + "%";
        txtAmmunition.text = "100/" + icon.Ammunition.ToString();
    }

    public void ActivePurchaseScreen(){
        purchaseScreen.SetActive(true);
    }
}
