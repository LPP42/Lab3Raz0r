
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models;


public class User
{
	public int UserId { get; set; }
	[RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$")]
	public string? Name { get; set; }
	[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
	public string? Email { get; set; }
	[RegularExpression("^[0-9]+$")]
	public int? StreetNumber { get; set; }
	[RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$")]
	public string? StreetName { get; set; }

	[RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please enter postal code in A1A 1A1 format")]
	public string? PostalCode { get; set; }
	[RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$")]
	public string? City { get; set; }
	[RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$")]
	public string? Province { get; set; }
	[RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}")]
	public string? Phone { get; set; }
}