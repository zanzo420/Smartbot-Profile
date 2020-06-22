﻿using System;
using System.Collections.Generic;
using System.Linq;
using SmartBot.Database;
using SmartBot.Plugins.API;

namespace SmartBotAPI.Plugins.API
{

    public class SMK_EvenShaman : Archetype
    {
        public string ArchetypeName()
        {
            return "SMK_3C_Totem_Shaman";
        }

        public List<Card.Cards> ArchetypeCardSet()
        {
            return new List<Card.Cards>()
            {
                Cards.DireWolfAlpha,
                Cards.EarthenMight,
                Cards.FlametongueTotem,
                Cards.MurksparkEel,
                Cards.ViciousScalehide,
                Cards.Corpsetaker,
                Cards.Hex,
                Cards.SaroniteChainGang,
                Cards.ArgentCommander,
                Cards.GennGreymane,
                Cards.AlAkirtheWindlord,
                Cards.HagathatheWitch,
                Cards.TheLichKing,
                Cards.KnifeJuggler,
                Cards.PlatedBeetle,
                Cards.PrimalfinTotem,
                Cards.CultMaster,
                Cards.FirePlumePhoenix,
                Cards.Sandbinder,
                Cards.Spellbreaker,
                Cards.FireElemental,
                Cards.GrumbleWorldshaker,
                Cards.KalimosPrimalLord,
                Cards.SeaGiant,
                Cards.Windfury,
                Cards.Zap,
                Cards.StormforgedAxe,

               
                Card.Cards.BOT_539, 
                Card.Cards.BOT_407, 
                Card.Cards.BOT_533, 
            };
        }
    }
}