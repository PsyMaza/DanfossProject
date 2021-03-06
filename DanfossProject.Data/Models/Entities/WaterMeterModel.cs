﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DanfossProject.Data.Models.Entities
{
	public class WaterMeterModel
    {
		[Key]
		public int Id { get; set; }

		[Index(IsUnique = true)]
		[Required(ErrorMessage = "Заводской номер не может быть пустым")]
		[StringLength(15, ErrorMessage = "Длина строки не может содержать более 15 символов")]
		[RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Некорректный номер")]
		public string SerialNumber { get; set; }

		[Required(ErrorMessage = "Показания счетчика не могут быть пустыми")]
		[Range(0, int.MaxValue, ErrorMessage = "Некорректное число")]
		public int CounterValue { get; set; }
	}
}
