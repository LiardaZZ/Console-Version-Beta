﻿namespace DemolitionFalcons.App.Core.DTOs
{
    using System;

    public class CharacterDto
    {
        private string name;

        public CharacterDto()
        {
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 3 || value.Length > 12)
                {
                    throw new ArgumentException("Character name must be between 3 and 12 symbols!");
                }

                this.name = value;
            }
        }
    }
}
