using System;
using System.ComponentModel.DataAnnotations;

namespace eCom.Models
{
	public class Cinema
	{
		public Cinema()
		{
		}

        [Key]
        public int ID { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}

