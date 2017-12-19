﻿namespace DemolitionFalcons.App.Commands
{
    using System.Collections.Generic;
    using DemolitionFalcons.App.Interfaces;
    using DemolitionFalcons.Data.DataInterfaces;

    public abstract class Command : ICommand
    {


        public abstract void Execute(IManager gameManager, IOutputWriter writer, IList<string> data);

    }
}
