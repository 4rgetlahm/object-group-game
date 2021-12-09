﻿using GameLibrary;
using GameLibrary.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class ExpeditionModel
    {
        public string SessionID { get; set; }
        public Mission Mission { get; set; }
    }

    [ApiController]
    [Route("player/expedition")]
    public class PlayerExpeditionController : Controller
    {
        [HttpPost]
        public Expedition Post([FromBody] ExpeditionModel body)
        {
            if (body == null)
            {
                return null;
            }
            Player player = SessionManager.Instance.Sessions[SessionManager.Instance.GetRealSession(Convert.FromBase64String(body.SessionID))];
            using (var context = new DataContext()) { 
                Character character = context.Character.Include(e => e.Expedition).Where(c => c.CharacterID == player.Character.CharacterID).FirstOrDefault();
                if (character.Expedition != null)
                {
                    return null;
                }
                Random random = new Random();
                Expedition expedition = new Expedition(body.Mission, DateTime.Now, new TimeSpan(LongRandom(body.Mission.MinDuration.Ticks, body.Mission.MaxDuration.Ticks, random)));
                //context.Player.Attach(player);
                player.Character.Expedition = expedition;
                context.Entry(player).State = EntityState.Modified;
                context.SaveChanges();
                //context.Entry(player).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                return expedition;
            }
        }

        long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }
    }
}