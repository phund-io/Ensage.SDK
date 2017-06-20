﻿// <copyright file="item_travel_boots_2.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.Items
{
    public class item_travel_boots_2 : RangedAbility, IChannable, IHasModifier, IHasModifierTexture
    {
        public item_travel_boots_2(Item item)
            : base(item)
        {
        }

        public float Duration
        {
            get
            {
                var level = this.Ability.Level;
                if (level == 0)
                {
                    return 0;
                }

                return this.Ability.GetChannelTime(level - 1);
            }
        }

        public bool IsChanneling
        {
            get
            {
                return this.Ability.IsChanneling;
            }
        }

        public string ModifierName { get; } = "modifier_teleporting";

        public string[] ModifierTextureName { get; } = { "item_travel_boots_2" };

        public float RemainingDuration
        {
            get
            {
                if (!this.IsChanneling)
                {
                    return 0;
                }

                return this.Duration - this.Ability.ChannelTime;
            }
        }
    }
}