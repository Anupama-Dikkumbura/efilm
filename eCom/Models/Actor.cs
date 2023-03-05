using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCom.Models
{
	public class Actor
	{
        public Actor()
        {
        }

        [Key]
		public int ID { get; set; }

		public string ProfilePictureURL { get; set; }
		public string FullName { get; set; }
		public string Bio { get; set; }

		//Relationshops
		public List<Actor_Movie> Actors_Movies { get; set; }

    }
}

