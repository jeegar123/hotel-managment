using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotelManagement
{
	class Validation
	{
		public bool CheckEmail(string email)
		{
			Regex regex = new Regex("[a-z]+[a-z0-9.]+@[a-z]*");
			Match match = regex.Match(email);
			if (match.Success)
				return true;
			return false;
		}

		public bool checkTexboxValue(string password)
		{
			if (!password.Equals(""))
				return true;
			return false;
		}

		public bool checkRoomNumber(string room_number)
		{
			Regex regex = new Regex("[\\d]*");
			Match match = regex.Match(room_number);

			if (match.Success)
				return true;
			return false;
		}

	}
}
