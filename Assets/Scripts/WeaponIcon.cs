using UnityEngine;
using UnityEngine.UI;

public class WeaponIcon : MonoBehaviour
{

    // Properties
    public string Name { get; private set; }
    public int Damage { get; private set; }
    public int Dispersion { get; private set; }
    public int RateOfFire { get; private set; }
    public int ReloadSpeed { get; private set; }
    public int Ammunition { get; private set; }

    [Header("Status and Toggle")]
    public Toggle toggle;
    public Status status;
    [SerializeField] private Text txtStatus;

    [Header("Color")]
    [SerializeField] private Color colorRent;
    [SerializeField] private Color colorUse;

    public void SetInitProperties(){
        Damage = 25;
        Dispersion = 15;
        RateOfFire = 600;
        ReloadSpeed = 0;
        Ammunition = 100;
        status = Status.None;
        txtStatus.enabled = false;
    }

    public void SetInitName(string name){
        Name = name;
    }

    public void UpgradeWeapon(){
        Damage = Damage + 10;
        Dispersion = Dispersion - 1;
        RateOfFire = RateOfFire + 50;
        ReloadSpeed = ReloadSpeed + 5;
        Ammunition = Ammunition + 10;
    }

    public void OnClickIcon(){
        if(toggle.isOn){
            InfoBoard.Ins.ShowOnBoard(this);
            ApprBoard.iconClicked = this;
        }
    }

    public void SetStatus(Status _status){
        if(_status == Status.None){
            txtStatus.enabled = false;
        }
        else{
            if(_status == Status.Use){
                txtStatus.text = "Used";
                txtStatus.color = colorUse;
            }
            else if(_status == Status.Rent){
                txtStatus.text = "Rended Out";
                txtStatus.color = colorRent;
            }
            txtStatus.enabled = true;
        }

        status = _status;
    }
}

public enum Status{
    None,
    Use,
    Rent
}
