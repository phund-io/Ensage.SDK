﻿// <copyright file="item_vladmir.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.Items
{
    using Ensage.SDK.Extensions;

    public class item_vladmir : PassiveAbility, IAuraAbility
    {
        public item_vladmir(Item item)
            : base(item)
        {
        }

        public string AuraModifierName { get; } = "modifier_item_vladmir_aura";

        public float AuraRadius
        {
            get
            {
                return this.Ability.GetAbilitySpecialData("aura_radius");
            }
        }
    }
}