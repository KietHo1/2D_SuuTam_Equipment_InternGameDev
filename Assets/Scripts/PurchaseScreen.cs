using UnityEngine;

public class PurchaseScreen : MonoBehaviour
{
    public void YesBtnHandler(){
        WeaponIcon iconClicked = ApprBoard.iconClicked;
        iconClicked.UpgradeWeapon();
        InfoBoard.Ins.ShowOnBoard(iconClicked);
        gameObject.SetActive(false);
    }

    public void NoBtnHandler(){
        gameObject.SetActive(false);
    }
}
