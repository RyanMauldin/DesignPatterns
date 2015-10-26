﻿using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Interfaces;
using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons.Interfaces
{
    public interface IWeapon :
        IItem
    {
        IWeaponCondition WeaponCondition { get; set; }

        ICommand MeleeCommand { get; set; }

        DateTime LastMelee { get; set; }
        decimal MeleeRate { get; }
        void Melee();
        decimal AccuracyMulitplier { get; }
    }
}
