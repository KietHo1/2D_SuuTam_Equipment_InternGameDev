using UnityEngine;

public class ApprBoard : MonoBehaviour
{
    [Header("Icons")]
    public static WeaponIcon iconClicked;
    public static WeaponIcon iconUsed;

    public void UseBtnHandler(){
        if(iconClicked.status == Status.None){
            iconClicked.SetStatus(Status.Use);

            // Reset status of the previously used icon
            if(iconUsed != null){
                iconUsed.SetStatus(Status.None);
            }
            // Save the currently used icon
            iconUsed = iconClicked;
        }
    }

    public void RenBtnHHandler(){
        if(iconClicked.status == Status.None){
            iconClicked.SetStatus(Status.Rent);
        }
    }
}
