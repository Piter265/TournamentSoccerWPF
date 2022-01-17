﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class ClassicalTeamBuilder : ITeamBuilder
    {
        private Team team = new Team();
        private LinkedList<Person> _people = new LinkedList<Person>();

        public ClassicalTeamBuilder()
        {
            this._people = new LinkedList<Person>();
        }

        public void AddPlayersAndCoaches(List <Person> people)
        {
            
        }

        public void SetName(string name)
        {
            team.Name = name;
        }


        public void SetDisability()
        {
            team.Disability = false;
        }


        public void SetGroupAge()
        {
            throw new NotImplementedException();
        }

        public Team GetTeam()
        {
            return team;
        }
    }
}
