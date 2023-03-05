using System;
using System.ComponentModel.DataAnnotations;

namespace eCom.Models
{
	public class Producer
	{
		public Producer()
		{
		}

        [Key]
        public int ID { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}

