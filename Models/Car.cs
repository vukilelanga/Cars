using System;
using System.ComponentModel.DataAnnotations;

namespace Cars.Models{
	public class Car{
		public int ID{
			get;
			set;
		}

		public string Name{
			get;
			set;
		}

		[Display(Name = "Model Year")]
		public int Year{
			get;
			set;
		}
	}
}