﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyClub
{
    public interface IPonyManager
    {
        public SuperPony GetRandomSuperPony();

        public string ListPoniesOnTheSamePosition(); //the return type is to be modified!!!

        public Pony CreatePony(PonyType type, string name);
    }
}
