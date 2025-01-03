using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame.CS2D
{
    public enum TypeItem
    {
        Health,
        Armor,
    }
    public enum TypeHand
    {
        TypeTwo,
        TypeOne,
    }
    public enum TypeWeapon
    {
        Melee,
        MainGun,
    }

    public enum NameWeapon
    {
        AK_47,
        AWP,
        Gatling,
        Uzi,
        Knife,
        Shotgun,
        DE,
        Pistol,
        Grenade_launcher
    }

    public static class Common
    {
        public static string RoundFloat(float value)
        {
            return (Mathf.Round(value * 10f) / 10f).ToString();
        }
    }
}
