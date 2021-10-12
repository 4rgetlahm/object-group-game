﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_group_game
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public string Name { get; private set; }
        public Character Character { get; set; }

        public Player(int PlayerID, string name)
        {
            this.PlayerID = PlayerID;
            this.Name = name;
        }
    }
}
